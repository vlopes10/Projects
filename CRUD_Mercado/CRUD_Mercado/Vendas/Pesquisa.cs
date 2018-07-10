using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRUD_Mercado.Vendas
{
    public partial class Pesquisa : Form
    {
        public Pesquisa()
        {
            InitializeComponent();
            ListaVendas();
            ListaVendas2();
        }

        public void ListaVendas()
        {
            Pesquisa_Vendas v = new Pesquisa_Vendas();
            gvVendas.DataSource = v.ListaVendas();

        }
        public void ListaVendas2()
        {
            Pesquisa_Itens I = new Pesquisa_Itens();
            gvVendas2.DataSource = I.ListaItens();

        }
        private void button1_Click(object sender, EventArgs e)
        {

        
        }

        private void gvVendas_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void gvVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gvVendas2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        
    }
}
