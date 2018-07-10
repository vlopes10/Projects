using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CRUD_Mercado
{
    class Pesquisa_Vendas
    {

        public string meio_pagamento { get; set; }
        public int cpf_cliente { get; set; }
        public int funcio_cod { get; set; }
        public int ID { get; set; }


        SqlConnection con = new SqlConnection("Password=dudinha321;Persist Security Info=True;User ID=66873;Initial Catalog=66873;Data Source=172.16.0.8");


        public List<Pesquisa_Vendas> ListaVendas()
        {
            List<Pesquisa_Vendas> listaV = new List<Pesquisa_Vendas>();
            SqlDataAdapter da = new SqlDataAdapter("select * from  Douglas.Vendas", con);
            DataSet ds = new DataSet();

            da.Fill(ds);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Pesquisa_Vendas v = new Pesquisa_Vendas();
                v.meio_pagamento = dr["meio_pagamento"].ToString();
                v.cpf_cliente = (int)dr["cpf_cliente"];
                v.funcio_cod = (int)dr["funcionario_cod"];
                v.ID = (int)dr["ID"];   



                listaV.Add(v);
            }
            return listaV;
        }

       
    }

}
