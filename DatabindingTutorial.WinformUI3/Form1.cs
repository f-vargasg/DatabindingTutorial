using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabindingTutorial.WinformUI3
{
    public partial class Form1 : Form
    {
        List<Persona> personas = new List<Persona>();
        BindingSource bs = new BindingSource();
        public Form1()
        {

            InitializeComponent();

            //personaBindingSource.DataSource = new Persona()
            //{
            //    Nombre = "Nombre1",
            //    Apellidos = "Apellido1"
            //};
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (bs.DataSource as Persona).Guardar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bs.DataSource = typeof(Persona);
            bs.Add(new Persona("Persona1", "Apellido1"));
            bs.Add(new Persona("Persona2", "Apellido2"));
            bs.Add(new Persona("Persona3", "Apellido3"));
            grid.DataSource = bs;
            grid.AutoGenerateColumns = true;
            textBox1.DataBindings.Add("Text", bs, "Nombre");
            textBox2.DataBindings.Add("Text", bs, "Apellidos");


        }
    }
}
