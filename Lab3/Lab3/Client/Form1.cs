using System;
using System.Collections.Generic;
using System.IO;
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
         
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InitializeNewSalad();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeNewSalad();
        }

        private void InitializeNewSalad(List<Vegetable> deserializedKingdom = null)
        {
            _currentSalad = new Salad(deserializedKingdom);
            
            lbxPeople.Items.Clear();
            txbPersonName.Text = "";

            InitializePersonTypes();
        }

        private void InitializePersonTypes()
        {
            _vegetableTypes = LoadPersonTypes();

            ddlPersonType.Items.Clear();
            foreach (var personType in _vegetableTypes)
            {
                ddlPersonType.Items.Add(new ComboboxItem {Text = personType.Name, Value = personType });
            }
        }

        private List<Type> LoadPersonTypes()
        {
            var personTypes = new List<Type>();

            foreach (Assembly a in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (Type t in a.GetTypes())
                {
                    if (t.IsSubclassOf(typeof (Vegetable)))
                    {
                        personTypes.Add(t);
                    }
                }
            }
            return personTypes;
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            var selectedPersonType = ddlPersonType.SelectedItem as ComboboxItem;

            if (selectedPersonType == null)
            {
                return;
            }

            var newPerson = Activator.CreateInstance((Type) selectedPersonType.Value) as Vegetable;

            if (newPerson == null)
            {
                 return;
            }

            _currentSalad.Ingridients.Add(newPerson);

            DrawCurrentSalad();
        }

        private void DrawCurrentSalad()
        {
            lbxPeople.Items.Clear();

            foreach (var person in _currentSalad.Ingridients)
            {
                lbxPeople.Items.Add(new ComboboxItem {Text = person.FullName, Value = person});
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

            var person = currentVegetable.Value as Vegetable;
            if (person == null)
            {
                return;
            }

            _currentSalad.Ingridients.Remove(person);

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
                    var serializedKingdom = XmlHelper.Serialize(_currentSalad?.Ingridients, _vegetableTypes.ToArray());
                    File.WriteAllText(filePath, serializedKingdom, Encoding.UTF8);
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
