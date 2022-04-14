namespace Lab8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TxtBox = new System.Windows.Forms.TextBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnDeleteName = new System.Windows.Forms.Button();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.TxtBoxValue = new System.Windows.Forms.TextBox();
            this.CmbBoxRegistryList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnDeleteValue = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.KeysList = new System.Windows.Forms.ListBox();
            this.BtnList = new System.Windows.Forms.Button();
            this.BtnDeleteKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBox
            // 
            this.TxtBox.Location = new System.Drawing.Point(72, 133);
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.Size = new System.Drawing.Size(209, 23);
            this.TxtBox.TabIndex = 0;
            this.TxtBox.TextChanged += new System.EventHandler(this.TxtBox_TextChanged);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(287, 133);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(85, 23);
            this.BtnCreate.TabIndex = 1;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnDeleteName
            // 
            this.BtnDeleteName.Location = new System.Drawing.Point(287, 190);
            this.BtnDeleteName.Name = "BtnDeleteName";
            this.BtnDeleteName.Size = new System.Drawing.Size(85, 23);
            this.BtnDeleteName.TabIndex = 2;
            this.BtnDeleteName.Text = "Delete name";
            this.BtnDeleteName.UseVisualStyleBackColor = true;
            this.BtnDeleteName.Click += new System.EventHandler(this.BtnDeleteName_Click);
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Location = new System.Drawing.Point(72, 190);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(209, 23);
            this.TxtBoxName.TabIndex = 3;
            this.TxtBoxName.TextChanged += new System.EventHandler(this.TxtBoxName_TextChanged);
            // 
            // TxtBoxValue
            // 
            this.TxtBoxValue.Location = new System.Drawing.Point(72, 251);
            this.TxtBoxValue.Name = "TxtBoxValue";
            this.TxtBoxValue.Size = new System.Drawing.Size(209, 23);
            this.TxtBoxValue.TabIndex = 4;
            this.TxtBoxValue.TextChanged += new System.EventHandler(this.TxtBoxValue_TextChanged);
            // 
            // CmbBoxRegistryList
            // 
            this.CmbBoxRegistryList.FormattingEnabled = true;
            this.CmbBoxRegistryList.Location = new System.Drawing.Point(72, 74);
            this.CmbBoxRegistryList.Name = "CmbBoxRegistryList";
            this.CmbBoxRegistryList.Size = new System.Drawing.Size(209, 23);
            this.CmbBoxRegistryList.TabIndex = 5;
            this.CmbBoxRegistryList.SelectedIndexChanged += new System.EventHandler(this.CmbBoxRegistryList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите ключ реестра";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введите имя нового раздела";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите имя нового параметра";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Введите значение нового параметра";
            // 
            // BtnDeleteValue
            // 
            this.BtnDeleteValue.Location = new System.Drawing.Point(287, 251);
            this.BtnDeleteValue.Name = "BtnDeleteValue";
            this.BtnDeleteValue.Size = new System.Drawing.Size(85, 23);
            this.BtnDeleteValue.TabIndex = 10;
            this.BtnDeleteValue.Text = "Delete value";
            this.BtnDeleteValue.UseVisualStyleBackColor = true;
            this.BtnDeleteValue.Click += new System.EventHandler(this.BtnDeleteValue_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(725, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // KeysList
            // 
            this.KeysList.FormattingEnabled = true;
            this.KeysList.ItemHeight = 15;
            this.KeysList.Location = new System.Drawing.Point(72, 280);
            this.KeysList.Name = "KeysList";
            this.KeysList.Size = new System.Drawing.Size(391, 94);
            this.KeysList.TabIndex = 12;
            // 
            // BtnList
            // 
            this.BtnList.Location = new System.Drawing.Point(508, 311);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(85, 23);
            this.BtnList.TabIndex = 13;
            this.BtnList.Text = "Get keys";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // BtnDeleteKey
            // 
            this.BtnDeleteKey.Location = new System.Drawing.Point(378, 133);
            this.BtnDeleteKey.Name = "BtnDeleteKey";
            this.BtnDeleteKey.Size = new System.Drawing.Size(85, 23);
            this.BtnDeleteKey.TabIndex = 14;
            this.BtnDeleteKey.Text = "Delete key";
            this.BtnDeleteKey.UseVisualStyleBackColor = true;
            this.BtnDeleteKey.Click += new System.EventHandler(this.BtnDeleteKey_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 428);
            this.Controls.Add(this.BtnDeleteKey);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.KeysList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnDeleteValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbBoxRegistryList);
            this.Controls.Add(this.TxtBoxValue);
            this.Controls.Add(this.TxtBoxName);
            this.Controls.Add(this.BtnDeleteName);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.TxtBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtBox;
        private Button BtnCreate;
        private Button BtnDeleteName;
        private TextBox TxtBoxName;
        private TextBox TxtBoxValue;
        private ComboBox CmbBoxRegistryList;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnDeleteValue;
        private Button button2;
        private ListBox KeysList;
        private Button BtnList;
        private Button BtnDeleteKey;
    }
}