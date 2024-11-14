namespace SistemaVentas
{
    partial class frmMuestra
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
            this.lblusuario = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbldiafecha = new System.Windows.Forms.Label();
            this.lbldia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de ventas Familia Bercomat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bienvenido:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(195, 193);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(50, 20);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "label3";
            this.lblusuario.Click += new System.EventHandler(this.lblusuario_Click);
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Location = new System.Drawing.Point(97, 44);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(161, 146);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.lbldiafecha);
            this.groupBox1.Controls.Add(this.lbldia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.picLogo);
            this.groupBox1.Controls.Add(this.lblusuario);
            this.groupBox1.Location = new System.Drawing.Point(278, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 363);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lbldiafecha
            // 
            this.lbldiafecha.AutoSize = true;
            this.lbldiafecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiafecha.Location = new System.Drawing.Point(32, 343);
            this.lbldiafecha.Name = "lbldiafecha";
            this.lbldiafecha.Size = new System.Drawing.Size(30, 17);
            this.lbldiafecha.TabIndex = 5;
            this.lbldiafecha.Text = "Dia:";
            // 
            // lbldia
            // 
            this.lbldia.AutoSize = true;
            this.lbldia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldia.Location = new System.Drawing.Point(6, 343);
            this.lbldia.Name = "lbldia";
            this.lbldia.Size = new System.Drawing.Size(30, 17);
            this.lbldia.TabIndex = 4;
            this.lbldia.Text = "Dia:";
            // 
            // frmMuestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMuestra";
            this.Text = "frmMuestra";
            this.Load += new System.EventHandler(this.frmMuestra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbldia;
        private System.Windows.Forms.Label lbldiafecha;
    }
}