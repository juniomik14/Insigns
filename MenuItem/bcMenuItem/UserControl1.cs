using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bcMenuItem
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            
        }
        
        #region Classe
        private string _Classe;
        public string Classe
        {
            get
            {
                return _Classe;
            }
            set
            {
                _Classe = value;
            }
        }
        #endregion

        #region Form
        private string _Form;
        public string Form
        {
            get
            {
                return _Form;
            }
            set
            {
                _Form = value;
            }
        }
        #endregion

        //private void UserControl1_Load(object sender, EventArgs e)
        //{
        //    menuStrip1.Items.Add("hola1");
        //    menuStrip1.Items.Add("hola2");
        //    menuStrip1.Items.Add("hola3");
        //}
    }
}
