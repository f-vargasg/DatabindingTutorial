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
            // Create some example data.
            Airplane a1, a2, a3;
            bs.Add(a1 = new Airplane("Boeing 747", 800));
            bs.Add(a2 = new Airplane("Airbus A380", 1023));
            bs.Add(a3 = new Airplane("Cessna 162", 67));
            a1.Passengers.Add(new Passenger("Joe Shmuck"));
            a1.Passengers.Add(new Passenger("Jack B. Nimble"));
            a1.Passengers.Add(new Passenger("Jib Jab"));
            a2.Passengers.Add(new Passenger("Jackie Tyler"));
            a2.Passengers.Add(new Passenger("Jane Doe"));
            a3.Passengers.Add(new Passenger("John Smith"));

            // Set up data binding
            grid.DataSource = bs;
            grid.AutoGenerateColumns = true;
            lstPassengers.DataSource = bs;
            lstPassengers.DisplayMember = "Passengers.Name";
            txtModel.DataBindings.Add("Text", bs, "Model");

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
