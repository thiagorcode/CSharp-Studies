using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_04___ExemploMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formulário1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFilho1 frm1;
            frm1 = new FrmFilho1();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void formulário2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFilho2 frm2;
            frm2 = new frmFilho2();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void ladoALadoVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ladoALadoHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
