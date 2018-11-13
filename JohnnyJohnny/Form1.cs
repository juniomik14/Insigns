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

namespace JohnnyJohnny
{
    public partial class Form1 : Form
    {        
        ClassDB dab = new ClassDB();
        public Form1()
        {
            InitializeComponent();
            dab.connectBD();
            DataSet ds = new DataSet();
            ds = dab.portaTaula("UserTypes");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //string nomtaula = "UserTypes";
            //DataSet ds = new DataSet();
            //DataTable dt = new DataTable();
            //dt = (DataTable)(dataGridView1.DataSource);
            //ds.Tables.Add(dt);
            //dab.Actualitzar(ds, nomtaula);
            //MessageBox.Show("sa actualitzat la informacio del datagrid a la base da dades");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!txtCodeType.Text.Equals("") && !txtDescType.Text.Equals("") && !txtLvlAccess.Text.Equals("") && !txtUserType.Text.Equals(""))
            {
                //funcio de neteja
                foreach (Control ctr in this.Controls)
                {
                    if (ctr.GetType() == typeof(TextBox))
                    {
                        ctr.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("siusplau ompliu tots els camps");
            }
        }
    }
}

// new row "" (ha fet cometes amb les mans)         