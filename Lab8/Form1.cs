using Microsoft.Win32;


namespace Lab8
{
    public partial class Form1 : Form
    {

        RegistryKey currentuserkey;
        RegistryKey myKey;

        public Form1()
        {
            InitializeComponent();
            btnCreate.Enabled = false;
            btnDelete.Enabled = false;
            txtBox.Enabled = false; txtBox.Text = null;
            txtBoxName.Enabled = false;
            txtBoxName.Text = null;
            txtBoxValue.Enabled = false;
            btnDeleteValue.Enabled = false;
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
            MessageBox.Show("Вы что-то создали");
        }



        private void cmbBoxRegistryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCreate.Enabled = true;
            btnDelete.Enabled = true;
            txtBox.Enabled = true;
            txtBoxName.Enabled = true;
            txtBoxValue.Enabled = true;
            btnDeleteValue.Enabled = true;
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
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtBoxName.Text != null)
            {
                try
                {
                    myKey = currentuserkey.OpenSubKey(txtBox.Text, true);
                    myKey.DeleteValue(txtBoxName.Text);
                    myKey.Close();
                    MessageBox.Show("ты че-то удалил");
                    txtBoxName.Text = null;
                }
                catch
                {
                    MessageBox.Show("Ошибка удаления значения", "Error");
                }
            }
            else if (txtBoxName.Text == null)
            {
                try
                {
                    currentuserkey.DeleteSubKeyTree(txtBox.Text);
                    MessageBox.Show("Ключ успешно удален", "Success");
                    txtBox.Text = null;
                }
                catch
                {
                    MessageBox.Show("Ключа с таким именем не существует");
                }
            }
        }

        private void btnDeleteValue_Click(object sender, EventArgs e)
        {
            if (txtBoxValue.Text != null)
            {
                myKey = currentuserkey.OpenSubKey(txtBox.Text, true);
                myKey.SetValue(txtBoxName.Text, "");
                myKey.Close();
                MessageBox.Show("Вы удалили значение ключа", "Success");
                txtBoxValue.Text = null;
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            keysList.Items.Clear();
            try
            {
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
            }
            catch
            {
                MessageBox.Show("NIGGERS");
            }
        }
    }
}