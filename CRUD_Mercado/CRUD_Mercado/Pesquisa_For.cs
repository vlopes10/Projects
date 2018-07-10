using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace CRUD_Mercado
{
     public partial class Pesquisa_For
    {
        public string EMPRESA { get; set; }
        public int CNPJ { get; set; }
        public int CODIGO { get; set; }
        public string ENDERECO { get; set; }
        public int TELEFONE { get; set; }
        public string UF { get; set; }
        public string GENERO { get; set; }
        public int CEP { get; set; }

    SqlConnection con = new SqlConnection("Password=dudinha321;Persist Security Info=True;User ID=66873;Initial Catalog=66873;Data Source=172.16.0.8");


    public List<Pesquisa_For> ListaFornecedor()
    {
        List<Pesquisa_For> listaF = new List<Pesquisa_For>();
        SqlDataAdapter da = new SqlDataAdapter("select * from  Douglas.FORNE" ,con);
        DataSet ds = new DataSet();

        da.Fill(ds);

        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            Pesquisa_For p = new Pesquisa_For();
            p.EMPRESA = dr["EMPRESA"].ToString();
            p.CNPJ = (int)dr["CNPJ"];
            p.CODIGO = (int)dr["ID_EMPRESA"];
            p.ENDERECO = dr["ENDERECO"].ToString();
            p.TELEFONE = (int)dr["TELEFONE"];
            p.UF = dr["UF"].ToString();
            p.GENERO = dr["GENERO"].ToString();
            p.CEP = (int)dr["CEP"];

            listaF.Add(p);
        }
        return listaF;
    }
    
    
    
    
    
    
    
    
    }
}
