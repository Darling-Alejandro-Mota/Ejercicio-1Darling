namespace Ejercicio_1Darling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Motrar_Click(object sender, EventArgs e)
        {
            string datosCompletos = $"{txt_Nombre.Text}, {txt_Apellido.Text}, {txt_Matricula.Text}, {txt_Edad.Text}";
            txt_Datos.Text = datosCompletos;

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Nombre.Clear();
            txt_Apellido.Clear();
            txt_Edad.Clear();
            txt_Matricula.Clear();
            txt_Carrera.Clear();
            txt_Datos.Clear();

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
