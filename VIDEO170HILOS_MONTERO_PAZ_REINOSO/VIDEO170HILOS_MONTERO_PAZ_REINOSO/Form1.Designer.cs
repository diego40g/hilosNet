namespace VIDEO170HILOS_MONTERO_PAZ_REINOSO
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
            this.btnAddBall1 = new System.Windows.Forms.Button();
            this.btnStopAll1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddBall2 = new System.Windows.Forms.Button();
            this.btnStopAll2 = new System.Windows.Forms.Button();
            this.btnAddBall3 = new System.Windows.Forms.Button();
            this.btnStopAll3 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            // btnAddBall1
            // 
            this.btnAddBall1.Location = new System.Drawing.Point(76, 386);
            this.btnAddBall1.Name = "btnAddBall1";
            this.btnAddBall1.Size = new System.Drawing.Size(103, 23);
            this.btnAddBall1.TabIndex = 1;
            this.btnAddBall1.Text = "Agregar Pelota";
            this.btnAddBall1.UseVisualStyleBackColor = true;
            this.btnAddBall1.Click += new System.EventHandler(this.btnAddBall_Click);
            // 
            // btnStopAll1
            // 
            this.btnStopAll1.Location = new System.Drawing.Point(200, 386);
            this.btnStopAll1.Name = "btnStopAll1";
            this.btnStopAll1.Size = new System.Drawing.Size(103, 23);
            this.btnStopAll1.TabIndex = 2;
            this.btnStopAll1.Text = "Detener Pelotas";
            this.btnStopAll1.UseVisualStyleBackColor = true;
            this.btnStopAll1.Click += new System.EventHandler(this.btnStopAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número de hilos 1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "0";
            // 
            // btnAddBall2
            // 
            this.btnAddBall2.Location = new System.Drawing.Point(76, 415);
            this.btnAddBall2.Name = "btnAddBall2";
            this.btnAddBall2.Size = new System.Drawing.Size(103, 23);
            this.btnAddBall2.TabIndex = 5;
            this.btnAddBall2.Text = "Agregar Pelota";
            this.btnAddBall2.UseVisualStyleBackColor = true;
            this.btnAddBall2.Click += new System.EventHandler(this.btnAddBall2_Click);
            // 
            // btnStopAll2
            // 
            this.btnStopAll2.Location = new System.Drawing.Point(200, 414);
            this.btnStopAll2.Name = "btnStopAll2";
            this.btnStopAll2.Size = new System.Drawing.Size(103, 23);
            this.btnStopAll2.TabIndex = 6;
            this.btnStopAll2.Text = "Detener Pelotas";
            this.btnStopAll2.UseVisualStyleBackColor = true;
            this.btnStopAll2.Click += new System.EventHandler(this.btnStopAll2_Click);
            // 
            // btnAddBall3
            // 
            this.btnAddBall3.Location = new System.Drawing.Point(77, 445);
            this.btnAddBall3.Name = "btnAddBall3";
            this.btnAddBall3.Size = new System.Drawing.Size(102, 23);
            this.btnAddBall3.TabIndex = 7;
            this.btnAddBall3.Text = "Agregar Pelota";
            this.btnAddBall3.UseVisualStyleBackColor = true;
            this.btnAddBall3.Click += new System.EventHandler(this.btnAddBall3_Click);
            // 
            // btnStopAll3
            // 
            this.btnStopAll3.Location = new System.Drawing.Point(200, 444);
            this.btnStopAll3.Name = "btnStopAll3";
            this.btnStopAll3.Size = new System.Drawing.Size(103, 23);
            this.btnStopAll3.TabIndex = 8;
            this.btnStopAll3.Text = "Detener Pelotas";
            this.btnStopAll3.UseVisualStyleBackColor = true;
            this.btnStopAll3.Click += new System.EventHandler(this.btnStopAll3_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(547, 386);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(173, 82);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Número de hilos 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Número de hilos 3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStopAll3);
            this.Controls.Add(this.btnAddBall3);
            this.Controls.Add(this.btnStopAll2);
            this.Controls.Add(this.btnAddBall2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStopAll1);
            this.Controls.Add(this.btnAddBall1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddBall1;
        private System.Windows.Forms.Button btnStopAll1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddBall2;
        private System.Windows.Forms.Button btnStopAll2;
        private System.Windows.Forms.Button btnAddBall3;
        private System.Windows.Forms.Button btnStopAll3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}

