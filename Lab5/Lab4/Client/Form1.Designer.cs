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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbxPeople = new System.Windows.Forms.ListBox();
            this.btnLoadKingdom = new System.Windows.Forms.Button();
            this.btnSaveKingdom = new System.Windows.Forms.Button();
            this.ddlPersonType = new System.Windows.Forms.ComboBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnRemoveSelectedPerson = new System.Windows.Forms.Button();
            this.btnNewKingdom = new System.Windows.Forms.Button();
            this.txbPersonName = new System.Windows.Forms.TextBox();
            this.btnEditPersonName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTiredTester = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.cbxEncryptData = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbxPeople
            // 
            this.lbxPeople.FormattingEnabled = true;
            this.lbxPeople.Location = new System.Drawing.Point(361, 54);
            this.lbxPeople.Name = "lbxPeople";
            this.lbxPeople.Size = new System.Drawing.Size(399, 277);
            this.lbxPeople.TabIndex = 0;
            this.lbxPeople.SelectedIndexChanged += new System.EventHandler(this.lbxPeople_SelectedIndexChanged);
            // 
            // btnLoadKingdom
            // 
            this.btnLoadKingdom.Location = new System.Drawing.Point(127, 13);
            this.btnLoadKingdom.Name = "btnLoadKingdom";
            this.btnLoadKingdom.Size = new System.Drawing.Size(121, 23);
            this.btnLoadKingdom.TabIndex = 1;
            this.btnLoadKingdom.Text = "Load salad";
            this.btnLoadKingdom.UseVisualStyleBackColor = true;
            this.btnLoadKingdom.Click += new System.EventHandler(this.btnLoadKingdom_Click);
            // 
            // btnSaveKingdom
            // 
            this.btnSaveKingdom.Location = new System.Drawing.Point(245, 13);
            this.btnSaveKingdom.Name = "btnSaveKingdom";
            this.btnSaveKingdom.Size = new System.Drawing.Size(110, 23);
            this.btnSaveKingdom.TabIndex = 2;
            this.btnSaveKingdom.Text = "Save salad";
            this.btnSaveKingdom.UseVisualStyleBackColor = true;
            this.btnSaveKingdom.Click += new System.EventHandler(this.btnSaveKingdom_Click);
            // 
            // ddlPersonType
            // 
            this.ddlPersonType.FormattingEnabled = true;
            this.ddlPersonType.Location = new System.Drawing.Point(12, 58);
            this.ddlPersonType.Name = "ddlPersonType";
            this.ddlPersonType.Size = new System.Drawing.Size(343, 21);
            this.ddlPersonType.TabIndex = 3;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(12, 85);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(343, 23);
            this.btnAddPerson.TabIndex = 4;
            this.btnAddPerson.Text = "Add vegetable";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnRemoveSelectedPerson
            // 
            this.btnRemoveSelectedPerson.Location = new System.Drawing.Point(12, 308);
            this.btnRemoveSelectedPerson.Name = "btnRemoveSelectedPerson";
            this.btnRemoveSelectedPerson.Size = new System.Drawing.Size(343, 23);
            this.btnRemoveSelectedPerson.TabIndex = 5;
            this.btnRemoveSelectedPerson.Text = "Remove selected";
            this.btnRemoveSelectedPerson.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedPerson.Click += new System.EventHandler(this.btnRemoveSelectedPerson_Click);
            // 
            // btnNewKingdom
            // 
            this.btnNewKingdom.Location = new System.Drawing.Point(12, 13);
            this.btnNewKingdom.Name = "btnNewKingdom";
            this.btnNewKingdom.Size = new System.Drawing.Size(118, 23);
            this.btnNewKingdom.TabIndex = 6;
            this.btnNewKingdom.Text = "New salad";
            this.btnNewKingdom.UseVisualStyleBackColor = true;
            this.btnNewKingdom.Click += new System.EventHandler(this.button5_Click);
            // 
            // txbPersonName
            // 
            this.txbPersonName.Location = new System.Drawing.Point(12, 164);
            this.txbPersonName.Name = "txbPersonName";
            this.txbPersonName.Size = new System.Drawing.Size(343, 20);
            this.txbPersonName.TabIndex = 7;
            // 
            // btnEditPersonName
            // 
            this.btnEditPersonName.Location = new System.Drawing.Point(13, 191);
            this.btnEditPersonName.Name = "btnEditPersonName";
            this.btnEditPersonName.Size = new System.Drawing.Size(342, 23);
            this.btnEditPersonName.TabIndex = 8;
            this.btnEditPersonName.Text = "Edit title";
            this.btnEditPersonName.UseVisualStyleBackColor = true;
            this.btnEditPersonName.Click += new System.EventHandler(this.btnEditPersonName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "The VEGETABLES";
            // 
            // btnTiredTester
            // 
            this.btnTiredTester.Location = new System.Drawing.Point(651, 16);
            this.btnTiredTester.Name = "btnTiredTester";
            this.btnTiredTester.Size = new System.Drawing.Size(109, 23);
            this.btnTiredTester.TabIndex = 10;
            this.btnTiredTester.Text = "When too tired...";
            this.btnTiredTester.UseVisualStyleBackColor = true;
            this.btnTiredTester.Click += new System.EventHandler(this.btnTiredTester_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbxEncryptData
            // 
            this.cbxEncryptData.AutoSize = true;
            this.cbxEncryptData.Location = new System.Drawing.Point(13, 259);
            this.cbxEncryptData.Name = "cbxEncryptData";
            this.cbxEncryptData.Size = new System.Drawing.Size(134, 17);
            this.cbxEncryptData.TabIndex = 12;
            this.cbxEncryptData.Text = "Run in protected mode";
            this.cbxEncryptData.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 346);
            this.Controls.Add(this.cbxEncryptData);
            this.Controls.Add(this.btnTiredTester);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditPersonName);
            this.Controls.Add(this.txbPersonName);
            this.Controls.Add(this.btnNewKingdom);
            this.Controls.Add(this.btnRemoveSelectedPerson);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.ddlPersonType);
            this.Controls.Add(this.btnSaveKingdom);
            this.Controls.Add(this.btnLoadKingdom);
            this.Controls.Add(this.lbxPeople);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "The salad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxPeople;
        private System.Windows.Forms.Button btnLoadKingdom;
        private System.Windows.Forms.Button btnSaveKingdom;
        private System.Windows.Forms.ComboBox ddlPersonType;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnRemoveSelectedPerson;
        private System.Windows.Forms.Button btnNewKingdom;
        private System.Windows.Forms.TextBox txbPersonName;
        private System.Windows.Forms.Button btnEditPersonName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTiredTester;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox cbxEncryptData;
    }
}

