using Microsoft.Win32;

namespace Lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();




        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtBox.Text != null)
            {
                RegistryKey currentuserkey = Registry.CurrentUser;
                RegistryKey myKey = currentuserkey.CreateSubKey(txtBox.Text);
                myKey.SetValue(txtBoxName.Text, txtBoxValue.Text);
                txtBox.Text = null;
                txtBoxName.Text = null;
                txtBoxValue.Text = null;

            }            
                
        }
    }
}