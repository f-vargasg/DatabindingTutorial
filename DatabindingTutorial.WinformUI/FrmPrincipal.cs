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
        BindingSource bsA = new BindingSource(); // Airplanes
        BindingSource bsP = new BindingSource(); // Passengers


        public FrmPrincipal()
        {
            InitializeComponent();
        }

        Airplane a = new Airplane("Boeing 747", 800);

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // Create DataSet and connect it to the BindingSources  //**
            DataSet ds = CreateAirplaneSchema();                    //** 
            DataTable airplanes = ds.Tables["Airplane"];            //** 
            DataTable passengers = ds.Tables["Passenger"];          //** 
            bsA.DataSource = ds;                                    //** 
            bsP.DataSource = ds;                                    //** 
            bsA.DataMember = airplanes.TableName;                   //** 
            bsP.DataMember = passengers.TableName;                  //** 

            // Create some example data in the DataSet.             //** 
            DataRow a1, a2, a3;                                     //** 
            a1 = airplanes.Rows.Add(null, "Boeing 747", 800);       //** 
            a2 = airplanes.Rows.Add(null, "Airbus A380", 1023);     //** 
            a3 = airplanes.Rows.Add(null, "Cessna 162", 67);        //** 
            passengers.Rows.Add(null, a1["ID"], "Joe Shmuck");      //** 
            passengers.Rows.Add(null, a1["ID"], "Jack B. Nimble");  //** 
            passengers.Rows.Add(null, a1["ID"], "Jib Jab");         //** 
            passengers.Rows.Add(null, a2["ID"], "Jackie Tyler");    //** 
            passengers.Rows.Add(null, a2["ID"], "Jane Doe");        //** 
            passengers.Rows.Add(null, a3["ID"], "John Smith");      //** 

            // Set up data binding for the parent Airplanes
            grid.DataSource = bsA;
            grid.AutoGenerateColumns = true;
            txtModel.DataBindings.Add("Text", bsA, "Model");

            // Set up data binding for the child Passengers
            bsP.DataSource = bsA; // chaining bsP to bsA
            bsP.DataMember = "Airplane_Passengers";                 //** 
            lstPassengers.DataSource = bsP;
            lstPassengers.DisplayMember = "Name";
            txtName.DataBindings.Add("Text", bsP, "Name");

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

        DataSet CreateAirplaneSchema()
        {
            DataSet ds = new DataSet();

            // Create Airplane table
            DataTable airplanes = ds.Tables.Add("Airplane");
            DataColumn a_id = airplanes.Columns.Add("ID", typeof(int));
            airplanes.Columns.Add("Model", typeof(string));
            airplanes.Columns.Add("FuelLeftKg", typeof(int));
            a_id.AutoIncrement = true;
            a_id.AutoIncrementSeed = 1;
            a_id.AutoIncrementStep = 1;

            // Create Passengers table
            DataTable passengers = ds.Tables.Add("Passenger");
            DataColumn p_id = passengers.Columns.Add("ID", typeof(int));
            passengers.Columns.Add("AirplaneID", typeof(int));
            passengers.Columns.Add("Name", typeof(string));
            p_id.AutoIncrement = true;
            p_id.AutoIncrementSeed = 1;
            p_id.AutoIncrementStep = 1;

            // Create parent-child relationship
            DataRelation relation = ds.Relations.Add("Airplane_Passengers",
                airplanes.Columns["ID"],
                passengers.Columns["AirplaneID"], true);

            return ds;
        }
    }
}
