using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int resposta;
            Application.EnableVisualStyles();

            resposta = Convert.ToInt32(MessageBox.Show("Pretende Continuar?", "Mensagem", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question));
            if (resposta == 6)
            {
                MessageBox.Show("Carregou em sim", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                if (resposta == 7)
                MessageBox.Show("Carregou em Não", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    if(resposta == 2) 
                        MessageBox.Show("Carregou em Cancelar", "Mensagem", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            string message = "Prentende Continuar?";
            string caption = "Decisão";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Carregou em Sim", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = MousePosition.X.ToString();
            textBox2.Text = MousePosition.Y.ToString();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("x=" + MousePosition.X + "| y= " + MousePosition.Y);
            MessageBox.Show("Teste1", "Esse é um teste", MessageBoxButtons.YesNoCancel);
        }
    }
}
