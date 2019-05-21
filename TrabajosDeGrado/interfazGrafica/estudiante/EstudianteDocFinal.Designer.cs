namespace TrabajosDeGrado
{
    partial class EstudianteDocFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstudianteDocFinal));
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btnSubir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSemestre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ofdRuta = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(466, 18);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            this.txtCedula.Size = new System.Drawing.Size(118, 22);
            this.txtCedula.TabIndex = 26;
            // 
            // btnSubir
            // 
            this.btnSubir.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSubir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSubir.Location = new System.Drawing.Point(320, 85);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(136, 33);
            this.btnSubir.TabIndex = 25;
            this.btnSubir.Text = "Subir archivo";
            this.btnSubir.UseVisualStyleBackColor = false;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(62, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 31);
            this.label1.TabIndex = 28;
            this.label1.Text = "ENTREGA DOCUMENTO FINAL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrabajosDeGrado.Properties.Resources.uniibague_300x259;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Controls.Add(this.btnEnviar);
            this.groupBox2.Controls.Add(this.txtRuta);
            this.groupBox2.Controls.Add(this.txtCedula);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnSubir);
            this.groupBox2.Controls.Add(this.txtTelefono);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSemestre);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtCod);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox2.Location = new System.Drawing.Point(1, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(606, 149);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del estudiante";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEnviar.Location = new System.Drawing.Point(466, 85);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(118, 33);
            this.btnEnviar.TabIndex = 27;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.Location = new System.Drawing.Point(70, 90);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.ReadOnly = true;
            this.txtRuta.Size = new System.Drawing.Size(221, 22);
            this.txtRuta.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Ruta:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(466, 43);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(118, 22);
            this.txtTelefono.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(382, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Teléfono:";
            // 
            // txtSemestre
            // 
            this.txtSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSemestre.Location = new System.Drawing.Point(82, 48);
            this.txtSemestre.Name = "txtSemestre";
            this.txtSemestre.ReadOnly = true;
            this.txtSemestre.Size = new System.Drawing.Size(41, 22);
            this.txtSemestre.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(129, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Código:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Semestre:";
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(190, 48);
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(101, 22);
            this.txtCod.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(82, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(209, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(382, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "Cédula:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Nombre:";
            // 
            // ofdRuta
            // 
            this.ofdRuta.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(70, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(559, 60);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Location = new System.Drawing.Point(1, 59);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(628, 147);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            // 
            // EstudianteDocFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 353);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EstudianteDocFinal";
            this.Text = "Estudiante";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSemestre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.OpenFileDialog ofdRuta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEnviar;
    }
}