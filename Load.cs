using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaITH
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        int N = 0;
        
        private void Load_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            N++;
            cargando_lbl.Text = "Cargando " + N.ToString() + "%";
            progressBar1.Value = N;
            if (N == 100)
            {
                timer1.Stop();
                this.Hide();
                SistemaITH frm = new SistemaITH();
                frm.ShowDialog();
                this.Close();
            }
        }
    }
}
