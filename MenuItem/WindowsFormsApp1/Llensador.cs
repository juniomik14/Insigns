using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bcMenuItem;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        bool _esPare;
        string _idPare;
        string _idMenu;
        DataSet dts;
        SdSMenuItem fruitToolStripMenuItem;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            menuStrip1.Items.Clear();
            ConnectionClass.ClassDB db;

            db = new ConnectionClass.ClassDB();



            dts = db.portaTaula("Menu");

            dataGridView1.DataSource = dts.Tables[0];

            foreach (DataRow dr in dts.Tables[0].Rows)
            {
                 fruitToolStripMenuItem = new SdSMenuItem();

                fruitToolStripMenuItem.Text = dr["textmenu"].ToString();
                fruitToolStripMenuItem.Classe = dr["DLL"].ToString();
                fruitToolStripMenuItem.Form = dr["Form"].ToString();
                _esPare = (bool)dr["Pare"];
                fruitToolStripMenuItem.EsPare = _esPare;

                if (_esPare)
                {
                    _idMenu = dr["idMenu"].ToString();
                    menuStrip1.Items.Add(fruitToolStripMenuItem);
                    AddFills(_idMenu);
                }
            }
        }

        private void AddFills(string idMenu)
        {
            foreach (DataRow dr in dts.Tables[0].Rows)
            {
                string fill = dr["textmenu"].ToString();
                _idPare = dr["idpare"].ToString();
                if (_idPare == _idMenu)
                {
                    fruitToolStripMenuItem.DropDownItems.Add(fill);
                }
            }
        }

    }
}
