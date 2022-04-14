using System.DirectoryServices.ActiveDirectory;
using Microsoft.Win32;


namespace Lab8
{
    public partial class Form1 : Form
    {
        private RegistryKey _currentKey, _myKey, _mainKey;

        public Form1()
        {
            InitializeComponent();
            EnableComponents();
            List<string> registryList = new() { "HKEY_CLASSES_ROOT", "HKEY_CURRENT_USER", 
                "HKEY_LOCAL_MACHINE", "HKEY_USERS", "HKEY_CURRENT_CONFIG" };
            CmbBoxRegistryList.Items.AddRange(registryList.ToArray());
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            
            if (TxtBox.Text != null)
            {
                CreateKey(_currentKey, TxtBox.Text, TxtBoxName.Text, TxtBoxValue.Text);
            }
            else if (TxtBox.Text == null)
            {
                MessageBox.Show("Вы ничего не выбрали");
            }
        }


        public static void CreateKey(RegistryKey _currentKey, 
            string textBOX,string Name, string Value)
        {
            RegistryKey _myKey;
            _myKey = _currentKey.CreateSubKey(textBOX);
            _myKey.SetValue(Name, Value);
            MessageBox.Show("Ключ создан", "Success");
        }



        private void CmbBoxRegistryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonsEnabled();
            switch (CmbBoxRegistryList.SelectedIndex)
            {
                case 0:
                    _currentKey = Registry.ClassesRoot;
                    break;
                case 1:
                    _currentKey = Registry.CurrentUser;
                    break;
                case 2:
                    _currentKey = Registry.LocalMachine;
                    break;
                case 3:
                    _currentKey = Registry.Users;
                    break;
                case 4:
                    _currentKey = Registry.CurrentConfig;
                    break;
            }
        }

        public void ButtonsEnabled()
        {
            TxtBox.Enabled = true;
            if (TxtBox.Text != "")
            {
                BtnCreate.Enabled = true;
                BtnDeleteKey.Enabled = true;
                BtnList.Enabled = true;
                TxtBoxName.Enabled = true;
            }
            else
            {
                BtnCreate.Enabled = false;
                BtnDeleteKey.Enabled = false;
                BtnList.Enabled = false;
                TxtBoxName.Enabled = false;
                TxtBoxName.Text = null;
                TxtBoxValue.Text = null;
            }

            if (TxtBoxName.Text != "")
            {
                BtnDeleteName.Enabled = true;
                TxtBoxValue.Enabled = true;
            }
            else
            {
                BtnDeleteName.Enabled = false;
                TxtBoxValue.Enabled = false;
                TxtBoxValue.Text = null;
            }

            if (TxtBoxValue.Text != "")
            {
                BtnDeleteValue.Enabled = true;
            }
            else
            {
                BtnDeleteValue.Enabled = false;

            }
        }

        public void EnableComponents()
        {
            BtnCreate.Enabled = false;
            BtnDeleteName.Enabled = false;
            TxtBox.Enabled = false;
            TxtBoxName.Enabled = false;
            TxtBoxValue.Enabled = false;
            BtnDeleteValue.Enabled = false;
            BtnDeleteKey.Enabled = false;
            BtnList.Enabled = false;
        }


        private void BtnDeleteKey_Click(object sender, EventArgs e)
        {
            ButtonsEnabled();
            if (TxtBox.Text != null)
            {
                try
                {
                    _currentKey.DeleteSubKey(TxtBox.Text);
                    MessageBox.Show("ты че-то удалил");
                    TxtBox.Text = null;
                    TxtBoxName.Text = null;
                    TxtBoxValue.Text = null;
                }
                catch
                {
                    MessageBox.Show("Ошибка удаления ключа", "Error");
                }
            }
        }

        private void BtnDeleteName_Click(object sender, EventArgs e)
        {
            if (TxtBoxName.Text != null)
            {
                try
                {
                    _myKey = _currentKey.OpenSubKey(TxtBox.Text, true);
                    _myKey.DeleteValue(TxtBoxName.Text);
                    _myKey.Close();
                    MessageBox.Show($"Вы успешно удалили значение ключа {TxtBoxValue}");
                    TxtBoxName.Text = null;
                }
                catch
                {
                    MessageBox.Show("Ошибка удаления значения ключа", "Error");
                }
            }
        }

        private void BtnDeleteValue_Click(object sender, EventArgs e)
        {
            if (TxtBoxValue.Text != null)
            {
                try
                {
                    _myKey = _currentKey.OpenSubKey(TxtBox.Text, true);
                    _myKey.SetValue(TxtBoxName.Text, "");
                    _myKey.Close();
                    MessageBox.Show($"Вы успешно удалили значение ключа по имени {TxtBoxName.Text}", "Success");
                    TxtBoxValue.Text = null;
                }
                catch
                {
                    MessageBox.Show($"Ошибка удаления значения ключа по имени{TxtBoxName.Text}", "Success");
                }
            }

        }

        

        private void BtnList_Click(object sender, EventArgs e)
        {
            KeysList.Items.Clear();
            ButtonsEnabled();
            _mainKey = _currentKey.OpenSubKey(CmbBoxRegistryList.SelectedText);
            string[] _mainKeys = _mainKey.GetSubKeyNames();
            int ch = 0;
            foreach (string key in _mainKeys)
            {
                if (key == TxtBox.Text)
                {
                    ch++;
                    _myKey = _currentKey.OpenSubKey(TxtBox.Text);
                    string[] values = _myKey.GetValueNames();
                    if (values != null)
                    {
                        foreach (string myValue in values)
                        {
                            KeysList.Items.Add(_currentKey + "\\" + myValue + "\\" + _myKey.GetValue(myValue));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Данный ключ не содержит значений");
                    }
                    _myKey.Close();
                    break;
                }
            }
            if (ch == 0)
            {
                MessageBox.Show("Ключа с таким именем не существует", "Error");
            }
            
        }

        private void TxtBox_TextChanged(object sender, EventArgs e)
        {
            ButtonsEnabled();
        }

        private void TxtBoxName_TextChanged(object sender, EventArgs e)
        {
            ButtonsEnabled();
        }

        private void TxtBoxValue_TextChanged(object sender, EventArgs e)
        {
            ButtonsEnabled();
        }
    }
}