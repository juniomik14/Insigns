using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bcMenuItem
{
    public class SdSMenuItem : ToolStripMenuItem
    {


        public SdSMenuItem()
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
        public bool EsPare { get; set; }

        private void InitializeComponent()
        {
            this.Click += new System.EventHandler(this.ObreForm);
        }

        public void ObreForm(object sender, EventArgs e)
        {
            if (!EsPare)
            {
                try
                {

                    Assembly ensamblat = Assembly.LoadFrom(_Classe);
                    Object dllBD;
                    Type tipus;
                    tipus = ensamblat.GetType(_Form);
                    dllBD = Activator.CreateInstance(tipus);
                    ((Form)dllBD).Show();
                }
                catch
                {
                    MessageBox.Show("Error en obrir el formulari. Comprova que estigui la llibreria o el executable que vols obrir");
                }
            }
        }


    }
}
