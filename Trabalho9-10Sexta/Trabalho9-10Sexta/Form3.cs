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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Mensagem1.Visible = false;

        }

        private void Botao1_Click(object sender, EventArgs e)
        {
            Mensagem1.Text = "Hoje é dia 9";
            Mensagem1.Visible= true;
            Botao1.ForeColor = Color.Red;
            Botao2.ForeColor = Color.White;
            Botao3.ForeColor = Color.White;
        }

        private void Botao2_Click(object sender, EventArgs e)
        {
            Mensagem1.Text = "O mês atual é dezembro";
            Mensagem1.Visible= true;
            Botao1.ForeColor = Color.White;
            Botao2.ForeColor = Color.Red;
            Botao3.ForeColor= Color.White;
        }

        private void Botao3_Click(object sender, EventArgs e)
        {
            Mensagem1.Text = "Estamos no ano de 2022";
            Mensagem1.Visible= true;
            Botao1.ForeColor = Color.White;
            Botao2.ForeColor = Color.White;
            Botao3.ForeColor= Color.Red;
        }

        private void Mensagem1_Click(object sender, EventArgs e)
        {

        }
    }
}
