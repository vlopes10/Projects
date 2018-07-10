using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace CRUD_Mercado
{
    class Pesquisa_Fun
    {
        public string CARGO { get; set; }
        public string NOME { get; set; }
        public int IDADE { get; set; }
        public int CODIGO { get; set; }
        public string ENDERECO { get; set; }
        public string EMAIL { get; set; }
        public int CPF { get; set; }
        public int TELEFONE { get; set; }
        public string UF { get; set; }
        public int CEP { get; set; }
        public string CIDADE { get; set; }


        SqlConnection con = new SqlConnection("Password=dudinha321;Persist Security Info=True;User ID=66873;Initial Catalog=66873;Data Source=172.16.0.8");


        public List<Pesquisa_Fun> ListaFun()
        {
            List<Pesquisa_Fun> listaFun = new List<Pesquisa_Fun>();
            SqlDataAdapter da = new SqlDataAdapter("select * from  Douglas.FUNCIO", con);
            DataSet ds = new DataSet();

            da.Fill(ds);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Pesquisa_Fun p = new Pesquisa_Fun();
                p.CARGO = dr["CARGO"].ToString();
                p.NOME = dr["NOME"].ToString();
                p.IDADE = (int)dr["IDADE"];
                p.CODIGO = (int)dr["ID_FUN"];
                p.ENDERECO = dr["ENDERECO"].ToString();
                p.EMAIL = dr["EMAIL"].ToString();
                p.CPF = (int)dr["CPF"];
                p.TELEFONE = (int)dr["TELEFONE"];
                p.UF = dr["UF"].ToString();
                p.CEP = (int)dr["CEP"];
                p.CIDADE = dr["CIDADE"].ToString();


                listaFun.Add(p);
            }
            return listaFun;
        }
    }
}
