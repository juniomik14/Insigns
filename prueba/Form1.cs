using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionClass.Class1 class1 = new ConnectionClass.Class1();

            DataSet dts;
            dts = class1.portaTaula("UserTypes");

            dataGridView1.DataSource = dts.Tables[0];
            //dataGridView1.DataSource = dts;
            //dataGridView1.DataMember = "UserTypes";


        }
    }
}
