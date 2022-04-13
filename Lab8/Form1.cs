using System.DirectoryServices.ActiveDirectory;
using Microsoft.Win32;


namespace Lab8
{
    public partial class Form1 : Form
    {

        RegistryKey currentuserkey;
        RegistryKey myKey;
        RegistryKey mainKey;

        public Form1()
        {
            InitializeComponent();
            EnableComponents();
            List<string> registryList = new List<string>() { "HKEY_CLASSES_ROOT", "HKEY_CURRENT_USER", 
                "HKEY_LOCAL_MACHINE", "HKEY_USERS", "HKEY_CURRENT_CONFIG" };
            cmbBoxRegistryList.Items.AddRange(registryList.ToArray());
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            if (txtBox.Text != null)
            {
                CreateKey(currentuserkey, txtBox.Text, txtBoxName.Text, txtBoxValue.Text);
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
            MessageBox.Show("Ключ создан", "Success");
        }



        private void cmbBoxRegistryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonsEnabled();
            switch (cmbBoxRegistryList.SelectedIndex)
            {
                case 0:
                    currentuserkey = Registry.ClassesRoot;
                    break;
                case 1:
                    currentuserkey = Registry.CurrentUser;
                    break;
                case 2:
                    currentuserkey = Registry.LocalMachine;
                    break;
                case 3:
                    currentuserkey = Registry.Users;
                    break;
                case 4:
                    currentuserkey = Registry.CurrentConfig;
                    break;
            }
        }

        public void ButtonsEnabled()
        {
            txtBox.Enabled = true;
            if (txtBox.Text != "")
            {
                btnCreate.Enabled = true;
                btnDeleteKey.Enabled = true;
                btnList.Enabled = true;
                txtBoxName.Enabled = true;
            }
            else
            {
                btnCreate.Enabled = false;
                btnDeleteKey.Enabled = false;
                btnList.Enabled = false;
                txtBoxName.Enabled = false;
                txtBoxName.Text = null;
                txtBoxValue.Text = null;
            }

            if (txtBoxName.Text != "")
            {
                btnDeleteName.Enabled = true;
                txtBoxValue.Enabled = true;
            }
            else
            {
                btnDeleteName.Enabled = false;
                txtBoxValue.Enabled = false;
                txtBoxValue.Text = null;
            }

            if (txtBoxValue.Text != "")
            {
                btnDeleteValue.Enabled = true;
            }
            else
            {
                btnDeleteValue.Enabled = false;

            }
        }

        public void EnableComponents()
        {
            btnCreate.Enabled = false;
            btnDeleteName.Enabled = false;
            txtBox.Enabled = false;
            txtBoxName.Enabled = false;
            txtBoxValue.Enabled = false;
            btnDeleteValue.Enabled = false;
            btnDeleteKey.Enabled = false;
            btnList.Enabled = false;
        }


        private void btnDeleteKey_Click(object sender, EventArgs e)
        {
            ButtonsEnabled();
            if (txtBox.Text != null)
            {
                try
                {
                    currentuserkey.DeleteSubKey(txtBox.Text);
                    MessageBox.Show("ты че-то удалил");
                    txtBox.Text = null;
                    txtBoxName.Text = null;
                    txtBoxValue.Text = null;
                }
                catch
                {
                    MessageBox.Show("Ошибка удаления ключа", "Error");
                }
            }
        }

        private void btnDeleteName_Click(object sender, EventArgs e)
        {
            if (txtBoxName.Text != null)
            {
                try
                {
                    myKey = currentuserkey.OpenSubKey(txtBox.Text, true);
                    myKey.DeleteValue(txtBoxName.Text);
                    myKey.Close();
                    MessageBox.Show($"Вы успешно удалили значение ключа {txtBoxValue}");
                    txtBoxName.Text = null;
                }
                catch
                {
                    MessageBox.Show("Ошибка удаления значения ключа", "Error");
                }
            }
        }

        private void btnDeleteValue_Click(object sender, EventArgs e)
        {
            if (txtBoxValue.Text != null)
            {
                try
                {
                    myKey = currentuserkey.OpenSubKey(txtBox.Text, true);
                    myKey.SetValue(txtBoxName.Text, "");
                    myKey.Close();
                    MessageBox.Show($"Вы успешно удалили значение ключа по имени {txtBoxName.Text}", "Success");
                    txtBoxValue.Text = null;
                }
                catch
                {
                    MessageBox.Show($"Ошибка удаления значения ключа по имени{txtBoxName.Text}", "Success");
                }
            }

        }

        

        private void btnList_Click(object sender, EventArgs e)
        {
            keysList.Items.Clear();
            ButtonsEnabled();
            mainKey = currentuserkey.OpenSubKey(cmbBoxRegistryList.SelectedText);
            string[] mainKeys = mainKey.GetSubKeyNames();
            int ch = 0;
            foreach (string key in mainKeys)
            {
                if (key == txtBox.Text)
                {
                    ch++;
                    myKey = currentuserkey.OpenSubKey(txtBox.Text);
                    string[] values = myKey.GetValueNames();
                    if (values != null)
                    {
                        foreach (string myValue in values)
                        {
                            keysList.Items.Add(currentuserkey + "\\" + myValue + "\\" + myKey.GetValue(myValue));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Данный ключ не содержит значений");
                    }
                    myKey.Close();
                    break;
                }
            }
            if (ch == 0)
            {
                MessageBox.Show("Ключа с таким именем не существует", "Error");
            }
            
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            ButtonsEnabled();
        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {
            ButtonsEnabled();
        }

        private void txtBoxValue_TextChanged(object sender, EventArgs e)
        {
            ButtonsEnabled();
        }
    }
}