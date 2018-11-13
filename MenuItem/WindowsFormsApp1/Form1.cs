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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int cont = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private string _dll;

        public string dll
        {
            get { return _dll; }
            set { _dll = value; }
        }


        private string _hola;

        public string hola
        {
            get { return _hola; }
            set { _hola = value; }
        }

        private string _culdolla;

        public string culdolla
        {
            get { return _culdolla; }
            set { _culdolla = value; }
        }


        private void button1_Click(object sender, EventArgs e)
        {
 
                menuStrip1.Items.Clear();

                ConnectionClass.ClassDB db;

                db = new ConnectionClass.ClassDB();

                DataSet dts;

                dts = db.portaTaula("Menu");

                dataGridView1.DataSource = dts.Tables[0];

                foreach (DataRow dr in dts.Tables[0].Rows)
                {
                    var fruitToolStripMenuItem = new bcMenuItem.SdSMenuItem();

                    fruitToolStripMenuItem.Text = dr["textmenu"].ToString();
                    fruitToolStripMenuItem.Classe = dr["DLL"].ToString();
                    fruitToolStripMenuItem.Form = dr["Form"].ToString();
                
                
                    menuStrip1.Items.Add(fruitToolStripMenuItem);
                    
                }
        }

    }
}
