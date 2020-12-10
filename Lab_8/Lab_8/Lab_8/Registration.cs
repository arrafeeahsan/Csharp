using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitClicked(object sender, EventArgs e)
        {
            
            string FirstName = textBoxFirstName.Text;
            string LastName = textBoxLastName.Text;
            string DobMonth = comboBoxMonth.SelectedItem.ToString();
            string DobDate = comboBoxDay.SelectedItem.ToString();
            string DobYear = comboBoxYear.SelectedItem.ToString();
            string Gender = comboBoxGn.SelectedItem.ToString();

            string Email = textBoxEmail.Text;
            /*string ReEmail = textBoxReEmail.Text;
            string Pass = textBoxPass.Text;
            string RePass = textBoxRePass.Text;
            string SecuQues = comboBoxSecQues.SelectedItem.ToString();
            string SecuAns = textBoxSecAns.Text;

            string Address = textBoxAddress.Text;
            string City = textBoxCity.Text;
            string State = comboBoxState.SelectedItem.ToString();
            string Zip = textBoxZip.Text;
            string ZipOpt = textBoxZipOpt.Text;
            string Phone = textBoxPhone.Text;
            string PhoneType = comboBoxPhone.SelectedItem.ToString();*/

            //string FirstName = textBoxFirstName.Text;
            //string LastName = textBoxLastName.Text;


            string output = String.Format("First Name: {0}" +
                "\nLast Name: {1}" +
                "\nMonth of Birth: {2}" +
                "\nDate of Birth: {3}" +
                "\nYear of Birth: {4}" +
                "\nGender: {5}" +
                "\nEmail: {6}", FirstName, LastName, DobMonth, DobDate, DobYear, Gender, Email);
            //MessageBox.Show("Clicked");
            rtbOutput.Text = output;









        }
    }
}
