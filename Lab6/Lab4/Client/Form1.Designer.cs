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
            this.lbxVegetables = new System.Windows.Forms.ListBox();
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
            this.cbxEncryptData = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbxVegetables
            // 
            this.lbxVegetables.FormattingEnabled = true;
            this.lbxVegetables.Location = new System.Drawing.Point(12, 31);
            this.lbxVegetables.Name = "lbxVegetables";
            this.lbxVegetables.Size = new System.Drawing.Size(128, 277);
            this.lbxVegetables.TabIndex = 0;
            this.lbxVegetables.SelectedIndexChanged += new System.EventHandler(this.lbxVegetables_SelectedIndexChanged);
            // 
            // btnLoadSalad
            // 
            this.btnLoadSalad.Location = new System.Drawing.Point(163, 60);
            this.btnLoadSalad.Name = "btnLoadSalad";
            this.btnLoadSalad.Size = new System.Drawing.Size(118, 23);
            this.btnLoadSalad.TabIndex = 1;
            this.btnLoadSalad.Text = "Load salad";
            this.btnLoadSalad.UseVisualStyleBackColor = true;
            this.btnLoadSalad.Click += new System.EventHandler(this.btnLoadSalad_Click);
            // 
            // btnSaveSalad
            // 
            this.btnSaveSalad.Location = new System.Drawing.Point(163, 89);
            this.btnSaveSalad.Name = "btnSaveSalad";
            this.btnSaveSalad.Size = new System.Drawing.Size(118, 23);
            this.btnSaveSalad.TabIndex = 2;
            this.btnSaveSalad.Text = "Save salad";
            this.btnSaveSalad.UseVisualStyleBackColor = true;
            this.btnSaveSalad.Click += new System.EventHandler(this.btnSaveSalad_Click);
            // 
            // ddlVegetableType
            // 
            this.ddlVegetableType.FormattingEnabled = true;
            this.ddlVegetableType.Location = new System.Drawing.Point(163, 132);
            this.ddlVegetableType.Name = "ddlVegetableType";
            this.ddlVegetableType.Size = new System.Drawing.Size(118, 21);
            this.ddlVegetableType.TabIndex = 3;
            // 
            // btnAddVegetable
            // 
            this.btnAddVegetable.Location = new System.Drawing.Point(163, 159);
            this.btnAddVegetable.Name = "btnAddVegetable";
            this.btnAddVegetable.Size = new System.Drawing.Size(118, 23);
            this.btnAddVegetable.TabIndex = 4;
            this.btnAddVegetable.Text = "Add vegetable";
            this.btnAddVegetable.UseVisualStyleBackColor = true;
            this.btnAddVegetable.Click += new System.EventHandler(this.btnAddVegetable_Click);
            // 
            // btnRemoveSelectedVegetable
            // 
            this.btnRemoveSelectedVegetable.Location = new System.Drawing.Point(163, 285);
            this.btnRemoveSelectedVegetable.Name = "btnRemoveSelectedVegetable";
            this.btnRemoveSelectedVegetable.Size = new System.Drawing.Size(118, 23);
            this.btnRemoveSelectedVegetable.TabIndex = 5;
            this.btnRemoveSelectedVegetable.Text = "Remove selected";
            this.btnRemoveSelectedVegetable.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedVegetable.Click += new System.EventHandler(this.btnRemoveSelectedVegetable_Click);
            // 
            // btnNewSalad
            // 
            this.btnNewSalad.Location = new System.Drawing.Point(163, 31);
            this.btnNewSalad.Name = "btnNewSalad";
            this.btnNewSalad.Size = new System.Drawing.Size(118, 23);
            this.btnNewSalad.TabIndex = 6;
            this.btnNewSalad.Text = "New salad";
            this.btnNewSalad.UseVisualStyleBackColor = true;
            this.btnNewSalad.Click += new System.EventHandler(this.button5_Click);
            // 
            // txbVegetableName
            // 
            this.txbVegetableName.Location = new System.Drawing.Point(163, 202);
            this.txbVegetableName.Name = "txbVegetableName";
            this.txbVegetableName.Size = new System.Drawing.Size(118, 20);
            this.txbVegetableName.TabIndex = 7;
            // 
            // btnEditVegetableName
            // 
            this.btnEditVegetableName.Location = new System.Drawing.Point(163, 228);
            this.btnEditVegetableName.Name = "btnEditVegetableName";
            this.btnEditVegetableName.Size = new System.Drawing.Size(118, 23);
            this.btnEditVegetableName.TabIndex = 8;
            this.btnEditVegetableName.Text = "Edit title";
            this.btnEditVegetableName.UseVisualStyleBackColor = true;
            this.btnEditVegetableName.Click += new System.EventHandler(this.btnEditVegetableName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "The VEGETABLES";
            // 
            // btnRandomSalad
            // 
            this.btnRandomSalad.Location = new System.Drawing.Point(12, 314);
            this.btnRandomSalad.Name = "btnRandomSalad";
            this.btnRandomSalad.Size = new System.Drawing.Size(128, 23);
            this.btnRandomSalad.TabIndex = 10;
            this.btnRandomSalad.Text = "RandomSalad";
            this.btnRandomSalad.UseVisualStyleBackColor = true;
            this.btnRandomSalad.Click += new System.EventHandler(this.btnRandomSalad_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbxEncryptData
            // 
            this.cbxEncryptData.AutoSize = true;
            this.cbxEncryptData.Location = new System.Drawing.Point(163, 318);
            this.cbxEncryptData.Name = "cbxEncryptData";
            this.cbxEncryptData.Size = new System.Drawing.Size(86, 17);
            this.cbxEncryptData.TabIndex = 12;
            this.cbxEncryptData.Text = "Encrypt data";
            this.cbxEncryptData.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 350);
            this.Controls.Add(this.cbxEncryptData);
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
            this.Controls.Add(this.lbxVegetables);
            this.Name = "Form1";
            this.Text = "SALAD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxVegetables;
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
        private System.Windows.Forms.CheckBox cbxEncryptData;
    }
}

