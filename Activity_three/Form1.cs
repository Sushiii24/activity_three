using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void submitButton_Click(object sender, EventArgs e)
        {
            string str = "";

            //CheckBox1 = Japan
            if (checkBox1.Checked == true)
            {
                str = str + checkBox1.Text;
                str += "\n";
            }
            
            //CheckBox2 = Thailand
            if (checkBox2.Checked == true)
            {
                str = str + checkBox2.Text;
                str += "\n";
            }

            //CheckBox3 = Philippines
            if (checkBox3.Checked == true)
            {
                str = str + checkBox3.Text;
                str += "\n";
            }

            //CheckBox4 = Australia
            if (checkBox4.Checked == true)
            {
                str = str + checkBox4.Text;
                str += "\n";
            }

            if (othersCheckedBox.Checked == true)
            {
                str = str + othersTextBox.Text;
                str += "\n";
            }
            if (str != null)
            {
               MessageBox.Show("You've selected: \n" + str + "\n Thank you!", "Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void othersCheckedBox_CheckedChanged(object sender, EventArgs e)
        {
            if (othersCheckedBox.Checked == true)
            {
                label3.Visible = true;
                othersTextBox.Visible = true;
            }
            else
            {
                label3.Visible = false;
                othersTextBox.Visible = false;
            }
        }

        private void othersTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
