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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mlider));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblclan = new System.Windows.Forms.Label();
            this.btnagregar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnsalir = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnagregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clan";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(125, 31);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(13, 20);
            this.lblnombre.TabIndex = 3;
            this.lblnombre.Text = ".";
            // 
            // lblclan
            // 
            this.lblclan.AutoSize = true;
            this.lblclan.Location = new System.Drawing.Point(101, 69);
            this.lblclan.Name = "lblclan";
            this.lblclan.Size = new System.Drawing.Size(13, 20);
            this.lblclan.TabIndex = 4;
            this.lblclan.Text = ".";
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnagregar.Image = ((System.Drawing.Image)(resources.GetObject("btnagregar.Image")));
            this.btnagregar.ImageActive = null;
            this.btnagregar.Location = new System.Drawing.Point(48, 141);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(71, 71);
            this.btnagregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnagregar.TabIndex = 5;
            this.btnagregar.TabStop = false;
            this.btnagregar.Zoom = 10;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.SeaGreen;
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.ImageActive = null;
            this.btnsalir.Location = new System.Drawing.Point(232, 141);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(71, 71);
            this.btnsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnsalir.TabIndex = 6;
            this.btnsalir.TabStop = false;
            this.btnsalir.Zoom = 10;
            // 
            // Mlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 258);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.lblclan);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mlider";
            this.Text = "Mlider";
            ((System.ComponentModel.ISupportInitialize)(this.btnagregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblclan;
        private Bunifu.Framework.UI.BunifuImageButton btnagregar;
        private Bunifu.Framework.UI.BunifuImageButton btnsalir;
    }
}