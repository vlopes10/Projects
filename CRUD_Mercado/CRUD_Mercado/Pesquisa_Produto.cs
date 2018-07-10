using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace CRUD_Mercado
{
    class Pesquisa_Produto
    {
        public string MARCA { get; set; }
        public string NOME { get; set; }
        public int PRECO { get; set; }
        public int CODIGO { get; set; }
        public string GENERO { get; set; }
        public int QDD { get; set; }
        public int VALIDADE { get; set; }
        public int DATAE { get; set; }
       


        SqlConnection con = new SqlConnection("Password=dudinha321;Persist Security Info=True;User ID=66873;Initial Catalog=66873;Data Source=172.16.0.8");


        public List<Pesquisa_Produto> ListaProduto()
        {
            List<Pesquisa_Produto> listaP = new List<Pesquisa_Produto>();
            SqlDataAdapter da = new SqlDataAdapter("select * from  Douglas.PRODUTO ",con);
            DataSet ds = new DataSet();

            da.Fill(ds);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Pesquisa_Produto p = new Pesquisa_Produto();
                p.MARCA = dr["MARCA"].ToString();
                p.NOME = dr["NOME"].ToString();
                p.PRECO = (int)dr["PRECO"];
                p.CODIGO = (int)dr["ID_PRODUTO"];
                p.GENERO = dr["GENERO"].ToString();
                p.QDD = (int)dr["QDD"];
                p.VALIDADE = (int)dr["VALIDADE"];
                p.DATAE = (int)dr["DATA_EN"];
        


                listaP.Add(p);
            }
            return listaP;
        }
    }
}
