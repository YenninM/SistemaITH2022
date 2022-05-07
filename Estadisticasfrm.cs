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
    public partial class Estadisticasfrm : Form
    {
        public Estadisticasfrm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void Estadisticasfrm_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void Min_btn_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Cls_btn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ingr_btn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Main frmmain = new Main();
            frmmain.FormClosed += (s, args) => this.Close();
            frmmain.Show();
        }

        private void List_btn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            listaDeAlumnos frmlist = new listaDeAlumnos();
            frmlist.FormClosed += (s, args) => this.Close();
            frmlist.Show();
        }

        private void Register_btn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            RegistroAlumnosFrm frmregist = new RegistroAlumnosFrm();
            frmregist.FormClosed += (s, args) => this.Close();
            frmregist.Show();
        }
    }
}
