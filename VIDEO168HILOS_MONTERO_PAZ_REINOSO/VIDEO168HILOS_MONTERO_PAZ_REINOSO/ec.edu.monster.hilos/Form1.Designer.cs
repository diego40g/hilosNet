namespace VIDEO168HILOS_MONTERO_PAZ_REINOSO
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddBall = new System.Windows.Forms.Button();
            this.btnRemoveBall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 380);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // btnAddBall
            // 
            this.btnAddBall.Location = new System.Drawing.Point(12, 403);
            this.btnAddBall.Name = "btnAddBall";
            this.btnAddBall.Size = new System.Drawing.Size(103, 23);
            this.btnAddBall.TabIndex = 1;
            this.btnAddBall.Text = "Agregar Pelota";
            this.btnAddBall.UseVisualStyleBackColor = true;
            this.btnAddBall.Click += new System.EventHandler(this.btnAddBall_Click);
            // 
            // btnRemoveBall
            // 
            this.btnRemoveBall.Location = new System.Drawing.Point(285, 403);
            this.btnRemoveBall.Name = "btnRemoveBall";
            this.btnRemoveBall.Size = new System.Drawing.Size(103, 23);
            this.btnRemoveBall.TabIndex = 2;
            this.btnRemoveBall.Text = "Salir";
            this.btnRemoveBall.UseVisualStyleBackColor = true;
            this.btnRemoveBall.Click += new System.EventHandler(this.btnRemoveBall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveBall);
            this.Controls.Add(this.btnAddBall);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddBall;
        private System.Windows.Forms.Button btnRemoveBall;
    }
}

