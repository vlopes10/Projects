using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using CRUD_Mercado.Vendas;

namespace CRUD_Mercado
{
    class Pesquisa_inner
    {


        public int valor_total{ get; set; }
        public string NOME { get; set; }
        public int PRECO { get; set; }
        public int quantidade { get; set; }

        SqlConnection con = new SqlConnection("Password=dudinha321;Persist Security Info=True;User ID=66873;Initial Catalog=66873;Data Source=172.16.0.8");
       public static  float soma=0;
    

        public List<Pesquisa_inner> ListaInner()
        {
            List<Pesquisa_inner> listaI = new List<Pesquisa_inner>();
            SqlDataAdapter da = new SqlDataAdapter("select Douglas.PRODUTO.NOME,Douglas.PRODUTO.PRECO, Douglas.itensvenda.quantidade, Douglas.itensvenda.valor_total from Douglas.PRODUTO inner join Douglas.itensvenda on  Douglas.itensvenda.ID_PRODUTO= Douglas.PRODUTO.ID_PRODUTO where Douglas.PRODUTO.ID_PRODUTO="+ realizacao_venda.ID, con);
            DataSet ds = new DataSet();

            da.Fill(ds);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Pesquisa_inner I = new Pesquisa_inner();
                I.valor_total = (int)dr["valor_total"];
                I.quantidade = (int)dr["quantidade"];
                I.NOME = dr["NOME"].ToString();
                I.PRECO = (int)dr["PRECO"];



                listaI.Add(I);
                soma = soma + I.valor_total;
            }
            return listaI;
        }
    }
}
