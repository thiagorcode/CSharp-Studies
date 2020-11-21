using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_03___Empregado
{
    public partial class Form1 : Form
    {
        private Empregao E;

        public Form1()
        {
            InitializeComponent();
            E = new Empregao();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Maximum = 130;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            E.Nome = txtNome.Text;
            lblNomeAtualizado.Text = E.Nome;
            lblIdadeAtualizado.Text = (E.Idade).ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            LblExibicao.Text = (trackBar1.Value).ToString();
            E.Idade = trackBar1.Value;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            E.Nome = lblNomeAtualizado.Text;
            lblNomeAtualizado.Text = E.Nome;
        }
    }
}
