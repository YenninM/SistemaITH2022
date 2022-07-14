
namespace SistemaITH
{
    partial class Estadisticasfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estadisticasfrm));
            this.statics_btn = new System.Windows.Forms.Button();
            this.list_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Min_btn = new System.Windows.Forms.PictureBox();
            this.Cls_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cls_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // statics_btn
            // 
            this.statics_btn.FlatAppearance.BorderSize = 0;
            this.statics_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statics_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statics_btn.ForeColor = System.Drawing.Color.DarkOrange;
            this.statics_btn.Location = new System.Drawing.Point(538, 64);
            this.statics_btn.Name = "statics_btn";
            this.statics_btn.Size = new System.Drawing.Size(112, 24);
            this.statics_btn.TabIndex = 47;
            this.statics_btn.Text = "Estadísticas";
            this.statics_btn.UseVisualStyleBackColor = true;
            this.statics_btn.Click += new System.EventHandler(this.statics_btn_Click);
            // 
            // list_btn
            // 
            this.list_btn.FlatAppearance.BorderSize = 0;
            this.list_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.list_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_btn.ForeColor = System.Drawing.Color.Black;
            this.list_btn.Location = new System.Drawing.Point(370, 64);
            this.list_btn.Name = "list_btn";
            this.list_btn.Size = new System.Drawing.Size(112, 24);
            this.list_btn.TabIndex = 46;
            this.list_btn.Text = "Lista de Alumnos";
            this.list_btn.UseVisualStyleBackColor = true;
            this.list_btn.Click += new System.EventHandler(this.list_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(335, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(357, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(821, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 143);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Min_btn
            // 
            this.Min_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Min_btn.BackgroundImage")));
            this.Min_btn.Image = ((System.Drawing.Image)(resources.GetObject("Min_btn.Image")));
            this.Min_btn.Location = new System.Drawing.Point(971, 12);
            this.Min_btn.Name = "Min_btn";
            this.Min_btn.Size = new System.Drawing.Size(20, 20);
            this.Min_btn.TabIndex = 15;
            this.Min_btn.TabStop = false;
            this.Min_btn.Click += new System.EventHandler(this.Min_btn_Click_1);
            // 
            // Cls_btn
            // 
            this.Cls_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cls_btn.BackgroundImage")));
            this.Cls_btn.Image = ((System.Drawing.Image)(resources.GetObject("Cls_btn.Image")));
            this.Cls_btn.Location = new System.Drawing.Point(994, 12);
            this.Cls_btn.Name = "Cls_btn";
            this.Cls_btn.Size = new System.Drawing.Size(20, 20);
            this.Cls_btn.TabIndex = 14;
            this.Cls_btn.TabStop = false;
            this.Cls_btn.Click += new System.EventHandler(this.Cls_btn_Click_1);
            // 
            // Estadisticasfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1026, 527);
            this.Controls.Add(this.statics_btn);
            this.Controls.Add(this.list_btn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Min_btn);
            this.Controls.Add(this.Cls_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estadisticasfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "estadisticasfrm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Estadisticasfrm_MouseDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cls_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Min_btn;
        private System.Windows.Forms.PictureBox Cls_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button statics_btn;
        private System.Windows.Forms.Button list_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}