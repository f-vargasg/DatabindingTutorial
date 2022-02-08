using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabindingTutorial.WinformUI
{
    public partial class Form2 : Form
    {

        BindingSource bsA;
        BindingSource bsP;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(BindingSource p1, BindingSource p2)
        {
            this.bsA = p1;
            this.bsP = p2;
            InitializeComponent();
        }

        private void txtAirplaneFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bsA.Filter = txtAirplaneFilter.Text;
                txtAirplaneFilter.BackColor = SystemColors.Window;
            }
            catch (InvalidExpressionException)
            {
                txtAirplaneFilter.BackColor = Color.Pink;
            }
        }

        private void txtPassengerFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bsP.Filter = txtPassengerFilter.Text;
                txtPassengerFilter.BackColor = SystemColors.Window;
            }
            catch (InvalidExpressionException)
            {
                txtPassengerFilter.BackColor = Color.Pink;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            grid.DataSource = bsA;
            grid.AutoGenerateColumns = true;
            lstPassengers.DataSource = bsP;
            lstPassengers.DisplayMember = "Name";


        }
    }
}
