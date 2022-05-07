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
    public partial class SistemaITH : Form
    {
        public SistemaITH()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void correo_tbx_Enter(object sender, EventArgs e)
        {
            if (correo_tbx.Text =="Correo Administrador")
            {
                correo_tbx.Text ="";
                correo_tbx.ForeColor = Color.Black;
            }
        }

        private void correo_tbx_Leave(object sender, EventArgs e)
        {
            if (correo_tbx.Text == "")
            {
                correo_tbx.Text = "Correo Administrador";
                correo_tbx.ForeColor = Color.DimGray;
            }
        }

        private void pswd_tbx_Enter(object sender, EventArgs e)
        {
            if (pswd_tbx.Text == "Contraseña")
            {
                pswd_tbx.Text = "";
                pswd_tbx.ForeColor = Color.Black;
                pswd_tbx.UseSystemPasswordChar = true;
            }
        }

        private void pswd_tbx_Leave(object sender, EventArgs e)
        {
            if (pswd_tbx.Text == "")
            {
                pswd_tbx.Text = "Contraseña";
                pswd_tbx.ForeColor = Color.DimGray;
                pswd_tbx.UseSystemPasswordChar = false;
            }
        }

        private void cls_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void min_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void SistemaITH_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iniciarsesion_btn_Enter(object sender, EventArgs e)
        {
            this.Hide();
            Main frm = new Main();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
        }
    }
}
