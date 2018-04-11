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
         
        public Form1() => InitializeComponent();

        private void button5_Click(object sender, EventArgs e) => InitializeNewSalad();
        
        private void Form1_Load(object sender, EventArgs e) => InitializeNewSalad();
        
        private void InitializeNewSalad(List<Vegetable> deserializedSalad = null)
        {
            _currentSalad = new Salad(deserializedSalad);
            
            lbxVegetables.Items.Clear();
            txbVegetableName.Text = "";

            InitializeVegetableTypes();
        }

        private void InitializeVegetableTypes()
        {
            _vegetableTypes = LoadVegetableTypes();

            ddlVegetableType.Items.Clear();
            foreach (var vegetableType in _vegetableTypes)
            {
                ddlVegetableType.Items.Add(new ComboboxItem {Text = vegetableType.Name, Value = vegetableType });
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

        private void btnAddVegetable_Click(object sender, EventArgs e)
        {
            var selectedvegetableType = ddlVegetableType.SelectedItem as ComboboxItem;
            if (selectedvegetableType == null) return;

            var newVegetable = Activator.CreateInstance((Type)selectedvegetableType.Value) as Vegetable;
            if (newVegetable == null) return;

            _currentSalad.Ingridients.Add(newVegetable);

            PrintCurrentSalad();
        }

        private void PrintCurrentSalad()
        {
            lbxVegetables.Items.Clear();

            foreach (var vegetable in _currentSalad.Ingridients)
            {
                lbxVegetables.Items.Add(new ComboboxItem {Text = vegetable.FullName, Value = vegetable });
            }
        }

        private void btnRandomSalad_Click(object sender, EventArgs e)
        {
            foreach (var item in ddlVegetableType.Items)
            {
                ddlVegetableType.SelectedItem = item;
                btnAddVegetable.PerformClick();
            }
        }

        private void lbxVegetables_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentVegetable = (sender as ListBox)?.SelectedItem as ComboboxItem;

            if (currentVegetable == null) return;

            txbVegetableName.Text = (currentVegetable.Value as Vegetable)?.Name;
        }

        private void btnEditVegetableName_Click(object sender, EventArgs e)
        {
            var currentVegetable = lbxVegetables.SelectedItem as ComboboxItem;
            if (currentVegetable == null) return;

            var currentVegetableName = txbVegetableName.Text;

            if (string.IsNullOrEmpty(currentVegetableName) || string.IsNullOrWhiteSpace(currentVegetableName)) return;

            var vegetable = currentVegetable.Value as Vegetable;
            if (vegetable != null)
            {
                vegetable.Name = currentVegetableName;
            }

            PrintCurrentSalad();
        }

        private void btnRemoveSelectedVegetable_Click(object sender, EventArgs e)
        {
            var currentVegetable = lbxVegetables.SelectedItem as ComboboxItem;
            if (currentVegetable == null) return;

            var vegetable = currentVegetable.Value as Vegetable;
            if (vegetable == null) return;

            _currentSalad.Ingridients.Remove(vegetable);

            PrintCurrentSalad();
        }

        private void btnSaveSalad_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                try
                {
                    var serializedSalad = XmlHelper.Serialize(_currentSalad?.Ingridients, _vegetableTypes.ToArray());
                    File.WriteAllText(filePath, serializedSalad, Encoding.UTF8);
                }
                catch (IOException) { }
            }
        }

        private void btnLoadSalad_Click(object sender, EventArgs e)
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

                PrintCurrentSalad();
            }
        }
    }
}
