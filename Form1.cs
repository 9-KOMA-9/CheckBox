using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ChekBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBoxSakrij_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxSakrij.Checked)
            {
                textBox1.Hide();
            }
            else 
            { 
                textBox1.Show(); 
            }

        }

        private void sendbut_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            if (checkBoxDorucak.Checked)
            {
                textBox1.Text = "Doručak";
            }

            if (checkBoxRucak.Checked)
            {
                if (checkBoxDorucak.Checked)
                {
                    textBox1.AppendText(Environment.NewLine); // Dodajte novi red između riječi
                }
                textBox1.Text += "Ručak"; // Dodajte tekst u TextBox koristeći += operator
            }
            if (checkBoxVecera.Checked)
            {
                if (checkBoxRucak.Checked)
                {
                    textBox1.AppendText(Environment.NewLine);
                }
                if (checkBoxDorucak.Checked)
                {
                    textBox1.AppendText(Environment.NewLine);
                }
                textBox1.Text += "Vecera";
            }




        }
    }
}
