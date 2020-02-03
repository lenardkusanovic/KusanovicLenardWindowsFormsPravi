using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KusanovicLenardContextMenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lijevoNaDesnoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ctrlToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ctrlLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public FormContextMenuStrip()
        {
            InitializeComponent();
        }
        // klik na opciju LijevoDesno
        private void lijevoDesnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDesno.Text = textBoxLijevo.Text;
        }
        // klik na opciju DesnoLijevo
        private void desnoLijevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxLijevo.Text = textBoxDesno.Text;
        }

    }
}
