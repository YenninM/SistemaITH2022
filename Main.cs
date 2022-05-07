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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Main_MouseDown(object sender, MouseEventArgs e)
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

        private void list_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            listaDeAlumnos frmlist = new listaDeAlumnos();
            frmlist.FormClosed += (s, args) => this.Close();
            frmlist.Show();
        }

        private void statics_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Estadisticasfrm frmstatics = new Estadisticasfrm();
            frmstatics.FormClosed += (s, args) => this.Close();
            frmstatics.Show();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroAlumnosFrm frmregist = new RegistroAlumnosFrm();
            frmregist.FormClosed += (s, args) => this.Close();
            frmregist.Show();
        }

        private void nombreA_tbx_Enter(object sender, EventArgs e)
        {
            if (nombreA_tbx.Text=="Nombre Alumno")
            {
                nombreA_tbx.Text = "";
                nombreA_tbx.ForeColor = Color.DimGray;
            }
        }

        private void nombreA_tbx_Leave(object sender, EventArgs e)
        {
            if (nombreA_tbx.Text == "")
            {
                nombreA_tbx.Text = "Nombre Alumno ";
                nombreA_tbx.ForeColor = Color.DimGray;
            }
        }

        private void noControl_tbx_Enter(object sender, EventArgs e)
        {
            if (nombreA_tbx.Text=="Número de Control")
            {
                nombreA_tbx.Text = "";
                nombreA_tbx.ForeColor = Color.DimGray;
            }
        }

        private void noControl_tbx_Leave(object sender, EventArgs e)
        {
            if (noControl_tbx.Text == "")
            {
                noControl_tbx.Text = "Nombre Alumno ";
                noControl_tbx.ForeColor = Color.DimGray;
            }
        }
    }
}
