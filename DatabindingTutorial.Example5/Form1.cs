using DatabindingTutorial.BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabindingTutorial.Example5
{
    
    public partial class Form1 : Form
    {
        BindingSource bsDept ;
        BindingSource bsEmp;
        List<Dept> depts;

        public Form1()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            depts = new List<Dept>();
            Dept dept = new Dept("Dept", "Zona1");
            dept.Emps.Add(new Emp("Emp1", "Job1", 10));
            dept.Emps.Add(new Emp("Emp2", "Job2", 30));
            dept.Emps.Add(new Emp("Emp3", "Job1", 20));
            depts.Add(dept);

            dept = new Dept("Dept2", "Zona2");
            dept.Emps.Add(new Emp("Emp4", "Job2", 10));
            dept.Emps.Add(new Emp("Emp5", "Job2", 30));
            dept.Emps.Add(new Emp("Emp6", "Job3", 20));
            depts.Add(dept);

            var BindingList = new BindingList<Dept>(depts);
            bsDept = new BindingSource(BindingList, null);
            dgrDepts.DataSource = bsDept;
            dgrDepts.AutoGenerateColumns = true;
            lstEmps.DataSource = bsDept;
            lstEmps.DisplayMember = "Emps.Name";
            txtNomDept.DataBindings.Add("Text", bsDept, "Name");

            bsEmp = new BindingSource();
            bsEmp.DataSource = bsDept;
            bsEmp.DataMember = "Emps";
            lstEmps.DataSource = bsEmp;
            lstEmps.DisplayMember = "Name";
            txtEmpName.DataBindings.Add("Text", bsEmp, "Name");


        }

        private void Form1_Load(object sender, EventArgs e)
        {





        }
    }
}
