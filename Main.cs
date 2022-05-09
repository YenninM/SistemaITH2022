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
using WebSocketSharp;

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

        public string numcontrol;
        WebSocket ws = new WebSocket("ws://localhost:5000/");

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
            if (noControl_tbx.Text=="Número de Control")
            {
                noControl_tbx.Text = "";
                noControl_tbx.ForeColor = Color.DimGray;
            }
        }

        private void noControl_tbx_Leave(object sender, EventArgs e)
        {
            if (noControl_tbx.Text == "")
            {
                noControl_tbx.Text = "Número de Control";
                noControl_tbx.ForeColor = Color.DimGray;
            }
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {               
                ws.OnMessage += Ws_OnMessage;

                ws.Connect();
                MessageBox.Show(numcontrol);
                ws.Send("hola");
        }
        private static void Ws_OnMessage(object sender, MessageEventArgs e)
        {
            MessageBox.Show("Recive from the server: " + e.Data);
        }

        private void noControl_tbx_TextChanged(object sender, EventArgs e)
        {
            numcontrol = noControl_tbx.Text;
        }

        private void carr_tbx_Enter(object sender, EventArgs e)
        {
            if (carr_tbx.Text == "Carrera")
            {
                carr_tbx.Text = "";
                carr_tbx.ForeColor = Color.DimGray;
            }
        }

        private void carr_tbx_Leave(object sender, EventArgs e)
        {
            if (carr_tbx.Text == "")
            {
                carr_tbx.Text = "Carrera ";
                carr_tbx.ForeColor = Color.DimGray;
            }
        }

        private void salon_tbx_Enter(object sender, EventArgs e)
        {
            if (salon_tbx.Text == "Salón")
            {
                salon_tbx.Text = "";
                salon_tbx.ForeColor = Color.DimGray;
            }
        }

        private void salon_tbx_Leave(object sender, EventArgs e)
        {
            if (salon_tbx.Text == "")
            {
                salon_tbx.Text = "Salón";
                salon_tbx.ForeColor = Color.DimGray;
            }
        }

        private void semestre_tbx_Enter(object sender, EventArgs e)
        {
            if (semestre_tbx.Text == "Semestre")
            {
                semestre_tbx.Text = "";
                semestre_tbx.ForeColor = Color.DimGray;
            }
        }

        private void semestre_tbx_Leave(object sender, EventArgs e)
        {
            if (semestre_tbx.Text == "")
            {
                semestre_tbx.Text = "Semestre";
                semestre_tbx.ForeColor = Color.DimGray;
            }
        }
    }
}
