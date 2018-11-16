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

namespace Johnny_Johnny
{
    public partial class Form1 : Form
    {
        ClassDB dab = new ClassDB();
        DataSet ds = new DataSet();
        
            DataTable dt = new DataTable();
        
        public Form1()
        {
            InitializeComponent();
            ds = dab.portaTaula("UserTypes");
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable) dataGridView1.DataSource;
            //textBox1.DataBindings.Clear();
            //textBox2.DataBindings.Clear();
            //textBox3.DataBindings.Clear();
            //textBox4.DataBindings.Clear();
            if (!textBox1.Text.Equals("") && !textBox2.Text.Equals("") && !textBox3.Text.Equals("") && !textBox4.Text.Equals(""))
            {
                //textBox1.DataBindings.Add("Text", dt, "IdUserType");
                //textBox2.DataBindings.Add("Text", dt, "CodeType");
                //textBox3.DataBindings.Add("Text", dt, "DescType");
                //textBox4.DataBindings.Add("Text", dt, "LevelAcces");
                DataRow row = dt.NewRow();
                row[0] = textBox1.Text;
                row[1] = textBox2.Text;
                row[2] = textBox3.Text;
                row[3] = textBox4.Text;
                dt.Rows.Add(row);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            dataGridView1.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string taula = "UserTypes";
            dab.Actualitzar(ds, taula);
        }
    }
}
