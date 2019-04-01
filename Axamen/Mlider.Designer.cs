namespace Axamen
{
    partial class Mlider
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
            this.btnsalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tbinfo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblclan = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btneliminar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnmodificar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnadd = new Bunifu.Framework.UI.BunifuImageButton();
            this.label13 = new System.Windows.Forms.Label();
            this.txtKi = new System.Windows.Forms.TextBox();
            this.txtIki = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbruta = new System.Windows.Forms.ComboBox();
            this.txtIC = new System.Windows.Forms.TextBox();
            this.txtcapacidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbIvehiculo = new System.Windows.Forms.ComboBox();
            this.cbC = new System.Windows.Forms.ComboBox();
            this.cbR = new System.Windows.Forms.ComboBox();
            this.cbIvim = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbin = new System.Windows.Forms.TextBox();
            this.cbcombustible = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbvehiculo = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tbinfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btneliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmodificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Transparent;
            this.btnsalir.Image = global::Axamen.Properties.Resources.sign_out;
            this.btnsalir.ImageActive = null;
            this.btnsalir.Location = new System.Drawing.Point(494, 400);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(47, 46);
            this.btnsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnsalir.TabIndex = 6;
            this.btnsalir.TabStop = false;
            this.btnsalir.Zoom = 10;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(76, 58);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(449, 303);
            this.dgv.TabIndex = 7;
            // 
            // tbinfo
            // 
            this.tbinfo.Controls.Add(this.tabPage1);
            this.tbinfo.Controls.Add(this.tabPage2);
            this.tbinfo.Location = new System.Drawing.Point(12, 2);
            this.tbinfo.Name = "tbinfo";
            this.tbinfo.SelectedIndex = 0;
            this.tbinfo.Size = new System.Drawing.Size(539, 393);
            this.tbinfo.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblnombre);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblclan);
            this.tabPage1.Controls.Add(this.dgv);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(531, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Info";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sindicato";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(70, 12);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(10, 13);
            this.lblnombre.TabIndex = 10;
            this.lblnombre.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // lblclan
            // 
            this.lblclan.AutoSize = true;
            this.lblclan.Location = new System.Drawing.Point(70, 37);
            this.lblclan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblclan.Name = "lblclan";
            this.lblclan.Size = new System.Drawing.Size(10, 13);
            this.lblclan.TabIndex = 11;
            this.lblclan.Text = ".";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.btneliminar);
            this.tabPage2.Controls.Add(this.btnmodificar);
            this.tabPage2.Controls.Add(this.btnadd);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtKi);
            this.tabPage2.Controls.Add(this.txtIki);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.cbruta);
            this.tabPage2.Controls.Add(this.txtIC);
            this.tabPage2.Controls.Add(this.txtcapacidad);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.cbIvehiculo);
            this.tabPage2.Controls.Add(this.cbC);
            this.tabPage2.Controls.Add(this.cbR);
            this.tabPage2.Controls.Add(this.cbIvim);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtbin);
            this.tabPage2.Controls.Add(this.cbcombustible);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cbvehiculo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(531, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vehiculos";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(377, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 13);
            this.label20.TabIndex = 75;
            this.label20.Text = "Editar";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(117, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 13);
            this.label19.TabIndex = 74;
            this.label19.Text = "Agregar";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(430, 262);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 73;
            this.label18.Text = "Eliminar";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(346, 262);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 72;
            this.label17.Text = "Actualizar";
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Transparent;
            this.btneliminar.Enabled = false;
            this.btneliminar.Image = global::Axamen.Properties.Resources.delete__1_;
            this.btneliminar.ImageActive = null;
            this.btneliminar.Location = new System.Drawing.Point(426, 214);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(47, 46);
            this.btneliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btneliminar.TabIndex = 70;
            this.btneliminar.TabStop = false;
            this.btneliminar.Zoom = 10;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.Transparent;
            this.btnmodificar.Enabled = false;
            this.btnmodificar.Image = global::Axamen.Properties.Resources.edit;
            this.btnmodificar.ImageActive = null;
            this.btnmodificar.Location = new System.Drawing.Point(349, 214);
            this.btnmodificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(47, 46);
            this.btnmodificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmodificar.TabIndex = 69;
            this.btnmodificar.TabStop = false;
            this.btnmodificar.Zoom = 10;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Transparent;
            this.btnadd.Image = global::Axamen.Properties.Resources.plus__1_;
            this.btnadd.ImageActive = null;
            this.btnadd.Location = new System.Drawing.Point(131, 214);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(47, 46);
            this.btnadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnadd.TabIndex = 67;
            this.btnadd.TabStop = false;
            this.btnadd.Zoom = 10;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(133, 262);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 66;
            this.label13.Text = "Agregar";
            // 
            // txtKi
            // 
            this.txtKi.Location = new System.Drawing.Point(106, 180);
            this.txtKi.MaxLength = 12;
            this.txtKi.Name = "txtKi";
            this.txtKi.Size = new System.Drawing.Size(100, 20);
            this.txtKi.TabIndex = 65;
            this.txtKi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKi_KeyPress);
            // 
            // txtIki
            // 
            this.txtIki.Enabled = false;
            this.txtIki.Location = new System.Drawing.Point(373, 180);
            this.txtIki.MaxLength = 12;
            this.txtIki.Name = "txtIki";
            this.txtIki.Size = new System.Drawing.Size(100, 20);
            this.txtIki.TabIndex = 64;
            this.txtIki.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIki_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(309, 183);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 63;
            this.label15.Text = "Kilometraje";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(44, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 62;
            this.label14.Text = "Kilometraje";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(59, 153);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Ruta";
            // 
            // cbruta
            // 
            this.cbruta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbruta.FormattingEnabled = true;
            this.cbruta.Location = new System.Drawing.Point(105, 151);
            this.cbruta.Margin = new System.Windows.Forms.Padding(2);
            this.cbruta.Name = "cbruta";
            this.cbruta.Size = new System.Drawing.Size(82, 21);
            this.cbruta.TabIndex = 58;
            this.cbruta.SelectedIndexChanged += new System.EventHandler(this.cbruta_SelectedIndexChanged);
            // 
            // txtIC
            // 
            this.txtIC.Enabled = false;
            this.txtIC.Location = new System.Drawing.Point(380, 150);
            this.txtIC.Margin = new System.Windows.Forms.Padding(2);
            this.txtIC.MaxLength = 2;
            this.txtIC.Name = "txtIC";
            this.txtIC.Size = new System.Drawing.Size(68, 20);
            this.txtIC.TabIndex = 57;
            this.txtIC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIC_KeyPress);
            // 
            // txtcapacidad
            // 
            this.txtcapacidad.Location = new System.Drawing.Point(105, 102);
            this.txtcapacidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtcapacidad.MaxLength = 2;
            this.txtcapacidad.Name = "txtcapacidad";
            this.txtcapacidad.Size = new System.Drawing.Size(68, 20);
            this.txtcapacidad.TabIndex = 56;
            this.txtcapacidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcapacidad_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 104);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 55;
            this.label11.Text = "Capacidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(319, 150);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Capacidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 83);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Vehiculo";
            // 
            // cbIvehiculo
            // 
            this.cbIvehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIvehiculo.Enabled = false;
            this.cbIvehiculo.FormattingEnabled = true;
            this.cbIvehiculo.Location = new System.Drawing.Point(380, 79);
            this.cbIvehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.cbIvehiculo.Name = "cbIvehiculo";
            this.cbIvehiculo.Size = new System.Drawing.Size(82, 21);
            this.cbIvehiculo.TabIndex = 52;
            // 
            // cbC
            // 
            this.cbC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbC.Enabled = false;
            this.cbC.FormattingEnabled = true;
            this.cbC.Location = new System.Drawing.Point(380, 102);
            this.cbC.Margin = new System.Windows.Forms.Padding(2);
            this.cbC.Name = "cbC";
            this.cbC.Size = new System.Drawing.Size(82, 21);
            this.cbC.TabIndex = 51;
            // 
            // cbR
            // 
            this.cbR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbR.Enabled = false;
            this.cbR.FormattingEnabled = true;
            this.cbR.Location = new System.Drawing.Point(380, 128);
            this.cbR.Margin = new System.Windows.Forms.Padding(2);
            this.cbR.Name = "cbR";
            this.cbR.Size = new System.Drawing.Size(82, 21);
            this.cbR.TabIndex = 50;
            // 
            // cbIvim
            // 
            this.cbIvim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIvim.FormattingEnabled = true;
            this.cbIvim.Location = new System.Drawing.Point(380, 55);
            this.cbIvim.Margin = new System.Windows.Forms.Padding(2);
            this.cbIvim.Name = "cbIvim";
            this.cbIvim.Size = new System.Drawing.Size(82, 21);
            this.cbIvim.TabIndex = 49;
            this.cbIvim.SelectedIndexChanged += new System.EventHandler(this.cbIvim_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(346, 130);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Ruta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 57);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "VIN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Combustible";
            // 
            // txtbin
            // 
            this.txtbin.Location = new System.Drawing.Point(105, 79);
            this.txtbin.Margin = new System.Windows.Forms.Padding(2);
            this.txtbin.MaxLength = 17;
            this.txtbin.Name = "txtbin";
            this.txtbin.Size = new System.Drawing.Size(68, 20);
            this.txtbin.TabIndex = 45;
            // 
            // cbcombustible
            // 
            this.cbcombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcombustible.FormattingEnabled = true;
            this.cbcombustible.Location = new System.Drawing.Point(105, 126);
            this.cbcombustible.Margin = new System.Windows.Forms.Padding(2);
            this.cbcombustible.Name = "cbcombustible";
            this.cbcombustible.Size = new System.Drawing.Size(82, 21);
            this.cbcombustible.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Vehiculo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Combustible";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "VIN";
            // 
            // cbvehiculo
            // 
            this.cbvehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbvehiculo.FormattingEnabled = true;
            this.cbvehiculo.Location = new System.Drawing.Point(105, 55);
            this.cbvehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.cbvehiculo.Name = "cbvehiculo";
            this.cbvehiculo.Size = new System.Drawing.Size(82, 21);
            this.cbvehiculo.TabIndex = 38;
            this.cbvehiculo.SelectedIndexChanged += new System.EventHandler(this.cbvehiculo_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(462, 433);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Salir";
            // 
            // Mlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 457);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbinfo);
            this.Controls.Add(this.btnsalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Mlider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mlider";
            this.Load += new System.EventHandler(this.Mlider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tbinfo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btneliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmodificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton btnsalir;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TabControl tbinfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtKi;
        private System.Windows.Forms.TextBox txtIki;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbruta;
        private System.Windows.Forms.TextBox txtIC;
        private System.Windows.Forms.TextBox txtcapacidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbIvehiculo;
        private System.Windows.Forms.ComboBox cbC;
        private System.Windows.Forms.ComboBox cbR;
        private System.Windows.Forms.ComboBox cbIvim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbin;
        private System.Windows.Forms.ComboBox cbcombustible;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbvehiculo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private Bunifu.Framework.UI.BunifuImageButton btneliminar;
        private Bunifu.Framework.UI.BunifuImageButton btnmodificar;
        private Bunifu.Framework.UI.BunifuImageButton btnadd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblclan;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
    }
}