using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class defaultForm : Form
    {
        TelephoneDirectory telephoneDir = new TelephoneDirectory();
        public defaultForm()
        {
            InitializeComponent();
            typeComboBox.DataSource = Enum.GetValues(typeof(Type));
            TelephoneDirectory telephoneDir = new TelephoneDirectory();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string address = addressTextBox.Text;
            int age = int.Parse(ageTextBox.Text);
            int mobile =int.Parse(mobileTextBox.Text);
            Type type;
            Enum.TryParse<Type>(typeComboBox.SelectedValue.ToString(),out type);
            Person newPerson = new Person(name,address,age,mobile,type);
            telephoneDir.addToTelephoneDirectory(newPerson);
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            StringBuilder sBuilder = new StringBuilder();
            foreach (Person p in telephoneDir.PersonList)
            {
                sBuilder.Append(p.ToString());
            }
            MessageBox.Show(sBuilder.ToString());
        }
    }
}
