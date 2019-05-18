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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstudiantePrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProrroga = new System.Windows.Forms.Button();
            this.btnDocFinal = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnPropuesta = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-11, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "ESTUDIANTES";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Controls.Add(this.btnProrroga);
            this.groupBox1.Controls.Add(this.btnDocFinal);
            this.groupBox1.Controls.Add(this.btnEstado);
            this.groupBox1.Controls.Add(this.btnPropuesta);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(13, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(226, 302);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnProrroga
            // 
            this.btnProrroga.BackColor = System.Drawing.Color.Goldenrod;
            this.btnProrroga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProrroga.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProrroga.Location = new System.Drawing.Point(8, 96);
            this.btnProrroga.Margin = new System.Windows.Forms.Padding(4);
            this.btnProrroga.Name = "btnProrroga";
            this.btnProrroga.Size = new System.Drawing.Size(204, 41);
            this.btnProrroga.TabIndex = 4;
            this.btnProrroga.Text = "Prorroga";
            this.btnProrroga.UseVisualStyleBackColor = false;
            this.btnProrroga.Click += new System.EventHandler(this.btnProrroga_Click);
            // 
            // btnDocFinal
            // 
            this.btnDocFinal.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDocFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocFinal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDocFinal.Location = new System.Drawing.Point(8, 155);
            this.btnDocFinal.Margin = new System.Windows.Forms.Padding(4);
            this.btnDocFinal.Name = "btnDocFinal";
            this.btnDocFinal.Size = new System.Drawing.Size(204, 41);
            this.btnDocFinal.TabIndex = 3;
            this.btnDocFinal.Text = "Documento Final";
            this.btnDocFinal.UseVisualStyleBackColor = false;
            this.btnDocFinal.Click += new System.EventHandler(this.btnDocFinal_Click);
            // 
            // btnEstado
            // 
            this.btnEstado.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEstado.Location = new System.Drawing.Point(8, 219);
            this.btnEstado.Margin = new System.Windows.Forms.Padding(4);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(204, 41);
            this.btnEstado.TabIndex = 2;
            this.btnEstado.Text = "Estado";
            this.btnEstado.UseVisualStyleBackColor = false;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // btnPropuesta
            // 
            this.btnPropuesta.BackColor = System.Drawing.Color.Goldenrod;
            this.btnPropuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPropuesta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPropuesta.Location = new System.Drawing.Point(8, 30);
            this.btnPropuesta.Margin = new System.Windows.Forms.Padding(4);
            this.btnPropuesta.Name = "btnPropuesta";
            this.btnPropuesta.Size = new System.Drawing.Size(204, 41);
            this.btnPropuesta.TabIndex = 1;
            this.btnPropuesta.Text = "Propuesta";
            this.btnPropuesta.UseVisualStyleBackColor = false;
            this.btnPropuesta.Click += new System.EventHandler(this.btnPropuesta_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Location = new System.Drawing.Point(257, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1040, 738);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // EstudiantePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1256, 656);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EstudiantePrincipal";
            this.Text = "Estudiante";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProrroga;
        private System.Windows.Forms.Button btnDocFinal;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Button btnPropuesta;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}