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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnlideres = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnvehiculo = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnsalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnlideres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnvehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlideres
            // 
            this.btnlideres.BackColor = System.Drawing.Color.SeaGreen;
            this.btnlideres.Image = ((System.Drawing.Image)(resources.GetObject("btnlideres.Image")));
            this.btnlideres.ImageActive = null;
            this.btnlideres.Location = new System.Drawing.Point(96, 53);
            this.btnlideres.Name = "btnlideres";
            this.btnlideres.Size = new System.Drawing.Size(71, 71);
            this.btnlideres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnlideres.TabIndex = 0;
            this.btnlideres.TabStop = false;
            this.btnlideres.Zoom = 10;
            this.btnlideres.Click += new System.EventHandler(this.btnlideres_Click);
            // 
            // btnvehiculo
            // 
            this.btnvehiculo.BackColor = System.Drawing.Color.SeaGreen;
            this.btnvehiculo.Image = ((System.Drawing.Image)(resources.GetObject("btnvehiculo.Image")));
            this.btnvehiculo.ImageActive = null;
            this.btnvehiculo.Location = new System.Drawing.Point(238, 53);
            this.btnvehiculo.Name = "btnvehiculo";
            this.btnvehiculo.Size = new System.Drawing.Size(71, 71);
            this.btnvehiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnvehiculo.TabIndex = 1;
            this.btnvehiculo.TabStop = false;
            this.btnvehiculo.Zoom = 10;
            this.btnvehiculo.Click += new System.EventHandler(this.btnvehiculo_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.SeaGreen;
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.ImageActive = null;
            this.btnsalir.Location = new System.Drawing.Point(343, 138);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(71, 71);
            this.btnsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnsalir.TabIndex = 2;
            this.btnsalir.TabStop = false;
            this.btnsalir.Zoom = 10;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Agregar Lider";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Agregar vehiculo";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 221);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnvehiculo);
            this.Controls.Add(this.btnlideres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.btnlideres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnvehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnlideres;
        private Bunifu.Framework.UI.BunifuImageButton btnvehiculo;
        private Bunifu.Framework.UI.BunifuImageButton btnsalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}