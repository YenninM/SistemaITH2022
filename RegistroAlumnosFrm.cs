using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SistemaITH
{
    public partial class RegistroAlumnosFrm : Form
    {
        public RegistroAlumnosFrm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void cls_btn_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void min_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cls_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ingr_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main frmMain = new Main();
            frmMain.FormClosed += (s, args) => this.Close();
            frmMain.Show();

        }

        private void list_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroAlumnosFrm frmregist = new RegistroAlumnosFrm();
            frmregist.FormClosed += (s, args) => this.Close();
            frmregist.Show();
        }

        private void statics_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Estadisticasfrm frmstatics = new Estadisticasfrm();
            frmstatics.FormClosed += (s, args) => this.Close();
            frmstatics.Show();
        }

        
    }
}
