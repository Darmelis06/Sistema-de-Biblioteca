namespace Capa_Presentacion
{
    partial class Libros_Registrados
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
            this.btnbuscarlibroregistrado = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.titulodellibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signaturatopografica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechalanzamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(284, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Libros Registrados";
            // 
            // btnbuscarlibroregistrado
            // 
            this.btnbuscarlibroregistrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(202)))), ((int)(((byte)(167)))));
            this.btnbuscarlibroregistrado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnbuscarlibroregistrado.Location = new System.Drawing.Point(464, 167);
            this.btnbuscarlibroregistrado.Name = "btnbuscarlibroregistrado";
            this.btnbuscarlibroregistrado.Size = new System.Drawing.Size(107, 43);
            this.btnbuscarlibroregistrado.TabIndex = 1;
            this.btnbuscarlibroregistrado.Text = "Buscar";
            this.btnbuscarlibroregistrado.UseVisualStyleBackColor = false;
            this.btnbuscarlibroregistrado.Click += new System.EventHandler(this.btnbuscarlibroregistrado_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(416, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 31);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(438, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Titulo del Libro";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(114)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titulodellibro,
            this.autor,
            this.editorial,
            this.signaturatopografica,
            this.genero,
            this.fechalanzamiento});
            this.dataGridView1.Location = new System.Drawing.Point(12, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1056, 305);
            this.dataGridView1.TabIndex = 3;
            // 
            // titulodellibro
            // 
            this.titulodellibro.FillWeight = 200F;
            this.titulodellibro.HeaderText = "Titulo del Libro";
            this.titulodellibro.MinimumWidth = 50;
            this.titulodellibro.Name = "titulodellibro";
            this.titulodellibro.Width = 175;
            // 
            // autor
            // 
            this.autor.FillWeight = 200F;
            this.autor.HeaderText = "Autor";
            this.autor.MinimumWidth = 50;
            this.autor.Name = "autor";
            this.autor.Width = 175;
            // 
            // editorial
            // 
            this.editorial.FillWeight = 200F;
            this.editorial.HeaderText = "Editorial";
            this.editorial.MinimumWidth = 50;
            this.editorial.Name = "editorial";
            this.editorial.Width = 175;
            // 
            // signaturatopografica
            // 
            this.signaturatopografica.FillWeight = 200F;
            this.signaturatopografica.HeaderText = "Signatura Topografica";
            this.signaturatopografica.MinimumWidth = 50;
            this.signaturatopografica.Name = "signaturatopografica";
            this.signaturatopografica.Width = 175;
            // 
            // genero
            // 
            this.genero.FillWeight = 200F;
            this.genero.HeaderText = "Genero";
            this.genero.MinimumWidth = 50;
            this.genero.Name = "genero";
            this.genero.Width = 175;
            // 
            // fechalanzamiento
            // 
            this.fechalanzamiento.FillWeight = 200F;
            this.fechalanzamiento.HeaderText = "Fecha lanzamiento";
            this.fechalanzamiento.MinimumWidth = 50;
            this.fechalanzamiento.Name = "fechalanzamiento";
            this.fechalanzamiento.Width = 135;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(202)))), ((int)(((byte)(167)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(416, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar Nuevo";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Libros_Registrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnbuscarlibroregistrado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Libros_Registrados";
            this.Text = "Libros_Registrados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbuscarlibroregistrado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulodellibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn signaturatopografica;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechalanzamiento;
        private System.Windows.Forms.Button button1;
    }
}