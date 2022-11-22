using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo2doParcialXML
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void gestionarPolizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 formu = new Form1();
            formu.MdiParent = this;
            formu.Show();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInformes formu = new FormInformes();
            formu.MdiParent = this;
            formu.Show();
        }
    }
}
