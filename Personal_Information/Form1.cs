using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Information
{
    public partial class Form1 : Form
    {
        string firstName;
        string lastName;
        string fathersName;
        string mothersName;
        string address;


        public Form1()
        {
            InitializeComponent();
        }

        
        private void saveButton_Click(object sender, EventArgs e)
        {
            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text;
            fathersName = fathersNameTextBox.Text;
            mothersName = mothersNameTextBox.Text;
            address = addressTextBox.Text;
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            fathersNameTextBox.Clear();
            mothersNameTextBox.Clear();
            addressTextBox.Clear();


        }

        private void showAllInformationButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
            fathersNameTextBox.Text = fathersName;
            mothersNameTextBox.Text = mothersName;
            addressTextBox.Text = address;

        }

        private void nameButtonBox_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
            fathersNameTextBox.Clear();
            mothersNameTextBox.Clear();
            addressTextBox.Clear();
        }

        private void parentsbuttonBox_Click(object sender, EventArgs e)
        {
            fathersNameTextBox.Text = fathersName;
            mothersNameTextBox.Text = mothersName;
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            addressTextBox.Clear();
        }

        private void addressButtonBox_Click(object sender, EventArgs e)
        {
            addressTextBox.Text = address;
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            fathersNameTextBox.Clear();
            mothersNameTextBox.Clear();

        }

    }
}
