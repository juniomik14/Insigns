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
        ClassDB db;

        public Form1()
        {

            InitializeComponent();
            InicializarCosas();
        }

        private void InicializarCosas()
        {
            db = new ClassDB();
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
            string[] columNames = new string[dts.Tables[0].Columns.Count];
            int i = 0;
            foreach (DataColumn column in dts.Tables[0].Columns)
            {
                columNames[i] = column.ColumnName;
                i++;
            }

            i = 3;
            foreach (Control c in this.Controls)
            {
                if (c is SdsTextBox)
                {
                    ((SdsTextBox)c).DataBindings.Clear();
                    ((SdsTextBox)c).DataBindings.Add("Text", dts.Tables[0], columNames[i]);
                    ((SdsTextBox)c).Validated += new EventHandler(validar);
                    i--;
                }
                dataGridView1.DataSource = dts.Tables[0];
            }
        }
        private void validar(object sender, EventArgs e)
        {
            ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            db.Actualitzar(dts, "select * from UserTypes");
        }
    }
}
