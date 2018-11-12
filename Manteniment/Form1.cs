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

namespace Manteniment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String query;

            query = "SELECT * FROM UserTypes";

            DataSet dts;

            ConnectionClass.ClassDB db;

            db = new ConnectionClass.ClassDB();

            dts = db.portaPerConsulta(query);
        }
    }
}
