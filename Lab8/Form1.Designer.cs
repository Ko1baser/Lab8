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
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxValue = new System.Windows.Forms.TextBox();
            this.cmbBoxRegistryList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(72, 133);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(209, 23);
            this.txtBox.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(378, 93);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(378, 133);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(72, 190);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(209, 23);
            this.txtBoxName.TabIndex = 3;
            // 
            // txtBoxValue
            // 
            this.txtBoxValue.Location = new System.Drawing.Point(72, 251);
            this.txtBoxValue.Name = "txtBoxValue";
            this.txtBoxValue.Size = new System.Drawing.Size(209, 23);
            this.txtBoxValue.TabIndex = 4;
            // 
            // cmbBoxRegistryList
            // 
            this.cmbBoxRegistryList.FormattingEnabled = true;
            this.cmbBoxRegistryList.Location = new System.Drawing.Point(72, 74);
            this.cmbBoxRegistryList.Name = "cmbBoxRegistryList";
            this.cmbBoxRegistryList.Size = new System.Drawing.Size(209, 23);
            this.cmbBoxRegistryList.TabIndex = 5;
            this.cmbBoxRegistryList.SelectedIndexChanged += new System.EventHandler(this.cmbBoxRegistryList_SelectedIndexChanged);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 433);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxRegistryList);
            this.Controls.Add(this.txtBoxValue);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBox;
        private Button btnCreate;
        private Button btnDelete;
        private TextBox txtBoxName;
        private TextBox txtBoxValue;
        private ComboBox cmbBoxRegistryList;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}