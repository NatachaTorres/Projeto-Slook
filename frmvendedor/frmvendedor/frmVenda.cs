using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace slooknatacha
{
    public partial class frmVenda : Form
    {
        string stringConexao = "" + "Data Source=FAC0539709W10-1;Initial Catalog=t14_projeto_slook;User ID=sa;Password=123456";

        public frmVenda()
        {
            InitializeComponent();
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            //carregarfkcliente();
            //carregarfkproduto();
        }

        //private void carregarfkproduto()
        //{

        //    string sql = "select id_produto,nome_produto from produto";

        //    SqlConnection conexao = new SqlConnection(stringConexao);
        //    SqlCommand cmd = new SqlCommand(sql, conexao);
        //    cmd.CommandType = CommandType.Text;
        //    SqlDataReader leitura;

        //    DataTable tabela = new DataTable();

        //    conexao.Open();

        //    try
        //    {
        //        leitura = cmd.ExecuteReader();

        //        tabela.Load(leitura);

        //        cboidproduto.DisplayMember = "id_produto";
        //        cboidproduto.DataSource = tabela;

        //        cboproduto.DisplayMember = "nome_produto";
        //        cboproduto.DataSource = tabela;

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro " + ex.ToString());
        //    }
        //    finally
        //    {
        //        conexao.Close();
        //    }
        //}

        //private void carregarfkcliente()
        //{

        //    string sql = "select id_cliente,nome_cliente from cliente";

        //    SqlConnection conexao = new SqlConnection(stringConexao);
        //    SqlCommand cmd = new SqlCommand(sql, conexao);
        //    cmd.CommandType = CommandType.Text;
        //    SqlDataReader leitura;

        //    DataTable tabela = new DataTable();

        //    conexao.Open();

        //    try
        //    {
        //        leitura = cmd.ExecuteReader();

        //        tabela.Load(leitura);

        //        cboidcliente.DisplayMember = "id_cliente";
        //        cboidcliente.DataSource = tabela;

        //        cbocliente.DisplayMember = "nome_cliente";
        //        cbocliente.DataSource = tabela;

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro " + ex.ToString());
        //    }
        //    finally
        //    {
        //        conexao.Close();
        //    }
        //}

        private void btosair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btolimpar_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtdata.Text = "";
            cbocliente.SelectedIndex = -1;
            txtquantidade.Text = "";
            cboidproduto.SelectedIndex = -1;
            cboproduto.SelectedIndex = -1;
            txtvalorvenda.Text = "";
            txtobs.Text = "";
            cbocliente.SelectedIndex = -1;
            cbostatus.SelectedIndex = -1;
        }

        private void btocadastrar_Click(object sender, EventArgs e)
        { 


            string sql = "insert into venda (id_cliente_venda,id_produto_venda,qtd_venda,vvenda_venda,obs_venda)" +

              "values" +

               "('" + cboidcliente.Text + "','" + cboidproduto.Text + "'," + txtquantidade.Text + "," + txtvalorvenda.Text + "," +
               "'" + txtobs.Text + "')" +
               "select SCOPE_IDENTITY()";


            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader leitura;

            conn.Open();

            try
            {

                leitura = cmd.ExecuteReader();

                if (leitura.Read())
                {
                    btolimpar.PerformClick();

                    MessageBox.Show("Castro realizado com sucesso código gerado");

                    txtid.Text = leitura[0].ToString();

                    btopesquisar.PerformClick();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void btopesquisar_Click(object sender, EventArgs e)
        {
            string sql = "select * from venda where id_venda=" + txtid.Text;

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader leitura;
            conn.Open();

            try
            {
                leitura = cmd.ExecuteReader();
                if (leitura.Read())
                {

                    txtid.Text = leitura[0].ToString();
                    cbocliente.Text = leitura[1].ToString();
                    cboidproduto.Text = leitura[2].ToString();
                    txtdata.Text = leitura[3].ToString();
                    txtquantidade.Text = leitura[4].ToString();
                    txtvalorvenda.Text = leitura[5].ToString();
                    txtobs.Text = leitura[6].ToString();
                    cbostatus.Text = leitura[7].ToString();



                }
                else
                {
                    MessageBox.Show("Código não encontrado");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro, " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void btoexcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete from venda where id_venda = " + txtid.Text;

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.CommandType = System.Data.CommandType.Text;
            conn.Open();

            try
            {
                int I = cmd.ExecuteNonQuery();

                if (I == 1)
                {
                    MessageBox.Show("Dado excluido com sucesso");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void btoalterar_Click(object sender, EventArgs e)
        {
            string sql = "update venda set " +
                            "id_venda = '" + txtid.Text + "' , " +
                            "id_cliente_venda = '" + cbocliente.Text + "' , " +
                            "id_produto_venda = '" + cboidproduto.Text + "' , " +
                            "data_venda = '" + txtdata.Text + "' , " +
                            "qtd_venda = " + txtquantidade.Text + "," +
                            "vvenda_venda = '" + txtvalorvenda.Text + "' , " +
                            "obs_venda = '" + txtobs.Text + "' , " +
                            "status_venda = '" + cbostatus.Text + "'" +
                            "where id_parceria = " + txtid.Text;

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.CommandType = System.Data.CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Dados alterados com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro, não foi possivel alterar os dados");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, " + ex.ToString());

            }

            finally
            {
                conn.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Venda_Click(object sender, EventArgs e)
        {

        }
    }
}
