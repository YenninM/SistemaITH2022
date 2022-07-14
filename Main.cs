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

        private void statics_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Estadisticasfrm frmstatics = new Estadisticasfrm();
            frmstatics.FormClosed += (s, args) => this.Close();
            frmstatics.Show();
        }




        /*
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
            

        }*/

    }
}
