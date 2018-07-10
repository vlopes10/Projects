using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CRUD_Mercado
{
    class Pesquisa_Itens
    {


        public int produto_cod { get; set; }
        public int valor_total { get; set; }
        public int valor_unit { get; set; }
        public int qdd { get; set; }




        SqlConnection con = new SqlConnection("Password=dudinha321;Persist Security Info=True;User ID=66873;Initial Catalog=66873;Data Source=172.16.0.8");


        public List<Pesquisa_Itens> ListaItens()
        {
            List<Pesquisa_Itens> listaI = new List<Pesquisa_Itens>();
            SqlDataAdapter da = new SqlDataAdapter("select * from  Douglas.itensvenda", con);
            DataSet ds = new DataSet();

            da.Fill(ds);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
               Pesquisa_Itens I = new Pesquisa_Itens();
                I.produto_cod = (int)dr["ID_PRODUTO"];
                I.qdd = (int)dr["quantidade"];
                I.valor_unit = (int)dr["valor_unit"];
                I.valor_total = (int)dr["valor_total"];



                listaI.Add(I);
            }
            return listaI;
        }
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
