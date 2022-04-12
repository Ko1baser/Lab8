using Microsoft.Win32;


namespace Lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            btnCreate.Enabled = false;
            btnDelete.Enabled = false;
            txtBox.Enabled = false; txtBox.Text = null;
            txtBoxName.Enabled = false;
            txtBoxValue.Enabled = false;


            List<string> registryList = new List<string>() { "HKEY_CLASSES_ROOT", "HKEY_CURRENT_USER", 
                "HKEY_LOCAL_MACHINE", "HKEY_USERS", "HKEY_CURRENT_CONFIG" };
            cmbBoxRegistryList.Items.AddRange(registryList.ToArray());

        }

        


        private void btnCreate_Click(object sender, EventArgs e)
        {
            RegistryKey currentuserkey;
            RegistryKey myKey;

            if (txtBox.Text != null)
            {
                switch (cmbBoxRegistryList.SelectedIndex)
                {
                    case 0:
                        currentuserkey = Registry.ClassesRoot;
                        myKey = currentuserkey.CreateSubKey(txtBox.Text);

                        break;
                    case 1:
                        currentuserkey = Registry.CurrentUser;
                        CreateKey(currentuserkey, txtBox.Text,
                            txtBoxName.Text, txtBoxValue.Text);
                        break;
                    case 2:
                        currentuserkey = Registry.LocalMachine;
                        myKey = currentuserkey.CreateSubKey(txtBox.Text);
                        break;
                    case 3:
                        currentuserkey = Registry.Users;
                        myKey = currentuserkey.CreateSubKey(txtBox.Text);
                        break;
                    case 4:
                        currentuserkey = Registry.CurrentConfig;
                        myKey = currentuserkey.CreateSubKey(txtBox.Text);
                        break;
                    default:
                        MessageBox.Show("Ничего нет");
                        break;
                }
                txtBox.Text = null;
                txtBoxName.Text = null;
                txtBoxValue.Text = null;
            }
            else if (txtBox.Text == null)
            {
                MessageBox.Show("Вы ничего не выбрали");
            }
                
        }


        public static void CreateKey(RegistryKey currentuserkey, 
            string textBOX,string Name, string Value)
        {
            RegistryKey myKey;
            myKey = currentuserkey.CreateSubKey(textBOX);
            myKey.SetValue(Name, Value);
            MessageBox.Show("Вы что-то создали");
        }



        private void cmbBoxRegistryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCreate.Enabled = true;
            btnDelete.Enabled = true;
            txtBox.Enabled = true;
            txtBoxName.Enabled = true;
            txtBoxValue.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}