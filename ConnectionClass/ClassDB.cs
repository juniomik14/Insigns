using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;

namespace ConnectionClass
{
    public class ClassDB { 


        private string _ConnectionString;
        OleDbConnection connexxion;

    public void getConnexionString()
    {
        _ConnectionString = ConfigurationManager.ConnectionStrings["BadgesConnectionString"].ConnectionString;

    }

    public void connectBD()
    {
        getConnexionString();
        connexxion = new  OleDbConnection(_ConnectionString);
        connexxion.Open();
    }

    public DataSet portaTaula(string nomTaula)
    {

        connectBD();
        string query = "SELECT * FROM " + nomTaula;
        OleDbDataAdapter   adapter = new OleDbDataAdapter(query, _ConnectionString);
        DataSet dtsCli = new DataSet();
        adapter.Fill(dtsCli, nomTaula);

        return dtsCli;
    }

    public void Executa(string consulta)
    {
        try
        {
            connectBD();
            OleDbCommand comanda = new OleDbCommand(consulta, connexxion);
        }
        catch (OleDbException e)
        {
        }
        finally
        {
            connexxion.Close();

        }


    }

        private void portaDadesOLEDB(string nomTaula) {
            connectBD();
            string query = "SELECT * FROM " + nomTaula;
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, _ConnectionString);
            DataSet dtsCli = new DataSet();

        }
        //private void bindingDades() {

        //    foreach (txt in )
        //    {
        //        if (z is TextBox)
        //        {
        //            ((TextBox)z).Text = ((TextBox)z).Name;
        //        }


        //    }

        //}
        public void Actualitzar(DataSet dts, string consulta)
    {
        try
        {
            connectBD();
                OleDbDataAdapter adapterDts = new OleDbDataAdapter(consulta, _ConnectionString);
            adapterDts.Update(dts, consulta);
        }
        catch (OleDbException e)
        {

        }
        finally
        {
            connexxion.Close();

        }
    }
    public DataSet portaPerConsulta(string consultaSql)
    {

        connectBD();
        OleDbDataAdapter adapter = new OleDbDataAdapter(consultaSql, _ConnectionString);
        DataSet dtsCli = new DataSet();
        adapter.Fill(dtsCli, consultaSql);

        return dtsCli;
    }


}
}
