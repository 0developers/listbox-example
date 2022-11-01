using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace list_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Focus();
        }
        public void add(String text)
        {
            // we want to make a function for adding items , you can still add items without function
            listBox1.Items.Add(text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // first we want to make sure that the textbox is not empty
            if (!(textBox1.Text == ""))
            {
                add(textBox1.Text);
                // after adding the data , clear the textbox and set focus
                textBox1.Text = ("");
                textBox1.Focus();

            }
            else
            {
                // error message
                MessageBox.Show("you cant add empty text","error",MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // we want to make sure that the user selected item
            if (!(listBox1.SelectedItem == null)) { 
                // show a message box before removing the item
            DialogResult dr = 
            MessageBox.Show("Do you want to remove this item ?", "remove", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            switch (dr)
            {
                case DialogResult.Yes:
                    // if the user selected yes , remove the item
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    break;
                case DialogResult.No:
                    // if user selected no , dont do anything
                    break;
            }
            }
            

        }

       
        }
    }

