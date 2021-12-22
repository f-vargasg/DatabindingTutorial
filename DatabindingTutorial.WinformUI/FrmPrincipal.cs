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

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            bs.DataSource = typeof(Airplane);

            bs.Add(new Airplane("Boeing 747", 800));
            // bs.Add(new Airplane("Airbus A380", 1023));
            bs.DataSource = new Airplane("Airbus A380", 1023);
            bs.Add(new Airplane("Cessna 162", 67));

            grid.DataSource = bs;
            grid.AutoGenerateColumns = true;
            txtModel.DataBindings.Add("Text", bs, "Model");

            bs.AddingNew += (s, ev) => Debug.WriteLine("AddingNew");
            bs.BindingComplete += (s, ev) => Debug.WriteLine("BindingComplete");
            bs.CurrentChanged += (s, ev) => Debug.WriteLine("CurrentChanged");
            bs.CurrentItemChanged += (s, ev) => Debug.WriteLine("CurrentItemChanged");
            bs.DataError += (s, ev) => Debug.WriteLine("DataError");
            bs.DataMemberChanged += (s, ev) => Debug.WriteLine("DataMemberChanged");
            bs.DataSourceChanged += (s, ev) => Debug.WriteLine("DataSourceChanged");
            bs.ListChanged += (s, ev) => Debug.WriteLine("ListChanged");
            bs.PositionChanged += (s, ev) => Debug.WriteLine("PositionChanged");

        }
    }
}
