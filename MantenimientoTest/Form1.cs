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


namespace MantenimientoTest
{
    public partial class frmMant_Table : Form
    {
        #region Variables
        DataSet dts;
        SdsTextBox CSDStxtBox;
        ClassDB CDB;
        private bool EsNou = false;
        const string query = "select * from UserTypes";
        #endregion

        #region Constructores
        public frmMant_Table()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        private void Inicializaciones()
        {
            CDB = new ClassDB();
            CSDStxtBox = new SdsTextBox();
            dts = CDB.portaPerConsulta(query);
            RellenarDataGrid(dts);
            dgvMant_table.AllowUserToAddRows = false;
        }
        private void RellenarDataGrid(DataSet dataset)
        {
            dgvMant_table.DataSource = dataset.Tables[0];
            BindDades();
        }
        private void BindDades()
        {
            foreach (Control sdsControl in this.Controls)
            {
                if (sdsControl is SdsTextBox)
                {
                    ((SdsTextBox)sdsControl).DataBindings.Clear();
                    ((SdsTextBox)sdsControl).DataBindings.Add("Text", dts.Tables[0], ((SdsTextBox)sdsControl).ColumnName.ToString());
                    ((SdsTextBox)sdsControl).Validated += new EventHandler(validar);
                }
            }
        }
        private void QuitarBindDades()
        {
            foreach (Control sdsControl in this.Controls)
            {
                if (sdsControl is SdsTextBox)
                {
                    ((SdsTextBox)sdsControl).DataBindings.Clear();
                    sdsControl.Text = "";             
                }
            }
        }
        private void AñadirFila()
        {
            string nomCamp = ""; 
            DataRow dr = dts.Tables[0].NewRow();
            foreach (Control sdsControl in this.Controls)
            {
                if (sdsControl is SdsTextBox)
                {
                    nomCamp = ((SdsTextBox)sdsControl).ColumnName;
                    dr[nomCamp] = sdsControl.Text;
                    
                }
            }
            dts.Tables[0].Rows.Add(dr);
        }
        #endregion

        #region Eventos
        private void validar(object sender, EventArgs e)
        {
            if (!EsNou)
            {
                ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }        
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!EsNou)
            {
                CDB.Actualitzar(dts, query);
            }
            else
            {
                AñadirFila();
                CDB.Actualitzar(dts, query);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            QuitarBindDades();
            EsNou = true;
            txtBoxCodeType.Focus();

        }
        private void frmMant_Table_Load(object sender, EventArgs e)
        {
            Inicializaciones();
        }
        #endregion
    }
}
