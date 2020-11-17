namespace Capa_Presentacion
{
    partial class Estudiantes_Registrados
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnbuscarestudiantesregistrados = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombre_estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnagregar_nuevo_estudiante = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(239, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estudiantes Registrados";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(436, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 31);
            this.textBox1.TabIndex = 1;
            // 
            // btnbuscarestudiantesregistrados
            // 
            this.btnbuscarestudiantesregistrados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(202)))), ((int)(((byte)(167)))));
            this.btnbuscarestudiantesregistrados.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnbuscarestudiantesregistrados.Location = new System.Drawing.Point(481, 163);
            this.btnbuscarestudiantesregistrados.Name = "btnbuscarestudiantesregistrados";
            this.btnbuscarestudiantesregistrados.Size = new System.Drawing.Size(99, 40);
            this.btnbuscarestudiantesregistrados.TabIndex = 2;
            this.btnbuscarestudiantesregistrados.Text = "Buscar";
            this.btnbuscarestudiantesregistrados.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(396, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Matricula del Estudiante";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(114)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre_estudiante,
            this.apellido,
            this.cedula,
            this.matricula,
            this.direccion,
            this.telefono});
            this.dataGridView1.Location = new System.Drawing.Point(12, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1056, 303);
            this.dataGridView1.TabIndex = 4;
            // 
            // nombre_estudiante
            // 
            this.nombre_estudiante.FillWeight = 200F;
            this.nombre_estudiante.HeaderText = "Nombre del Estudiante";
            this.nombre_estudiante.MinimumWidth = 50;
            this.nombre_estudiante.Name = "nombre_estudiante";
            this.nombre_estudiante.Width = 175;
            // 
            // apellido
            // 
            this.apellido.FillWeight = 200F;
            this.apellido.HeaderText = "Apellido";
            this.apellido.MinimumWidth = 50;
            this.apellido.Name = "apellido";
            this.apellido.Width = 175;
            // 
            // cedula
            // 
            this.cedula.FillWeight = 200F;
            this.cedula.HeaderText = "Cedula";
            this.cedula.MinimumWidth = 50;
            this.cedula.Name = "cedula";
            this.cedula.Width = 175;
            // 
            // matricula
            // 
            this.matricula.FillWeight = 200F;
            this.matricula.HeaderText = "Matricula";
            this.matricula.MinimumWidth = 50;
            this.matricula.Name = "matricula";
            this.matricula.Width = 175;
            // 
            // direccion
            // 
            this.direccion.FillWeight = 200F;
            this.direccion.HeaderText = "Direccion";
            this.direccion.MinimumWidth = 50;
            this.direccion.Name = "direccion";
            this.direccion.Width = 175;
            // 
            // telefono
            // 
            this.telefono.FillWeight = 200F;
            this.telefono.HeaderText = "Telefono";
            this.telefono.MinimumWidth = 50;
            this.telefono.Name = "telefono";
            this.telefono.Width = 135;
            // 
            // btnagregar_nuevo_estudiante
            // 
            this.btnagregar_nuevo_estudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(202)))), ((int)(((byte)(167)))));
            this.btnagregar_nuevo_estudiante.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnagregar_nuevo_estudiante.Location = new System.Drawing.Point(436, 540);
            this.btnagregar_nuevo_estudiante.Name = "btnagregar_nuevo_estudiante";
            this.btnagregar_nuevo_estudiante.Size = new System.Drawing.Size(190, 44);
            this.btnagregar_nuevo_estudiante.TabIndex = 5;
            this.btnagregar_nuevo_estudiante.Text = "Agregar Nuevo";
            this.btnagregar_nuevo_estudiante.UseVisualStyleBackColor = false;
            // 
            // Estudiantes_Registrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.btnagregar_nuevo_estudiante);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnbuscarestudiantesregistrados);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estudiantes_Registrados";
            this.Text = "Estudiantes_Registrados";
            this.Load += new System.EventHandler(this.Estudiantes_Registrados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnbuscarestudiantesregistrados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.Button btnagregar_nuevo_estudiante;
    }
}