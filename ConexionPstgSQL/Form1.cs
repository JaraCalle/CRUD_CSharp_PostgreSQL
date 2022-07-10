namespace ConexionPstgSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabla_datos.DataSource = conectandose.Consultar();
        }
        ConexionPostgrsql conectandose = new ConexionPostgrsql();
        private void btn_conectar_Click(object sender, EventArgs e)
        {
            try
            {
                conectandose.Conectar();
            }catch
            {
                MessageBox.Show("Ya estas conectado");
            }
            
        }

        private void btn_desconectar_Click_Click(object sender, EventArgs e)
        {
            conectandose.Desconectar();
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            // Mostrar la consulta en el datagrid View
            string nom_Consulta = txBox_consulta.Text;
            if (nom_Consulta == "")
            {
                tabla_datos.DataSource = conectandose.Consultar();
            }
            else
            {
                tabla_datos.DataSource = conectandose.Consultar(nom_Consulta);
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            // Agregar fila a la tabla
            try
            {
                conectandose.Agregar(Convert.ToInt32(txtBox_id.Text), txtBox_nombre.Text, txtBox_apellido.Text, txtBox_correo.Text, Convert.ToDouble(txtBox_colegiatura.Text));
            } catch
            {
                MessageBox.Show("Algo ocurrio, vuelva a intentarlo");
            }
            

            // Actualizar el datagrid View
            tabla_datos.DataSource = conectandose.Consultar();

            // Limpiar los txtBox
            txtBox_id.Text = "";
            txtBox_nombre.Text = "";
            txtBox_apellido.Text = "";
            txtBox_correo.Text = "";
            txtBox_colegiatura.Text = "";
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            // Eliminar fila de la base de datos
            conectandose.Eliminar(txtBox_nombreEliminar.Text);

            // Actualizar el datagrid View
            tabla_datos.DataSource = conectandose.Consultar();

            // Limpiar los txtBox
            txtBox_nombreEliminar.Text = "";
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                conectandose.Actualizar(txtBox_nombreActualizar.Text, Convert.ToInt32(txtBox_id.Text), txtBox_nombre.Text, txtBox_apellido.Text, txtBox_correo.Text, Convert.ToDouble(txtBox_colegiatura.Text));
            }
            catch
            {
                MessageBox.Show("Algo ocurrio, vuelva a intentarlo");
            }

            // Actualizar el datagrid View
            tabla_datos.DataSource = conectandose.Consultar();

            // Limpiar los txtBox
            txtBox_id.Text = "";
            txtBox_nombre.Text = "";
            txtBox_apellido.Text = "";
            txtBox_correo.Text = "";
            txtBox_colegiatura.Text = "";
            txtBox_nombreActualizar.Text = "";
        }
    }
}