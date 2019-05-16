namespace TrabajosDeGrado
{
    partial class EstudiantePrincipal
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProrroga = new System.Windows.Forms.Button();
            this.btnDocFinal = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnPropuesta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "ESTUDIANTES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrabajosDeGrado.Properties.Resources.uniibague_300x259;
            this.pictureBox1.Location = new System.Drawing.Point(11, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.btnProrroga);
            this.groupBox1.Controls.Add(this.btnDocFinal);
            this.groupBox1.Controls.Add(this.btnEstado);
            this.groupBox1.Controls.Add(this.btnPropuesta);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 112);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // btnProrroga
            // 
            this.btnProrroga.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProrroga.Location = new System.Drawing.Point(169, 63);
            this.btnProrroga.Name = "btnProrroga";
            this.btnProrroga.Size = new System.Drawing.Size(153, 33);
            this.btnProrroga.TabIndex = 4;
            this.btnProrroga.Text = "Prorroga";
            this.btnProrroga.UseVisualStyleBackColor = true;
            this.btnProrroga.Click += new System.EventHandler(this.btnProrroga_Click);
            // 
            // btnDocFinal
            // 
            this.btnDocFinal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocFinal.Location = new System.Drawing.Point(169, 22);
            this.btnDocFinal.Name = "btnDocFinal";
            this.btnDocFinal.Size = new System.Drawing.Size(153, 33);
            this.btnDocFinal.TabIndex = 3;
            this.btnDocFinal.Text = "Documento Final";
            this.btnDocFinal.UseVisualStyleBackColor = true;
            this.btnDocFinal.Click += new System.EventHandler(this.btnDocFinal_Click);
            // 
            // btnEstado
            // 
            this.btnEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstado.Location = new System.Drawing.Point(6, 63);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(153, 33);
            this.btnEstado.TabIndex = 2;
            this.btnEstado.Text = "Estado";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // btnPropuesta
            // 
            this.btnPropuesta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPropuesta.Location = new System.Drawing.Point(6, 24);
            this.btnPropuesta.Name = "btnPropuesta";
            this.btnPropuesta.Size = new System.Drawing.Size(153, 33);
            this.btnPropuesta.TabIndex = 1;
            this.btnPropuesta.Text = "Propuesta";
            this.btnPropuesta.UseVisualStyleBackColor = true;
            this.btnPropuesta.Click += new System.EventHandler(this.btnPropuesta_Click);
            // 
            // EstudiantePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 197);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EstudiantePrincipal";
            this.Text = "Estudiante";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProrroga;
        private System.Windows.Forms.Button btnDocFinal;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Button btnPropuesta;
    }
}