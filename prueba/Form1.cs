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
            /*ConnectionClass.ClassDB class1 = new ConnectionClass.ClassDB();

            DataSet dts;
            dts = class1.portaTaula("UserTypes");

            dataGridView1.DataSource = dts.Tables[0];
            //dataGridView1.DataSource = dts;
            //dataGridView1.DataMember = "UserTypes";*/
            this.userTypesTableAdapter.Fill(this.badgesDataSet.UserTypes);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'badgesDataSet.UserTypes' table. You can move, or remove it, as needed.
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.userTypesTableAdapter.Update(this.badgesDataSet.UserTypes);
        }
    }
}
