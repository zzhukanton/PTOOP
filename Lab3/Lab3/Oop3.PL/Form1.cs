using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oop3.Contracts;
using Oop3.Core;

namespace Oop3.PL
{
    public partial class Form1 : Form
    {
        private Kingdom _currentKingdom;
        private List<Type> _personTypes;
         
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InitializeNewKingdom();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeNewKingdom();
        }

        private void InitializeNewKingdom(List<Person> deserializedKingdom = null)
        {
            _currentKingdom = new Kingdom(deserializedKingdom);
            
            lbxPeople.Items.Clear();
            txbPersonName.Text = "";

            InitializePersonTypes();
        }

        private void InitializePersonTypes()
        {
            _personTypes = LoadPersonTypes();

            ddlPersonType.Items.Clear();
            foreach (var personType in _personTypes)
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
                    if (t.IsSubclassOf(typeof (Person)))
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

            var newPerson = Activator.CreateInstance((Type) selectedPersonType.Value) as Person;

            if (newPerson == null)
            {
                 return;
            }

            _currentKingdom.PeopleOfKingdom.Add(newPerson);

            DrawCurrentKingdom();
        }

        private void DrawCurrentKingdom()
        {
            lbxPeople.Items.Clear();

            foreach (var person in _currentKingdom.PeopleOfKingdom)
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

            txbPersonName.Text = (currentPerson.Value as Person)?.Name;
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

            var person = currentPerson.Value as Person;
            if (person != null)
            {
                person.Name = currentPersonName;
            }

            DrawCurrentKingdom();
        }

        private void btnRemoveSelectedPerson_Click(object sender, EventArgs e)
        {
            var currentPerson = lbxPeople.SelectedItem as ComboboxItem;

            if (currentPerson == null)
            {
                return;
            }

            var person = currentPerson.Value as Person;
            if (person == null)
            {
                return;
            }

            _currentKingdom.PeopleOfKingdom.Remove(person);

            DrawCurrentKingdom();
        }

        private void btnSaveKingdom_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                try
                {
                    var serializedKingdom = XmlHelper.Serialize(_currentKingdom?.PeopleOfKingdom, _personTypes.ToArray());
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
                    var deserializedKingdom = XmlHelper.DeserializeFromFile<List<Person>>(filePath, _personTypes.ToArray());
                    InitializeNewKingdom(deserializedKingdom);
                }
                catch(Exception)
                {
                    InitializeNewKingdom();
                }

                DrawCurrentKingdom();
            }
        }
    }
}
