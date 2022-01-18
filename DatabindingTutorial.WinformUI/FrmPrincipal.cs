using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabindingTutorial.WinformUI
{
    public partial class FrmPrincipal : Form
    {
        BindingSource bs = new BindingSource();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        Airplane a = new Airplane("Boeing 747", 800);

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            a.Passengers.Add(new Passenger("Joe Shmuck"));
            a.Passengers.Add(new Passenger("Jack B. Nimble"));
            a.Passengers.Add(new Passenger("Jane Doe"));
            a.Passengers.Add(new Passenger("John Smith"));

            grid.DataSource = a;
            grid.DataMember = "Passengers";
            grid.AutoGenerateColumns = true;
            txtModel.DataBindings.Add("Text", a, "Model");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = string.Format("The last passenger on this {0} is named {1}. Add another passenger?",
                                        a.Model, a.Passengers[a.Passengers.Count - 1].Name);
            if (MessageBox.Show(msg, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                a.Passengers.Add(new Passenger("New Passenger"));
                grid.ResetBindings();
            }
        }
    }
}
