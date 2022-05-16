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
using System.Net;
using System.Web;
using System.Web.UI;
using System.IO;
using System.Text.Json;

namespace SistemaITH
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            request.Method = "GET";
            requestPost.Method = "POST";
            requestPost.ContentType = "application/json";
            response = (HttpWebResponse)request.GetResponse();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public string numcontrol;
        readonly WebSocket ws = new WebSocket("ws://localhost:3000");
        WebRequest request = WebRequest.Create("http://localhost:3000");
        WebRequest requestPost = WebRequest.Create("http://localhost:3000");
        HttpWebResponse response = null;
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
            try
            {

            using (var streamWriter = new StreamWriter(requestPost.GetRequestStream()))
            {
                streamWriter.Write("{\"data\":"+"\""+numcontrol +"\""+"}");
                streamWriter.Flush();
                streamWriter.Close();

                var httpResponse = (HttpWebResponse)requestPost.GetResponse();
                using (var stream = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = stream.ReadToEnd();

                    JsonDocument doc = JsonDocument.Parse(result);
                    JsonElement root = doc.RootElement;

                    nombreA_tbx.Text = Convert.ToString(root.GetProperty("apellido_paterno")) +" "+ Convert.ToString(root.GetProperty("apellido_materno"))+" "+Convert.ToString(root.GetProperty("nombre_alumno"));
                    carr_tbx.Text = Convert.ToString(root.GetProperty("carrera"));
                    noControl_tbx.Text = Convert.ToString(root.GetProperty("no_de_control"));
                    semestre_tbx.Text = Convert.ToString(root.GetProperty("semestre"));
                }
            }
            }
            catch (Exception err)
            {
                MessageBox.Show("Se ha buscado más de un registro." +err);
            }
            

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
