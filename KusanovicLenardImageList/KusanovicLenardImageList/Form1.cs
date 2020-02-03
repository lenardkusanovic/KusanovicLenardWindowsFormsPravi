using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KusanovicLenardImageList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int brojac = 1;
        public FormImageList()
        {
            InitializeComponent();
            // u startu ce biti vidljiva prva slika u listi
            pictureBox1.Image = imageList1.Images[0];
        }
        private void buttonPromijeni_Click(object sender, EventArgs e)
        {
            // svakim klikom na dugme mijenja se slika u PictureBox-u
            // nakon te promjene, brojac se uvecava za 1
            if (brojac % 2 == 0)
                pictureBox1.Image = imageList1.Images[0];
            else
                pictureBox1.Image = imageList1.Images[1];
            brojac++;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
