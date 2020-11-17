namespace Capa_Presentacion
{
    partial class Historial_Prestamos
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
            this.lblhistorial_prestamos = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo_libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_prestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnnuevoprestamo = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblhistorial_prestamos
            // 
            this.lblhistorial_prestamos.AutoSize = true;
            this.lblhistorial_prestamos.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold);
            this.lblhistorial_prestamos.Location = new System.Drawing.Point(269, 22);
            this.lblhistorial_prestamos.Name = "lblhistorial_prestamos";
            this.lblhistorial_prestamos.Size = new System.Drawing.Size(546, 58);
            this.lblhistorial_prestamos.TabIndex = 0;
            this.lblhistorial_prestamos.Text = "Historial de Prestamos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(202)))), ((int)(((byte)(167)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(204, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(174, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 31);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(148, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Matricula Estudiante";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(202)))), ((int)(((byte)(167)))));
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(723, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(695, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 31);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(709, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titulo del Libro";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(114)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.estudiante,
            this.matricula,
            this.titulo_libro,
            this.autor,
            this.fecha_prestamo,
            this.estado});
            this.dataGridView1.Location = new System.Drawing.Point(12, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1056, 273);
            this.dataGridView1.TabIndex = 4;
            // 
            // estudiante
            // 
            this.estudiante.FillWeight = 200F;
            this.estudiante.Frozen = true;
            this.estudiante.HeaderText = "Estudiante";
            this.estudiante.MinimumWidth = 50;
            this.estudiante.Name = "estudiante";
            this.estudiante.Width = 175;
            // 
            // matricula
            // 
            this.matricula.FillWeight = 200F;
            this.matricula.Frozen = true;
            this.matricula.HeaderText = "Matricula";
            this.matricula.MinimumWidth = 50;
            this.matricula.Name = "matricula";
            this.matricula.Width = 175;
            // 
            // titulo_libro
            // 
            this.titulo_libro.FillWeight = 200F;
            this.titulo_libro.Frozen = true;
            this.titulo_libro.HeaderText = "Titulo del Libro";
            this.titulo_libro.MinimumWidth = 50;
            this.titulo_libro.Name = "titulo_libro";
            this.titulo_libro.Width = 175;
            // 
            // autor
            // 
            this.autor.FillWeight = 200F;
            this.autor.HeaderText = "Autor";
            this.autor.MinimumWidth = 50;
            this.autor.Name = "autor";
            this.autor.Width = 175;
            // 
            // fecha_prestamo
            // 
            this.fecha_prestamo.FillWeight = 200F;
            this.fecha_prestamo.HeaderText = "Fecha Prestamo";
            this.fecha_prestamo.MinimumWidth = 50;
            this.fecha_prestamo.Name = "fecha_prestamo";
            this.fecha_prestamo.Width = 175;
            // 
            // estado
            // 
            this.estado.FillWeight = 200F;
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 50;
            this.estado.Name = "estado";
            this.estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estado.Width = 135;
            // 
            // btnnuevoprestamo
            // 
            this.btnnuevoprestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(202)))), ((int)(((byte)(167)))));
            this.btnnuevoprestamo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnnuevoprestamo.Location = new System.Drawing.Point(423, 528);
            this.btnnuevoprestamo.Name = "btnnuevoprestamo";
            this.btnnuevoprestamo.Size = new System.Drawing.Size(194, 45);
            this.btnnuevoprestamo.TabIndex = 1;
            this.btnnuevoprestamo.Text = "Agregar Nuevo";
            this.btnnuevoprestamo.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox3.Location = new System.Drawing.Point(115, 553);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(166, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox4.Location = new System.Drawing.Point(781, 553);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(166, 20);
            this.textBox4.TabIndex = 2;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(96, 517);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Libros mas buscados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(719, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estudiantes que mas solicitan";
            // 
            // Historial_Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnnuevoprestamo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblhistorial_prestamos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Historial_Prestamos";
            this.Text = "Historial_Prestamos";
            this.Load += new System.EventHandler(this.Historial_Prestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhistorial_prestamos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo_libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_prestamo;
        private System.Windows.Forms.DataGridViewComboBoxColumn estado;
        private System.Windows.Forms.Button btnnuevoprestamo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}