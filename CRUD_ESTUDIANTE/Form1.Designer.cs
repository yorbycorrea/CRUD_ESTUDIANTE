
namespace CRUD_ESTUDIANTE
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gb_1 = new System.Windows.Forms.GroupBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_observaciones = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_observaciones = new System.Windows.Forms.Label();
            this.txt_fecha_nacimiento = new System.Windows.Forms.TextBox();
            this.lbl_fecha_nacimiento = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_buscar = new System.Windows.Forms.Button();
            this.button_nuevo = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_modificar = new System.Windows.Forms.Button();
            this.button_agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE ESTUDIANTES";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 177);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gb_1
            // 
            this.gb_1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gb_1.Controls.Add(this.txt_codigo);
            this.gb_1.Controls.Add(this.lbl_codigo);
            this.gb_1.Controls.Add(this.txt_observaciones);
            this.gb_1.Controls.Add(this.txt_email);
            this.gb_1.Controls.Add(this.txt_direccion);
            this.gb_1.Controls.Add(this.txt_telefono);
            this.gb_1.Controls.Add(this.txt_apellido);
            this.gb_1.Controls.Add(this.txt_nombre);
            this.gb_1.Controls.Add(this.lbl_observaciones);
            this.gb_1.Controls.Add(this.txt_fecha_nacimiento);
            this.gb_1.Controls.Add(this.lbl_fecha_nacimiento);
            this.gb_1.Controls.Add(this.lbl_email);
            this.gb_1.Controls.Add(this.lbl_direccion);
            this.gb_1.Controls.Add(this.lbl_telefono);
            this.gb_1.Controls.Add(this.lbl_apellido);
            this.gb_1.Controls.Add(this.lbl_nombre);
            this.gb_1.Location = new System.Drawing.Point(12, 47);
            this.gb_1.Name = "gb_1";
            this.gb_1.Size = new System.Drawing.Size(631, 228);
            this.gb_1.TabIndex = 2;
            this.gb_1.TabStop = false;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(87, 32);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(180, 20);
            this.txt_codigo.TabIndex = 14;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(9, 32);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(52, 13);
            this.lbl_codigo.TabIndex = 13;
            this.lbl_codigo.Text = "CODIGO:";
            // 
            // txt_observaciones
            // 
            this.txt_observaciones.Location = new System.Drawing.Point(419, 171);
            this.txt_observaciones.Name = "txt_observaciones";
            this.txt_observaciones.Size = new System.Drawing.Size(192, 20);
            this.txt_observaciones.TabIndex = 12;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(419, 120);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(192, 20);
            this.txt_email.TabIndex = 11;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(419, 66);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(192, 20);
            this.txt_direccion.TabIndex = 10;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(87, 167);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(180, 20);
            this.txt_telefono.TabIndex = 9;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(87, 120);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(180, 20);
            this.txt_apellido.TabIndex = 8;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(87, 76);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(180, 20);
            this.txt_nombre.TabIndex = 7;
            // 
            // lbl_observaciones
            // 
            this.lbl_observaciones.AutoSize = true;
            this.lbl_observaciones.Location = new System.Drawing.Point(273, 174);
            this.lbl_observaciones.Name = "lbl_observaciones";
            this.lbl_observaciones.Size = new System.Drawing.Size(101, 13);
            this.lbl_observaciones.TabIndex = 6;
            this.lbl_observaciones.Text = "OBSERVACIONES:";
            // 
            // txt_fecha_nacimiento
            // 
            this.txt_fecha_nacimiento.Location = new System.Drawing.Point(419, 25);
            this.txt_fecha_nacimiento.Name = "txt_fecha_nacimiento";
            this.txt_fecha_nacimiento.Size = new System.Drawing.Size(192, 20);
            this.txt_fecha_nacimiento.TabIndex = 10;
            // 
            // lbl_fecha_nacimiento
            // 
            this.lbl_fecha_nacimiento.AutoSize = true;
            this.lbl_fecha_nacimiento.Location = new System.Drawing.Point(273, 32);
            this.lbl_fecha_nacimiento.Name = "lbl_fecha_nacimiento";
            this.lbl_fecha_nacimiento.Size = new System.Drawing.Size(133, 13);
            this.lbl_fecha_nacimiento.TabIndex = 5;
            this.lbl_fecha_nacimiento.Text = "FECHA DE NACIMIENTO:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(273, 123);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(42, 13);
            this.lbl_email.TabIndex = 4;
            this.lbl_email.Text = "EMAIL:";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(273, 79);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(69, 13);
            this.lbl_direccion.TabIndex = 3;
            this.lbl_direccion.Text = "DIRECCION:";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(6, 174);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(67, 13);
            this.lbl_telefono.TabIndex = 2;
            this.lbl_telefono.Text = "TELEFONO:";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(6, 127);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(69, 13);
            this.lbl_apellido.TabIndex = 1;
            this.lbl_apellido.Text = "APELLIDOS:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(6, 79);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(67, 13);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "NOMBRES: ";
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Location = new System.Drawing.Point(21, 287);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(54, 13);
            this.lbl_buscar.TabIndex = 17;
            this.lbl_buscar.Text = "BUSCAR:";
            this.lbl_buscar.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(81, 284);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(326, 20);
            this.txt_buscar.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CRUD_ESTUDIANTE.Properties.Resources.icons8_student_100;
            this.pictureBox1.Location = new System.Drawing.Point(649, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 123);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button_buscar
            // 
            this.button_buscar.Image = global::CRUD_ESTUDIANTE.Properties.Resources.icons8_find_user_male_30;
            this.button_buscar.Location = new System.Drawing.Point(424, 281);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(49, 34);
            this.button_buscar.TabIndex = 16;
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // button_nuevo
            // 
            this.button_nuevo.Image = global::CRUD_ESTUDIANTE.Properties.Resources.icons8_female_user_update_30;
            this.button_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_nuevo.Location = new System.Drawing.Point(613, 508);
            this.button_nuevo.Name = "button_nuevo";
            this.button_nuevo.Size = new System.Drawing.Size(88, 34);
            this.button_nuevo.TabIndex = 14;
            this.button_nuevo.Text = "NUEVO";
            this.button_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nuevo.UseVisualStyleBackColor = true;
            this.button_nuevo.Click += new System.EventHandler(this.button_nuevo_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.Image = global::CRUD_ESTUDIANTE.Properties.Resources.icons8_denied_30;
            this.button_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_eliminar.Location = new System.Drawing.Point(411, 508);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(88, 34);
            this.button_eliminar.TabIndex = 13;
            this.button_eliminar.Text = "ELIMINAR";
            this.button_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button_modificar
            // 
            this.button_modificar.Image = global::CRUD_ESTUDIANTE.Properties.Resources.icons8_registration_30;
            this.button_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_modificar.Location = new System.Drawing.Point(217, 508);
            this.button_modificar.Name = "button_modificar";
            this.button_modificar.Size = new System.Drawing.Size(98, 34);
            this.button_modificar.TabIndex = 12;
            this.button_modificar.Text = "MODIFICAR";
            this.button_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_modificar.UseVisualStyleBackColor = true;
            this.button_modificar.Click += new System.EventHandler(this.button_modificar_Click);
            // 
            // button_agregar
            // 
            this.button_agregar.Image = global::CRUD_ESTUDIANTE.Properties.Resources.icons8_add_user_male_30;
            this.button_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_agregar.Location = new System.Drawing.Point(24, 504);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(102, 38);
            this.button_agregar.TabIndex = 11;
            this.button_agregar.Text = "AGREGAR";
            this.button_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_agregar.UseVisualStyleBackColor = true;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(762, 543);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.button_buscar);
            this.Controls.Add(this.button_nuevo);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.button_modificar);
            this.Controls.Add(this.button_agregar);
            this.Controls.Add(this.gb_1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_1.ResumeLayout(false);
            this.gb_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gb_1;
        private System.Windows.Forms.TextBox txt_observaciones;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_observaciones;
        private System.Windows.Forms.Label lbl_fecha_nacimiento;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_fecha_nacimiento;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.Button button_modificar;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_nuevo;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

