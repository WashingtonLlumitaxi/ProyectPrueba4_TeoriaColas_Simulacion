
namespace ProyectPrueba1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.MAXIMIZAR = new System.Windows.Forms.PictureBox();
            this.RESTAURAR = new System.Windows.Forms.PictureBox();
            this.SALIR = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelSubOperacion = new System.Windows.Forms.Panel();
            this.btnPFCM = new System.Windows.Forms.Button();
            this.btnPFCS = new System.Windows.Forms.Button();
            this.btnPICM = new System.Windows.Forms.Button();
            this.btnPICS = new System.Windows.Forms.Button();
            this.btnOperaciones = new System.Windows.Forms.Button();
            this.PnlCont1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MAXIMIZAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RESTAURAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SALIR)).BeginInit();
            this.panel4.SuspendLayout();
            this.panelSubOperacion.SuspendLayout();
            this.PnlCont1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.MAXIMIZAR);
            this.panel3.Controls.Add(this.RESTAURAR);
            this.panel3.Controls.Add(this.SALIR);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 35);
            this.panel3.TabIndex = 3;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(289, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "TEORIA DE COLAS";
            // 
            // MAXIMIZAR
            // 
            this.MAXIMIZAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MAXIMIZAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MAXIMIZAR.Image = ((System.Drawing.Image)(resources.GetObject("MAXIMIZAR.Image")));
            this.MAXIMIZAR.Location = new System.Drawing.Point(685, 6);
            this.MAXIMIZAR.Name = "MAXIMIZAR";
            this.MAXIMIZAR.Size = new System.Drawing.Size(34, 26);
            this.MAXIMIZAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MAXIMIZAR.TabIndex = 3;
            this.MAXIMIZAR.TabStop = false;
            this.MAXIMIZAR.Click += new System.EventHandler(this.MAXIMIZAR_Click);
            // 
            // RESTAURAR
            // 
            this.RESTAURAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RESTAURAR.Location = new System.Drawing.Point(693, 9);
            this.RESTAURAR.Name = "RESTAURAR";
            this.RESTAURAR.Size = new System.Drawing.Size(16, 20);
            this.RESTAURAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RESTAURAR.TabIndex = 1;
            this.RESTAURAR.TabStop = false;
            this.RESTAURAR.Visible = false;
            // 
            // SALIR
            // 
            this.SALIR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SALIR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SALIR.Image = global::ProyectPrueba1.Properties.Resources.salir;
            this.SALIR.Location = new System.Drawing.Point(725, 9);
            this.SALIR.Name = "SALIR";
            this.SALIR.Size = new System.Drawing.Size(16, 20);
            this.SALIR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SALIR.TabIndex = 0;
            this.SALIR.TabStop = false;
            this.SALIR.Click += new System.EventHandler(this.SALIR_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Controls.Add(this.panelSubOperacion);
            this.panel4.Controls.Add(this.btnOperaciones);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(103, 465);
            this.panel4.TabIndex = 5;
            // 
            // panelSubOperacion
            // 
            this.panelSubOperacion.Controls.Add(this.btnPFCM);
            this.panelSubOperacion.Controls.Add(this.btnPFCS);
            this.panelSubOperacion.Controls.Add(this.btnPICM);
            this.panelSubOperacion.Controls.Add(this.btnPICS);
            this.panelSubOperacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubOperacion.Location = new System.Drawing.Point(0, 27);
            this.panelSubOperacion.Name = "panelSubOperacion";
            this.panelSubOperacion.Size = new System.Drawing.Size(103, 438);
            this.panelSubOperacion.TabIndex = 4;
            // 
            // btnPFCM
            // 
            this.btnPFCM.BackColor = System.Drawing.Color.Gray;
            this.btnPFCM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPFCM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPFCM.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPFCM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPFCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPFCM.ForeColor = System.Drawing.Color.White;
            this.btnPFCM.Location = new System.Drawing.Point(0, 78);
            this.btnPFCM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPFCM.Name = "btnPFCM";
            this.btnPFCM.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPFCM.Size = new System.Drawing.Size(103, 26);
            this.btnPFCM.TabIndex = 7;
            this.btnPFCM.Text = "PFCM";
            this.btnPFCM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPFCM.UseVisualStyleBackColor = false;
            this.btnPFCM.Click += new System.EventHandler(this.btnPFCM_Click);
            // 
            // btnPFCS
            // 
            this.btnPFCS.BackColor = System.Drawing.Color.Gray;
            this.btnPFCS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPFCS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPFCS.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPFCS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPFCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPFCS.ForeColor = System.Drawing.Color.White;
            this.btnPFCS.Location = new System.Drawing.Point(0, 52);
            this.btnPFCS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPFCS.Name = "btnPFCS";
            this.btnPFCS.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPFCS.Size = new System.Drawing.Size(103, 26);
            this.btnPFCS.TabIndex = 6;
            this.btnPFCS.Text = "PFCS";
            this.btnPFCS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPFCS.UseVisualStyleBackColor = false;
            this.btnPFCS.Click += new System.EventHandler(this.btnPFCS_Click);
            // 
            // btnPICM
            // 
            this.btnPICM.BackColor = System.Drawing.Color.Gray;
            this.btnPICM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPICM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPICM.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPICM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPICM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPICM.ForeColor = System.Drawing.Color.White;
            this.btnPICM.Location = new System.Drawing.Point(0, 26);
            this.btnPICM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPICM.Name = "btnPICM";
            this.btnPICM.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPICM.Size = new System.Drawing.Size(103, 26);
            this.btnPICM.TabIndex = 5;
            this.btnPICM.Text = "PICM";
            this.btnPICM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPICM.UseVisualStyleBackColor = false;
            this.btnPICM.Click += new System.EventHandler(this.btnPICM_Click);
            // 
            // btnPICS
            // 
            this.btnPICS.BackColor = System.Drawing.Color.Gray;
            this.btnPICS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPICS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPICS.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPICS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPICS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPICS.ForeColor = System.Drawing.Color.White;
            this.btnPICS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPICS.Location = new System.Drawing.Point(0, 0);
            this.btnPICS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPICS.Name = "btnPICS";
            this.btnPICS.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPICS.Size = new System.Drawing.Size(103, 26);
            this.btnPICS.TabIndex = 4;
            this.btnPICS.Text = "PICS";
            this.btnPICS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPICS.UseVisualStyleBackColor = false;
            this.btnPICS.Click += new System.EventHandler(this.btnPICS_Click);
            // 
            // btnOperaciones
            // 
            this.btnOperaciones.BackColor = System.Drawing.Color.Transparent;
            this.btnOperaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOperaciones.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnOperaciones.FlatAppearance.BorderSize = 0;
            this.btnOperaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperaciones.ForeColor = System.Drawing.Color.Black;
            this.btnOperaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOperaciones.Location = new System.Drawing.Point(0, 0);
            this.btnOperaciones.Name = "btnOperaciones";
            this.btnOperaciones.Size = new System.Drawing.Size(103, 27);
            this.btnOperaciones.TabIndex = 0;
            this.btnOperaciones.Text = "Tareas";
            this.btnOperaciones.UseVisualStyleBackColor = false;
            // 
            // PnlCont1
            // 
            this.PnlCont1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.PnlCont1.Controls.Add(this.pictureBox1);
            this.PnlCont1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCont1.Location = new System.Drawing.Point(103, 35);
            this.PnlCont1.Name = "PnlCont1";
            this.PnlCont1.Size = new System.Drawing.Size(647, 465);
            this.PnlCont1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(110, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(428, 395);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.PnlCont1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MAXIMIZAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RESTAURAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SALIR)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panelSubOperacion.ResumeLayout(false);
            this.PnlCont1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox MAXIMIZAR;
        private System.Windows.Forms.PictureBox RESTAURAR;
        private System.Windows.Forms.PictureBox SALIR;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelSubOperacion;
        private System.Windows.Forms.Button btnPICM;
        private System.Windows.Forms.Button btnPICS;
        private System.Windows.Forms.Button btnOperaciones;
        private System.Windows.Forms.Button btnPFCM;
        private System.Windows.Forms.Button btnPFCS;
        private System.Windows.Forms.Panel PnlCont1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

