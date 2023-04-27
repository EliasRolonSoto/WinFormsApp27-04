using App.Core.Data;
using App.Core.Entities;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void CargarDatos()
        {
            var emails = (new EmailRepository()).Buscar(txtSearch.Text);


            listBox1.DataSource = emails;
            listBox1.ValueMember = "Asunto";




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        
    }
}