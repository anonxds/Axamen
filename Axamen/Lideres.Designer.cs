namespace Axamen
{
    partial class Lideres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lideres));
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnagregar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnsALIR = new Bunifu.Framework.UI.BunifuImageButton();
            this.cbnombre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btndelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtIapellido = new System.Windows.Forms.TextBox();
            this.txtIEdad = new System.Windows.Forms.TextBox();
            this.btnmod = new Bunifu.Framework.UI.BunifuImageButton();
            this.cbgrimo = new System.Windows.Forms.ComboBox();
            this.cbIgrimo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnagregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsALIR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmod)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(103, 42);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 26);
            this.txtnombre.TabIndex = 0;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(103, 74);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 26);
            this.txtapellido.TabIndex = 1;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(103, 106);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 26);
            this.txtedad.TabIndex = 2;
            this.txtedad.TextChanged += new System.EventHandler(this.txtedad_TextChanged);
            this.txtedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtedad_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gremios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nombre";
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnagregar.Image = ((System.Drawing.Image)(resources.GetObject("btnagregar.Image")));
            this.btnagregar.ImageActive = null;
            this.btnagregar.Location = new System.Drawing.Point(103, 200);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(71, 71);
            this.btnagregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnagregar.TabIndex = 12;
            this.btnagregar.TabStop = false;
            this.btnagregar.Zoom = 10;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnsALIR
            // 
            this.btnsALIR.BackColor = System.Drawing.Color.SeaGreen;
            this.btnsALIR.Image = ((System.Drawing.Image)(resources.GetObject("btnsALIR.Image")));
            this.btnsALIR.ImageActive = null;
            this.btnsALIR.Location = new System.Drawing.Point(375, 204);
            this.btnsALIR.Name = "btnsALIR";
            this.btnsALIR.Size = new System.Drawing.Size(71, 71);
            this.btnsALIR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnsALIR.TabIndex = 13;
            this.btnsALIR.TabStop = false;
            this.btnsALIR.Zoom = 10;
            this.btnsALIR.Click += new System.EventHandler(this.btnsALIR_Click);
            // 
            // cbnombre
            // 
            this.cbnombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbnombre.FormattingEnabled = true;
            this.cbnombre.Location = new System.Drawing.Point(573, 39);
            this.cbnombre.Name = "cbnombre";
            this.cbnombre.Size = new System.Drawing.Size(121, 28);
            this.cbnombre.TabIndex = 14;
            this.cbnombre.SelectedIndexChanged += new System.EventHandler(this.cbnombre_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Usuario";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.SeaGreen;
            this.btndelete.Enabled = false;
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.ImageActive = null;
            this.btndelete.Location = new System.Drawing.Point(573, 200);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(71, 71);
            this.btndelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btndelete.TabIndex = 16;
            this.btndelete.TabStop = false;
            this.btndelete.Zoom = 10;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(506, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Gremio";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(502, 112);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(65, 20);
            this.lbl.TabIndex = 19;
            this.lbl.Text = "Apellido";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(520, 77);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(47, 20);
            this.lblnombre.TabIndex = 20;
            this.lblnombre.Text = "Edad";
            // 
            // txtIapellido
            // 
            this.txtIapellido.Enabled = false;
            this.txtIapellido.Location = new System.Drawing.Point(573, 109);
            this.txtIapellido.Name = "txtIapellido";
            this.txtIapellido.Size = new System.Drawing.Size(100, 26);
            this.txtIapellido.TabIndex = 22;
            this.txtIapellido.TextChanged += new System.EventHandler(this.txtIapellido_TextChanged);
            // 
            // txtIEdad
            // 
            this.txtIEdad.Enabled = false;
            this.txtIEdad.Location = new System.Drawing.Point(573, 77);
            this.txtIEdad.Name = "txtIEdad";
            this.txtIEdad.Size = new System.Drawing.Size(100, 26);
            this.txtIEdad.TabIndex = 23;
            this.txtIEdad.TextChanged += new System.EventHandler(this.txtIEdad_TextChanged);
            this.txtIEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIEdad_KeyPress);
            // 
            // btnmod
            // 
            this.btnmod.BackColor = System.Drawing.Color.SeaGreen;
            this.btnmod.Enabled = false;
            this.btnmod.Image = ((System.Drawing.Image)(resources.GetObject("btnmod.Image")));
            this.btnmod.ImageActive = null;
            this.btnmod.Location = new System.Drawing.Point(657, 200);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(71, 71);
            this.btnmod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmod.TabIndex = 24;
            this.btnmod.TabStop = false;
            this.btnmod.Zoom = 10;
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // cbgrimo
            // 
            this.cbgrimo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbgrimo.FormattingEnabled = true;
            this.cbgrimo.Location = new System.Drawing.Point(104, 138);
            this.cbgrimo.Name = "cbgrimo";
            this.cbgrimo.Size = new System.Drawing.Size(121, 28);
            this.cbgrimo.TabIndex = 25;
            // 
            // cbIgrimo
            // 
            this.cbIgrimo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIgrimo.Enabled = false;
            this.cbIgrimo.FormattingEnabled = true;
            this.cbIgrimo.Location = new System.Drawing.Point(573, 138);
            this.cbIgrimo.Name = "cbIgrimo";
            this.cbIgrimo.Size = new System.Drawing.Size(121, 28);
            this.cbIgrimo.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Agregar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(571, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Modificar";
            // 
            // Lideres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 287);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbIgrimo);
            this.Controls.Add(this.cbgrimo);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.txtIEdad);
            this.Controls.Add(this.txtIapellido);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbnombre);
            this.Controls.Add(this.btnsALIR);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lideres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lideres";
            this.Load += new System.EventHandler(this.Lideres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnagregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsALIR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuImageButton btnagregar;
        private Bunifu.Framework.UI.BunifuImageButton btnsALIR;
        private System.Windows.Forms.ComboBox cbnombre;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btndelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtIapellido;
        private System.Windows.Forms.TextBox txtIEdad;
        private Bunifu.Framework.UI.BunifuImageButton btnmod;
        private System.Windows.Forms.ComboBox cbgrimo;
        private System.Windows.Forms.ComboBox cbIgrimo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}