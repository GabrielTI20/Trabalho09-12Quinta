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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Texto2.Visible= false;
            Botao2.Visible= false;

        }

        private void Botao1_Click(object sender, EventArgs e)
        {
            Texto2.Text = "O nome "+ Digite.Text + " é comum";
            Texto2.Visible = true;
            Botao1.Visible = false;
            Botao2.Visible = true;
        }

        private void Botao2_Click(object sender, EventArgs e)
        {
            Texto2.Text = "O nome " + Digite.Text + " é diferente";
            Texto2.Visible = true;
            Botao2.Visible = false;
            Botao1.Visible = true;
        }
    }
}
