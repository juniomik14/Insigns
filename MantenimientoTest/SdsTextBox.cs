using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantenimientoTest
{
    class SdsTextBox : TextBox
    {
        string _Nom;


        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }

    }
}
