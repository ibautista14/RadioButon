using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRojoVerdeAzul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int ch = 0; ch <= 255; ch++)
            {
                cmbRojo.Items.Add(ch);
                cmbVerde.Items.Add(ch);
                cmbAzul.Items.Add(ch);
            }
            cmbRojo.SelectedIndex = 0;
            cmbVerde.SelectedIndex = 0;
            cmbAzul.SelectedIndex = 0;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int rojo, verde, azul;
            rojo = int.Parse(cmbRojo.Text);
            verde = int.Parse(cmbVerde.Text);
            azul = int.Parse(cmbAzul.Text);
            BackColor = Color.FromArgb(rojo, verde, azul);
        }
    }
}
