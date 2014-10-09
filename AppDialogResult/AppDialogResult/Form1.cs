using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDialogResult
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro", "Confirmación", 
                MessageBoxButtons.YesNo); 
            if(dialogResult == DialogResult.Yes)
             {
                 txtNombre.Text = " ";
                 txtEdad.Text = " ";
                 txtProfesion.Text = " ";
             } 
             else if (dialogResult == DialogResult.No) 
             {

             }

        }
    }
}
