using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabindingTutorial.Example4
{
    public partial class FrmPrincipal : Form
    {
        BindingSource bsDepts;
        BindingSource bsEmps;
        List<Dept> depts;
        public FrmPrincipal()
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

            var bindingList = new BindingList<Dept>(depts);
            bsDepts = new BindingSource(bindingList, null);
            dgrDepts.DataSource = bsDepts;
            dgrDepts.AutoGenerateColumns = true;

        }
    }
}
