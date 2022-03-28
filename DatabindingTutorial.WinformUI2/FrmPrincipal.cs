using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabindingTutorial.WinformUI2
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            Persona p1 = new Persona()
            {
                Nombre = "Nombre1",
                Apellidos = "Ape1 Ape2"
            };
            textBox1.Text = p1.Nombre;
            textBox2.Text = p1.Apellidos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona p2 = new Persona();
            p2.Nombre = textBox1.Text;
            p2.Apellidos = textBox2.Text;
            p2.Guardar();
        }
    }
}
