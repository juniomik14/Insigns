using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectionClass;


namespace MantenimientoTest
{
    public partial class Form1 : Form
    {

        DataSet dts;
        SdsTextBox tb;

        public Form1()
        {

            InitializeComponent();
            InicializarCosas();
        }

        private void InicializarCosas()
        {
            ClassDB db = new ClassDB();
            tb = new SdsTextBox();


          

            dts = db.portaPerConsulta("select * from UserTypes");

            RellenarDataGrid(dts);
        }

        private void RellenarDataGrid(DataSet dataset)
        {

            dataGridView1.DataSource = dataset.Tables[0];

            BindDades();
        }

        private void BindDades()
        {
            foreach (Control c in this.Controls)
            {
                if (c is SdsTextBox)
                {
                    c.DataBindings.Clear();
                   
                    c.DataBindings.Add("Text", dts.Tables[0], "DescType");
                    c.DataBindings.Add("Text", dts.Tables[0], "DescType");
                    c.DataBindings.Add("Text", dts.Tables[0], "DescType");
                    tb.Validated += new EventHandler(vali);
                }
                dataGridView1.DataSource = dts.Tables[0];
            }
        }

        private void vali(object sender, EventArgs e)
        {
            DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }
    }
}
