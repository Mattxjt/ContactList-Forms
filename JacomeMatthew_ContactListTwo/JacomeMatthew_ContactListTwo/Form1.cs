using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JacomeMatthew_ContactListTwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // New object 
        Contact newContact
        {
            get
            {
                // Setting the new contact objects data to textbox info
                Contact ContactOne = new Contact();
                ContactOne.firstName = firstNameTextBox.Text;
                ContactOne.lastName = lastNameTextBox.Text;
                ContactOne.phoneNumber = phoneNumberTextBox.Text;
                ContactOne.email = emailTextBox.Text;
                return ContactOne;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exits application
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Makes a new object and setts its properties...
            // ...to the info entered by the user.
            ListViewItem lvItem = new ListViewItem();
            lvItem.Text = newContact.ToString();
            lvItem.ImageIndex = 0;
            // Adds object to list view
            contactListView.Items.Add(lvItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // If there is one item or more it will delete the selected item
            // if there is not a selected Item than a message box will show.
            if (contactListView.SelectedItems.Count > 0)
            {
                contactListView.Items.Remove(contactListView.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Please select one item to delete.");
            }
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Makes icon size small
            contactListView.StateImageList = imageList1;
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Makes icon size large
            contactListView.StateImageList = imageList2;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Code form VF homework
            // Creates a new object of type SaveFileDialog.
            SaveFileDialog saveFileDialogOne = new SaveFileDialog();
            // Sets a default name
            saveFileDialogOne.FileName = "test.txt";
            // It gives the user one option to save a file of type .txt.
            saveFileDialogOne.Filter = ".txt | *.txt" + "|All Files|*.*";


            if (saveFileDialogOne.ShowDialog() == DialogResult.OK)
            {
                // Writing to a new a text file.
                StreamWriter writerOne = new StreamWriter(saveFileDialogOne.OpenFile());

                writerOne.Write(newContact.ToString());
                // Close and dispose streamwriter
                writerOne.Dispose();
                writerOne.Close();
            }
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        { 
            string temp = firstNameTextBox.Text;
            if (temp.Trim() == "") return;
            for (int i = 0; i < temp.Length; i++)
            {
                if (!char.IsLetter(temp[i]))
                {
                    MessageBox.Show("Please enter a valid name. \n Numbers are not valid");
                    firstNameTextBox.Text = "";
                    return;
                }
            }
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
        
            string temp = lastNameTextBox.Text;
            if (temp.Trim() == "") return;
            for (int i = 0; i < temp.Length; i++)
            {
                if (!char.IsLetter(temp[i]))
                {
                    MessageBox.Show("Please enter a valid name. \n Numbers are not valid");
                    lastNameTextBox.Text = "";
                    return;
                }
            }
        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            string temp = phoneNumberTextBox.Text;
            if (temp.Trim() == "") return;
            for (int i = 0; i < temp.Length; i++)
            {
                if (!char.IsNumber(temp[i]))
                {
                    MessageBox.Show("Please enter a valid phone. \n Letters are not valid");
                    phoneNumberTextBox.Text = "";
                    return;
                }
            }
            // Acknowledgement for code: https://social.msdn.microsoft.com/Forums/en-US/47355657-6e48-4952-8fae-da84960f5fe0/checking-if-textbox-input-is-a-number-or-not?forum=csharplanguage
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Code form VF homework
            // Creates a new object of type SaveFileDialog.
            SaveFileDialog saveFileDialogOne = new SaveFileDialog();
            // Sets a default name
            saveFileDialogOne.FileName = "test.txt";
            // It gives the user one option to save a file of type .txt.
            saveFileDialogOne.Filter = ".txt | *.txt" + "|All Files|*.*";


            if (saveFileDialogOne.ShowDialog() == DialogResult.OK)
            {
                // Writing to a new a text file.
                StreamWriter writerOne = new StreamWriter(saveFileDialogOne.OpenFile());

                writerOne.Write(newContact.ToString());
                // Close and dispose streamwriter
                writerOne.Dispose();
                writerOne.Close();
            }
        }
    }
}

