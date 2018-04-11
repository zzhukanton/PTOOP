namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxPeople = new System.Windows.Forms.ListBox();
            this.btnLoadSalad = new System.Windows.Forms.Button();
            this.btnSaveSalad = new System.Windows.Forms.Button();
            this.ddlVegetableType = new System.Windows.Forms.ComboBox();
            this.btnAddVegetable = new System.Windows.Forms.Button();
            this.btnRemoveSelectedVegetable = new System.Windows.Forms.Button();
            this.btnNewSalad = new System.Windows.Forms.Button();
            this.txbVegetableName = new System.Windows.Forms.TextBox();
            this.btnEditVegetableName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRandomSalad = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lbxPeople
            // 
            this.lbxPeople.FormattingEnabled = true;
            this.lbxPeople.Location = new System.Drawing.Point(12, 29);
            this.lbxPeople.Name = "lbxPeople";
            this.lbxPeople.Size = new System.Drawing.Size(128, 277);
            this.lbxPeople.TabIndex = 0;
            this.lbxPeople.SelectedIndexChanged += new System.EventHandler(this.lbxPeople_SelectedIndexChanged);
            // 
            // btnLoadSalad
            // 
            this.btnLoadSalad.Location = new System.Drawing.Point(163, 60);
            this.btnLoadSalad.Name = "btnLoadSalad";
            this.btnLoadSalad.Size = new System.Drawing.Size(118, 23);
            this.btnLoadSalad.TabIndex = 1;
            this.btnLoadSalad.Text = "Load salad";
            this.btnLoadSalad.UseVisualStyleBackColor = true;
            this.btnLoadSalad.Click += new System.EventHandler(this.btnLoadKingdom_Click);
            // 
            // btnSaveSalad
            // 
            this.btnSaveSalad.Location = new System.Drawing.Point(163, 89);
            this.btnSaveSalad.Name = "btnSaveSalad";
            this.btnSaveSalad.Size = new System.Drawing.Size(118, 23);
            this.btnSaveSalad.TabIndex = 2;
            this.btnSaveSalad.Text = "Save salad";
            this.btnSaveSalad.UseVisualStyleBackColor = true;
            this.btnSaveSalad.Click += new System.EventHandler(this.btnSaveKingdom_Click);
            // 
            // ddlVegetableType
            // 
            this.ddlVegetableType.FormattingEnabled = true;
            this.ddlVegetableType.Location = new System.Drawing.Point(163, 138);
            this.ddlVegetableType.Name = "ddlVegetableType";
            this.ddlVegetableType.Size = new System.Drawing.Size(118, 21);
            this.ddlVegetableType.TabIndex = 3;
            // 
            // btnAddVegetable
            // 
            this.btnAddVegetable.Location = new System.Drawing.Point(163, 165);
            this.btnAddVegetable.Name = "btnAddVegetable";
            this.btnAddVegetable.Size = new System.Drawing.Size(118, 23);
            this.btnAddVegetable.TabIndex = 4;
            this.btnAddVegetable.Text = "Add vegetable";
            this.btnAddVegetable.UseVisualStyleBackColor = true;
            this.btnAddVegetable.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnRemoveSelectedVegetable
            // 
            this.btnRemoveSelectedVegetable.Location = new System.Drawing.Point(163, 283);
            this.btnRemoveSelectedVegetable.Name = "btnRemoveSelectedVegetable";
            this.btnRemoveSelectedVegetable.Size = new System.Drawing.Size(118, 23);
            this.btnRemoveSelectedVegetable.TabIndex = 5;
            this.btnRemoveSelectedVegetable.Text = "Remove selected";
            this.btnRemoveSelectedVegetable.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedVegetable.Click += new System.EventHandler(this.btnRemoveSelectedPerson_Click);
            // 
            // btnNewSalad
            // 
            this.btnNewSalad.Location = new System.Drawing.Point(163, 29);
            this.btnNewSalad.Name = "btnNewSalad";
            this.btnNewSalad.Size = new System.Drawing.Size(118, 23);
            this.btnNewSalad.TabIndex = 6;
            this.btnNewSalad.Text = "New salad";
            this.btnNewSalad.UseVisualStyleBackColor = true;
            this.btnNewSalad.Click += new System.EventHandler(this.button5_Click);
            // 
            // txbVegetableName
            // 
            this.txbVegetableName.Location = new System.Drawing.Point(163, 210);
            this.txbVegetableName.Name = "txbVegetableName";
            this.txbVegetableName.Size = new System.Drawing.Size(118, 20);
            this.txbVegetableName.TabIndex = 7;
            // 
            // btnEditVegetableName
            // 
            this.btnEditVegetableName.Location = new System.Drawing.Point(163, 236);
            this.btnEditVegetableName.Name = "btnEditVegetableName";
            this.btnEditVegetableName.Size = new System.Drawing.Size(118, 23);
            this.btnEditVegetableName.TabIndex = 8;
            this.btnEditVegetableName.Text = "Edit title";
            this.btnEditVegetableName.UseVisualStyleBackColor = true;
            this.btnEditVegetableName.Click += new System.EventHandler(this.btnEditPersonName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "The VEGETABLES";
            // 
            // btnRandomSalad
            // 
            this.btnRandomSalad.Location = new System.Drawing.Point(12, 312);
            this.btnRandomSalad.Name = "btnRandomSalad";
            this.btnRandomSalad.Size = new System.Drawing.Size(128, 23);
            this.btnRandomSalad.TabIndex = 10;
            this.btnRandomSalad.Text = "Random salad";
            this.btnRandomSalad.UseVisualStyleBackColor = true;
            this.btnRandomSalad.Click += new System.EventHandler(this.btnTiredTester_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 349);
            this.Controls.Add(this.btnRandomSalad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditVegetableName);
            this.Controls.Add(this.txbVegetableName);
            this.Controls.Add(this.btnNewSalad);
            this.Controls.Add(this.btnRemoveSelectedVegetable);
            this.Controls.Add(this.btnAddVegetable);
            this.Controls.Add(this.ddlVegetableType);
            this.Controls.Add(this.btnSaveSalad);
            this.Controls.Add(this.btnLoadSalad);
            this.Controls.Add(this.lbxPeople);
            this.Name = "Form1";
            this.Text = "SALAD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxPeople;
        private System.Windows.Forms.Button btnLoadSalad;
        private System.Windows.Forms.Button btnSaveSalad;
        private System.Windows.Forms.ComboBox ddlVegetableType;
        private System.Windows.Forms.Button btnAddVegetable;
        private System.Windows.Forms.Button btnRemoveSelectedVegetable;
        private System.Windows.Forms.Button btnNewSalad;
        private System.Windows.Forms.TextBox txbVegetableName;
        private System.Windows.Forms.Button btnEditVegetableName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRandomSalad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

