using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUD_Mercado.Produto
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        SqlConnection sqlCo = null;
        private string strCon = "Password=dudinha321;Persist Security Info=True;User ID=66873;Initial Catalog=66873;Data Source=172.16.0.8"; // string de conexão
        private string con = string.Empty;  
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = "insert into Douglas.PRODUTO (ID_PRODUTO,NOME,MARCA,PRECO,QDD,GENERO,VALIDADE,DATA_EN) values("+txtID.Text+",'"+txtNome.Text+"','"+txtMarca.Text+"',"+txtPreco.Text+","+txtQdd.Text+",'"+txtgenero.Text+"',"+txtValidade.Text+","+txtD_en.Text+")";
            // inserção de dados no  SqlServer
            sqlCo = new SqlConnection(strCon); // nova conexão com sql
            SqlCommand comando = new SqlCommand(con, sqlCo);

            try       
            {
                sqlCo.Open();
          

                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Efetuado");          // Tentativa de cadastro de produtos Try 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);     // Mensagem caso aconteça algum erro

            }
            finally
            {
              sqlCo.Close();    // Após tentativa de conexão e cadastro fechar a conexão com Sql Server - ou qualquer bd
            
            }
        
        
        
        }
    }
}
