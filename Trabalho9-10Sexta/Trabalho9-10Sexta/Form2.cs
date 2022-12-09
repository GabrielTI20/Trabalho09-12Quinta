using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho9_10Sexta
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Texto1.Visible=false;
        }

        private void Botao1_Click(object sender, EventArgs e)
        {
            Texto1.Visible= true;
            Texto1.Text = "Olá mundo";
            Botao1.BackColor= Color.Red;
            Texto1.ForeColor = Color.Blue;
        }

        private void Texto1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
