using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUD_Mercado.Vendas
{
    public partial class realizacao_venda : Form
    {
        public realizacao_venda()
        {
            InitializeComponent();
          
        }

        public static int ID;
        
        SqlConnection sqlCo = null;
        private string strSql = string.Empty;
        private string strCon = "Password=dudinha321;Persist Security Info=True;User ID=66873;Initial Catalog=66873;Data Source=172.16.0.8";
        private string con = string.Empty;
      
        private void Cadastro()
        {

            con = "insert into Douglas.Vendas (meio_pagamento,cpf_cliente,funcionario_cod) values('" + cmbMeiodePa.SelectedItem + "'," + txtcpfCliente.Text + "," + txtCodFun.Text + ")";

            sqlCo = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(con, sqlCo);

            try
            {
                sqlCo.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Efetuado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                sqlCo.Close();

            }
        
        
        
        }
     
        public void cadastro2()
        {
        
          float total;

          float quantidade = float.Parse(txtQdd.Text);
          float valor = float.Parse(txtValorUnit.Text);
            total = quantidade * valor;

            string final = (total).ToString();
            txtTotal.Text = final;
            con = "insert into Douglas.itensvenda(ID_PRODUTO,quantidade,vendas_id,valor_unit,valor_total) values(" + txtCodProduto.Text + "," + txtQdd.Text + "," + txtNota.Text + "," + valor + ",'" + final + "')";
            sqlCo = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(con, sqlCo);

           

            try
            {
                sqlCo.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Efetuado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                sqlCo.Close();

            }
        
                
        }

        public void Select_Preco() 
        {
            strSql = "select PRECO from Douglas.PRODUTO WHERE ID_PRODUTO="+txtCodProduto.Text;
            sqlCo = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCo);

            try
            {
                sqlCo.Open();
                SqlDataReader dr = comando.ExecuteReader();

                dr.Read();
                txtValorUnit.Text = Convert.ToString(dr["PRECO"]);

            }
             
           catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                sqlCo.Close();

            }
        
        
        
        
        }

        public void inner()
        {

            ID = int.Parse(txtCodProduto.Text);
            Pesquisa_inner I = new Pesquisa_inner();
            gvInner.DataSource = I.ListaInner();


            txtFinal.Text =Pesquisa_inner.soma.ToString();



        }

        public void limpar()
        { 
        
         
            txtNota.Text = "";
            txtCodProduto.Text = "";
            txtQdd.Text = "";
            txtValorUnit.Text = "";
            txtTotal.Text = "";
        
        
        
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro();
      
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            cadastro2();
            inner();
          






        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtCodProduto_TextChanged(object sender, EventArgs e)
        {
            Select_Preco();
            txtQdd.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
