using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
    
namespace CRUD_ESTUDIANTE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("Conexion exitosa");

            dataGridView1.DataSource = llenar_grid();
        }

        public DataTable llenar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM personas ";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_codigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_nombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_apellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_telefono.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_direccion.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_email.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt_fecha_nacimiento.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txt_observaciones.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "INSERT INTO personas (Id,Nombres,Apellidos,Telefono,Direccion,Email,FechaNacimiento,Observaciones)" +
                "VALUES(@Id,@Nombres,@Apellidos,@Telefono,@Direccion,@Email,@FechaNacimiento,@Observaciones)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@Id", txt_codigo.Text);
            cmd1.Parameters.AddWithValue("@Nombres", txt_nombre.Text);
            cmd1.Parameters.AddWithValue("@Apellidos", txt_apellido.Text);
            cmd1.Parameters.AddWithValue("@Telefono", txt_telefono.Text);
            cmd1.Parameters.AddWithValue("@Direccion", txt_direccion.Text);
            cmd1.Parameters.AddWithValue("@Email", txt_email.Text);
            cmd1.Parameters.AddWithValue("@FechaNacimiento", txt_fecha_nacimiento.Text);
            cmd1.Parameters.AddWithValue("@Observaciones", txt_observaciones.Text);

            cmd1.ExecuteNonQuery();

            MessageBox.Show("LOS DATOS FUERON AGREGADOS EXITOSAMENTE");

            dataGridView1.DataSource=llenar_grid();

        }

        private void button_modificar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar(); 
            string actualizar = "UPDATE personas SET Id=@Id, Nombres=@Nombres, Apellidos=@Apellidos, Telefono=@Telefono, Direccion=@Direccion, Email=@Email, FechaNacimiento=@FechaNacimiento, Observaciones=@Observaciones WHERE Id=@Id";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());

            cmd2.Parameters.AddWithValue("@Id", txt_codigo.Text);
            cmd2.Parameters.AddWithValue("@Nombres", txt_nombre.Text);
            cmd2.Parameters.AddWithValue("@Apellidos", txt_apellido.Text);
            cmd2.Parameters.AddWithValue("@Telefono", txt_telefono.Text);
            cmd2.Parameters.AddWithValue("@Direccion", txt_direccion.Text);
            cmd2.Parameters.AddWithValue("@Email", txt_email.Text);
            cmd2.Parameters.AddWithValue("@FechaNacimiento", txt_fecha_nacimiento.Text);
            cmd2.Parameters.AddWithValue("@Observaciones", txt_observaciones.Text);

            cmd2.ExecuteNonQuery();

            MessageBox.Show("LOS DATOS FUERON ACTUALIZADOS CORRECTAMENTE");
            dataGridView1.DataSource = llenar_grid();



        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string eliminar = "DELETE FROM personas WHERE Id=@Id";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
            cmd3.Parameters.AddWithValue("@Id", txt_codigo.Text);

            cmd3.ExecuteNonQuery();

            MessageBox.Show("LOS DATOS FUERON ELIMINADOS CON EXITO");

            dataGridView1.DataSource = llenar_grid();
        }

        private void button_nuevo_Click(object sender, EventArgs e)
        {
            txt_codigo.Clear();
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_telefono.Clear();
            txt_direccion.Clear();
            txt_email.Clear();
            txt_fecha_nacimiento.Clear();
            txt_observaciones.Clear();
            txt_codigo.Focus();
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string consulta = "SELECT * FROM personas WHERE Id=@Id ";
            SqlCommand cmd4 = new SqlCommand(consulta, Conexion.Conectar());
            cmd4.Parameters.AddWithValue("@Id", txt_buscar.Text);

            cmd4.ExecuteNonQuery();


            dataGridView1.DataSource = llenar_grid();



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
