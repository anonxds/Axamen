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
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbnombre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtIapellido = new System.Windows.Forms.TextBox();
            this.txtIEdad = new System.Windows.Forms.TextBox();
            this.cbgrimo = new System.Windows.Forms.ComboBox();
            this.cbIgrimo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIcontrasena = new System.Windows.Forms.TextBox();
            this.btnmod = new Bunifu.Framework.UI.BunifuImageButton();
            this.btndelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnsALIR = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnagregar = new Bunifu.Framework.UI.BunifuImageButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnmod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsALIR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnagregar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(69, 27);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(68, 20);
            this.txtnombre.TabIndex = 0;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(69, 48);
            this.txtapellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(68, 20);
            this.txtapellido.TabIndex = 1;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(69, 69);
            this.txtedad.Margin = new System.Windows.Forms.Padding(2);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(68, 20);
            this.txtedad.TabIndex = 2;
            this.txtedad.TextChanged += new System.EventHandler(this.txtedad_TextChanged);
            this.txtedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtedad_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gremios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nombre";
            // 
            // cbnombre
            // 
            this.cbnombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbnombre.FormattingEnabled = true;
            this.cbnombre.Location = new System.Drawing.Point(382, 25);
            this.cbnombre.Margin = new System.Windows.Forms.Padding(2);
            this.cbnombre.Name = "cbnombre";
            this.cbnombre.Size = new System.Drawing.Size(82, 21);
            this.cbnombre.TabIndex = 14;
            this.cbnombre.SelectedIndexChanged += new System.EventHandler(this.cbnombre_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Gremio";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(335, 73);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(44, 13);
            this.lbl.TabIndex = 19;
            this.lbl.Text = "Apellido";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(347, 50);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(32, 13);
            this.lblnombre.TabIndex = 20;
            this.lblnombre.Text = "Edad";
            // 
            // txtIapellido
            // 
            this.txtIapellido.Enabled = false;
            this.txtIapellido.Location = new System.Drawing.Point(382, 71);
            this.txtIapellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtIapellido.Name = "txtIapellido";
            this.txtIapellido.Size = new System.Drawing.Size(68, 20);
            this.txtIapellido.TabIndex = 22;
            this.txtIapellido.TextChanged += new System.EventHandler(this.txtIapellido_TextChanged);
            // 
            // txtIEdad
            // 
            this.txtIEdad.Enabled = false;
            this.txtIEdad.Location = new System.Drawing.Point(382, 50);
            this.txtIEdad.Margin = new System.Windows.Forms.Padding(2);
            this.txtIEdad.Name = "txtIEdad";
            this.txtIEdad.Size = new System.Drawing.Size(68, 20);
            this.txtIEdad.TabIndex = 23;
            this.txtIEdad.TextChanged += new System.EventHandler(this.txtIEdad_TextChanged);
            this.txtIEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIEdad_KeyPress);
            // 
            // cbgrimo
            // 
            this.cbgrimo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbgrimo.FormattingEnabled = true;
            this.cbgrimo.Location = new System.Drawing.Point(69, 119);
            this.cbgrimo.Margin = new System.Windows.Forms.Padding(2);
            this.cbgrimo.Name = "cbgrimo";
            this.cbgrimo.Size = new System.Drawing.Size(82, 21);
            this.cbgrimo.TabIndex = 25;
            // 
            // cbIgrimo
            // 
            this.cbIgrimo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIgrimo.Enabled = false;
            this.cbIgrimo.FormattingEnabled = true;
            this.cbIgrimo.Location = new System.Drawing.Point(382, 90);
            this.cbIgrimo.Margin = new System.Windows.Forms.Padding(2);
            this.cbIgrimo.Name = "cbIgrimo";
            this.cbIgrimo.Size = new System.Drawing.Size(82, 21);
            this.cbIgrimo.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Agregar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(381, 6);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Modificar";
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Location = new System.Drawing.Point(69, 94);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(68, 20);
            this.txtcontrasena.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Contrasena";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(318, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Contrasena";
            // 
            // txtIcontrasena
            // 
            this.txtIcontrasena.Enabled = false;
            this.txtIcontrasena.Location = new System.Drawing.Point(384, 119);
            this.txtIcontrasena.Name = "txtIcontrasena";
            this.txtIcontrasena.Size = new System.Drawing.Size(100, 20);
            this.txtIcontrasena.TabIndex = 32;
            // 
            // btnmod
            // 
            this.btnmod.BackColor = System.Drawing.Color.Transparent;
            this.btnmod.Enabled = false;
            this.btnmod.Image = global::Axamen.Properties.Resources.delete__1_;
            this.btnmod.ImageActive = null;
            this.btnmod.Location = new System.Drawing.Point(437, 179);
            this.btnmod.Margin = new System.Windows.Forms.Padding(2);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(47, 46);
            this.btnmod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmod.TabIndex = 24;
            this.btnmod.TabStop = false;
            this.btnmod.Zoom = 10;
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Transparent;
            this.btndelete.Enabled = false;
            this.btndelete.Image = global::Axamen.Properties.Resources.edit;
            this.btndelete.ImageActive = null;
            this.btndelete.Location = new System.Drawing.Point(371, 179);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(47, 46);
            this.btndelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btndelete.TabIndex = 16;
            this.btndelete.TabStop = false;
            this.btndelete.Zoom = 10;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsALIR
            // 
            this.btnsALIR.BackColor = System.Drawing.Color.Transparent;
            this.btnsALIR.Image = global::Axamen.Properties.Resources.back_arrow__2_;
            this.btnsALIR.ImageActive = null;
            this.btnsALIR.Location = new System.Drawing.Point(241, 179);
            this.btnsALIR.Margin = new System.Windows.Forms.Padding(2);
            this.btnsALIR.Name = "btnsALIR";
            this.btnsALIR.Size = new System.Drawing.Size(47, 46);
            this.btnsALIR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnsALIR.TabIndex = 13;
            this.btnsALIR.TabStop = false;
            this.btnsALIR.Zoom = 10;
            this.btnsALIR.Click += new System.EventHandler(this.btnsALIR_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.Transparent;
            this.btnagregar.Image = global::Axamen.Properties.Resources.plus__1_;
            this.btnagregar.ImageActive = null;
            this.btnagregar.Location = new System.Drawing.Point(69, 179);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(47, 46);
            this.btnagregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnagregar.TabIndex = 12;
            this.btnagregar.TabStop = false;
            this.btnagregar.Zoom = 10;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(72, 164);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Agregar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(243, 164);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Regresar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(379, 164);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Editar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(439, 164);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Eliminar";
            // 
            // Lideres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 251);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtIcontrasena);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtcontrasena);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Lideres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lideres";
            this.Load += new System.EventHandler(this.Lideres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnmod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsALIR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnagregar)).EndInit();
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
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIcontrasena;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}