using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsCalculatriceStandadScientifique
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void versionStandardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 com = new Form2();
            com.MdiParent = this;
            com.Show();
        }

        private void versionScientifiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 com = new Form3();
            com.MdiParent = this;
            com.Show();
        }

        private void calculatricesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void bureauxChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void versionLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 com = new Form4();
            com.MdiParent = this;
            com.Show();
        }
    }
}
