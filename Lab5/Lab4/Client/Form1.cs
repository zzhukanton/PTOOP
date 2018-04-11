using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Models;
using Helpers;

namespace Client
{
    public partial class Form1 : Form
    {
        private Salad _currentSalad;
        private List<Type> _vegetableTypes;
        private AesEncryptionUtility _aesEncryptionUtility;

        public Form1()
        {
            _aesEncryptionUtility = new AesEncryptionUtility();
            InitializeComponent();
        }

        private List<Type> LoadPlugins()
        {
            var personTypes = new List<Type>();
            string[] assemblies = Directory.GetFiles("Plugins", "*.dll");

            foreach (String file in assemblies)
            {
                try
                {
                    if (File.Exists(file))
                    {
                        // load the assembly
                        var asm = Assembly.LoadFrom(file);

                        // get all types from the assembly that inherit ITask
                        var query = from t in asm.GetTypes()
                                    where t.IsSubclassOf(typeof(Vegetable))
                                    select t;

                        // add types to list of startup tasks
                        foreach (Type type in query)
                        {
                            personTypes.Add(type);
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }

            return personTypes;
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            InitializeNewSalad();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeNewSalad();
        }

        private void InitializeNewSalad(List<Vegetable> deserializedSalad = null)
        {
            _currentSalad = new Salad(deserializedSalad);
            
            lbxPeople.Items.Clear();
            txbPersonName.Text = "";

            InitializeVegetableTypes();
        }

        private void InitializeVegetableTypes()
        {
            _vegetableTypes = LoadVegetableTypes();

            ddlPersonType.Items.Clear();
            foreach (var vegetableType in _vegetableTypes)
            {
                ddlPersonType.Items.Add(new ComboboxItem {Text = vegetableType.Name, Value = vegetableType });
            }

            var pluginTypes = LoadPlugins();
            foreach (var vegetableType in pluginTypes)
            {
                ddlPersonType.Items.Add(new ComboboxItem { Text = vegetableType.Name, Value = vegetableType });
            }
        }

        private List<Type> LoadVegetableTypes()
        {
            var vegetableTypes = new List<Type>();

            foreach (Assembly a in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (Type t in a.GetTypes())
                {
                    if (t.IsSubclassOf(typeof (Vegetable)))
                    {
                        vegetableTypes.Add(t);
                    }
                }
            }
            return vegetableTypes;
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            var selectedPersonType = ddlPersonType.SelectedItem as ComboboxItem;

            if (selectedPersonType == null)
            {
                return;
            }

            var newVegetable = Activator.CreateInstance((Type) selectedPersonType.Value) as Vegetable;

            if (newVegetable == null)
            {
                 return;
            }

            _currentSalad.Ingridients.Add(newVegetable);

            DrawCurrentSalad();
        }

        private void DrawCurrentSalad()
        {
            lbxPeople.Items.Clear();

            foreach (var vegetable in _currentSalad.Ingridients)
            {
                lbxPeople.Items.Add(new ComboboxItem {Text = vegetable.FullName, Value = vegetable });
            }
        }

        private void btnTiredTester_Click(object sender, EventArgs e)
        {
            foreach (var item in ddlPersonType.Items)
            {
                ddlPersonType.SelectedItem = item;
                btnAddPerson.PerformClick();
            }
        }

        private void lbxPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentPerson = (sender as ListBox)?.SelectedItem as ComboboxItem;

            if (currentPerson == null)
            {
                return;
            }

            txbPersonName.Text = (currentPerson.Value as Vegetable)?.Name;
        }

        private void btnEditPersonName_Click(object sender, EventArgs e)
        {
            var currentPerson = lbxPeople.SelectedItem as ComboboxItem;

            if (currentPerson == null)
            {
                return;
            }

            var currentPersonName = txbPersonName.Text;

            if (string.IsNullOrEmpty(currentPersonName) || string.IsNullOrWhiteSpace(currentPersonName))
            {
                return;
            }

            var person = currentPerson.Value as Vegetable;
            if (person != null)
            {
                person.Name = currentPersonName;
            }

            DrawCurrentSalad();
        }

        private void btnRemoveSelectedPerson_Click(object sender, EventArgs e)
        {
            var currentVegetable = lbxPeople.SelectedItem as ComboboxItem;

            if (currentVegetable == null)
            {
                return;
            }

            var vegetable = currentVegetable.Value as Vegetable;
            if (vegetable == null)
            {
                return;
            }

            _currentSalad.Ingridients.Remove(vegetable);

            DrawCurrentSalad();
        }

        private void btnSaveKingdom_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                try
                {
                    var serializedSalad = XmlHelper.Serialize(_currentSalad?.Ingridients, _vegetableTypes.ToArray());

                    if (cbxEncryptData.Checked)
                    {
                        serializedSalad = _aesEncryptionUtility.Encrypt(serializedSalad);
                    }

                    File.WriteAllText(filePath, serializedSalad, Encoding.UTF8);
                }
                catch (IOException)
                {
                }
            }
        }

        private void btnLoadKingdom_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                try
                {
                    var fileString = File.ReadAllText(filePath);

                    if (cbxEncryptData.Checked)
                    {
                        fileString = _aesEncryptionUtility.Decrypt(fileString);
                    }

                    var deserializedSalad = XmlHelper.DeserializeFromFile<List<Vegetable>>(filePath, _vegetableTypes.ToArray());
                    InitializeNewSalad(deserializedSalad);
                }
                catch(Exception)
                {
                    InitializeNewSalad();
                }

                DrawCurrentSalad();
            }
        }
    }
}
