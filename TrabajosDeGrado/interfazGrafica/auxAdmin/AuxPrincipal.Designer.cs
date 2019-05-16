namespace TrabajosDeGrado
{
    partial class AuxPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProrrogaAux = new System.Windows.Forms.Button();
            this.btnAsignaciónJur = new System.Windows.Forms.Button();
            this.btnPropuestaAux = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.btnProrrogaAux);
            this.groupBox1.Controls.Add(this.btnAsignaciónJur);
            this.groupBox1.Controls.Add(this.btnPropuestaAux);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 74);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // btnProrrogaAux
            // 
            this.btnProrrogaAux.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProrrogaAux.Location = new System.Drawing.Point(334, 24);
            this.btnProrrogaAux.Name = "btnProrrogaAux";
            this.btnProrrogaAux.Size = new System.Drawing.Size(153, 33);
            this.btnProrrogaAux.TabIndex = 5;
            this.btnProrrogaAux.Text = "Prorroga";
            this.btnProrrogaAux.UseVisualStyleBackColor = true;
            this.btnProrrogaAux.Click += new System.EventHandler(this.btnProrrogaAux_Click);
            // 
            // btnAsignaciónJur
            // 
            this.btnAsignaciónJur.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignaciónJur.Location = new System.Drawing.Point(165, 24);
            this.btnAsignaciónJur.Name = "btnAsignaciónJur";
            this.btnAsignaciónJur.Size = new System.Drawing.Size(153, 33);
            this.btnAsignaciónJur.TabIndex = 2;
            this.btnAsignaciónJur.Text = "Asignación jurado";
            this.btnAsignaciónJur.UseVisualStyleBackColor = true;
            this.btnAsignaciónJur.Click += new System.EventHandler(this.btnAsignaciónJur_Click);
            // 
            // btnPropuestaAux
            // 
            this.btnPropuestaAux.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPropuestaAux.Location = new System.Drawing.Point(6, 24);
            this.btnPropuestaAux.Name = "btnPropuestaAux";
            this.btnPropuestaAux.Size = new System.Drawing.Size(153, 33);
            this.btnPropuestaAux.TabIndex = 1;
            this.btnPropuestaAux.Text = "Propuestas";
            this.btnPropuestaAux.UseVisualStyleBackColor = true;
            this.btnPropuestaAux.Click += new System.EventHandler(this.btnPropuestaAux_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "AUX ADMINISTRATIVO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrabajosDeGrado.Properties.Resources.uniibague_300x259;
            this.pictureBox1.Location = new System.Drawing.Point(11, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // AuxPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 150);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AuxPrincipal";
            this.Text = "Auxiliar Administrativa";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAsignaciónJur;
        private System.Windows.Forms.Button btnPropuestaAux;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnProrrogaAux;
    }
}