namespace Axamen
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnvehiculo = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnlideres = new Bunifu.Framework.UI.BunifuImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnrutas = new Bunifu.Framework.UI.BunifuImageButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnvehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlideres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrutas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Agregar Lider";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Agregar vehiculo";
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Transparent;
            this.btnsalir.Image = global::Axamen.Properties.Resources.sign_out;
            this.btnsalir.ImageActive = null;
            this.btnsalir.Location = new System.Drawing.Point(317, 113);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(53, 52);
            this.btnsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnsalir.TabIndex = 2;
            this.btnsalir.TabStop = false;
            this.btnsalir.Zoom = 10;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnvehiculo
            // 
            this.btnvehiculo.BackColor = System.Drawing.Color.Transparent;
            this.btnvehiculo.Image = global::Axamen.Properties.Resources.tyre;
            this.btnvehiculo.ImageActive = null;
            this.btnvehiculo.Location = new System.Drawing.Point(173, 11);
            this.btnvehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.btnvehiculo.Name = "btnvehiculo";
            this.btnvehiculo.Size = new System.Drawing.Size(50, 56);
            this.btnvehiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnvehiculo.TabIndex = 1;
            this.btnvehiculo.TabStop = false;
            this.btnvehiculo.Zoom = 10;
            this.btnvehiculo.Click += new System.EventHandler(this.btnvehiculo_Click);
            // 
            // btnlideres
            // 
            this.btnlideres.BackColor = System.Drawing.Color.Transparent;
            this.btnlideres.Image = global::Axamen.Properties.Resources.friends;
            this.btnlideres.ImageActive = null;
            this.btnlideres.Location = new System.Drawing.Point(70, 11);
            this.btnlideres.Margin = new System.Windows.Forms.Padding(2);
            this.btnlideres.Name = "btnlideres";
            this.btnlideres.Size = new System.Drawing.Size(56, 56);
            this.btnlideres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnlideres.TabIndex = 0;
            this.btnlideres.TabStop = false;
            this.btnlideres.Zoom = 10;
            this.btnlideres.Click += new System.EventHandler(this.btnlideres_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Salir";
            // 
            // btnrutas
            // 
            this.btnrutas.BackColor = System.Drawing.Color.Transparent;
            this.btnrutas.Image = global::Axamen.Properties.Resources.road_perspective;
            this.btnrutas.ImageActive = null;
            this.btnrutas.Location = new System.Drawing.Point(263, 11);
            this.btnrutas.Margin = new System.Windows.Forms.Padding(2);
            this.btnrutas.Name = "btnrutas";
            this.btnrutas.Size = new System.Drawing.Size(50, 56);
            this.btnrutas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnrutas.TabIndex = 6;
            this.btnrutas.TabStop = false;
            this.btnrutas.Zoom = 10;
            this.btnrutas.Click += new System.EventHandler(this.btnrutas_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rutas";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 176);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnrutas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnvehiculo);
            this.Controls.Add(this.btnlideres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnvehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlideres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnlideres;
        private Bunifu.Framework.UI.BunifuImageButton btnvehiculo;
        private Bunifu.Framework.UI.BunifuImageButton btnsalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuImageButton btnrutas;
        private System.Windows.Forms.Label label4;
    }
}