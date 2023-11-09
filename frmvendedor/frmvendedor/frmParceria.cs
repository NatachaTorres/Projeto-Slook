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
    public partial class frmParceria : Form
    {
        string stringConexao = "" + "Data Source=FAC0539709W10-1;Initial Catalog=t14_projeto_slook;User ID=sa;Password=123456";

        public frmParceria()
        {
            InitializeComponent();
        }

        private void carregarfkfuncionario()
        {

            string sql = "select id_funcionario,nome_funcionario from funcionario";

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;

            DataTable tabela = new DataTable();
            //Vai pegar a tabela inteira pra achar o código
            //o data reader só consegue pegar a tabela toda de uma vez

            conexao.Open();

            try
            {
                leitura = cmd.ExecuteReader();

                tabela.Load(leitura);

                cboidfuncionario.DisplayMember = "id_funcionario";
                cboidfuncionario.DataSource = tabela;

                cbofuncionario.DisplayMember = "nome_funcionario";
                cbofuncionario.DataSource = tabela;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btosair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btolimpar_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            cboidfuncionario.SelectedIndex = -1;
            txtnome.Text = "";
            txtlogradouro.Text = "";
            txtcidade.Text = "";
            txtnumero.Text = "";
            cbouf.SelectedIndex = -1;
            txtcep.Text = "";
            txtcomplemento.Text = "";
            txtcnpj.Text = "";
            txtbairro.Text = "";
            cbofuncionario.SelectedIndex = -1;
            cbostatus.SelectedIndex = -1;
            txttelefone1.Text = "";
            txttelefone2.Text = "";
            txtcontato.Text = "";
            txtemail.Text = "";
            txtobs.Text = "";
            txtnome.Focus();


        }

        private void btocadastrar_Click(object sender, EventArgs e)
        {
            string sql = "insert into parceria (id_funcionario_parceria,nome_parceria, cnpj_parceria," +
                "numero_parceria, logadouro_parceria, comp_parceria, cep_parceria,"+
                "bairro_parceria, cidade_parceria, uf_parceria, telefone1_parceria,"+
                "telefone2_parceria, contato_parceria, email_parceria, obs_parceria)"+

                "values" +

                "('" + cboidfuncionario.Text + "','" + txtnome.Text+"', '"+txtcnpj.Text+"',"+txtnumero.Text+","+
                "'"+txtlogradouro.Text+"', '"+txtcomplemento.Text+"',"+
                "'"+txtcep.Text+"', '"+txtbairro.Text+"', '"+txtcidade.Text+"',"+
                "'"+cbouf.SelectedIndex+"', '"+txttelefone1.Text+"', '"+txttelefone2.Text+"',"+
                "'"+txtcontato.Text+"', '"+txtemail.Text+"', '"+txtobs.Text+ "')" +
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
            string sql = "select * from parceria where id_parceria=" + txtid.Text;

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
                    cboidfuncionario.Text = leitura[1].ToString();
                    txtnome.Text = leitura[2].ToString();
                    txtdata.Text = leitura[3].ToString();
                    txtcnpj.Text = leitura[4].ToString();
                    txtnumero.Text = leitura[5].ToString();
                    txtlogradouro.Text = leitura[6].ToString();
                    txtcomplemento.Text = leitura[7].ToString();
                    txtcep.Text = leitura[8].ToString();
                    txtbairro.Text = leitura[9].ToString();
                    txtcidade.Text = leitura[10].ToString();
                    cbouf.Text = leitura[11].ToString();
                    txttelefone1.Text = leitura[12].ToString();
                    txttelefone2.Text = leitura[13].ToString();
                    txtcontato.Text = leitura[14].ToString();
                    txtemail.Text = leitura[15].ToString();
                    txtobs.Text = leitura[16].ToString();
                    cbostatus.Text = leitura[17].ToString();

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

        private void frmParceria_Load(object sender, EventArgs e)
        {
            carregarfkfuncionario();
        }

        private void btoexcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete from parceria where id_parceria = " + txtid.Text;

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
            string sql = "update parceria set " +
                            "id_funcionario_parceria= '" + cboidfuncionario.Text + "', " +
                            "nome_parceria= '" + txtnome.Text + "', " +
                            "cnpj_parceria= '" + txtcnpj.Text + "', " +
                            "numero_parceria= " + txtnumero.Text + ", " +
                            "logadouro_parceria= '" + txtlogradouro.Text + "', " +
                            "comp_parceria= '" + txtcomplemento.Text + "', " +
                            "cep_parceria= '" + txtcep.Text + "', " +
                            "bairro_parceria= '" + txtbairro.Text + "', " +
                            "cidade_parceria= '" + txtcidade.Text + "', " +
                            "uf_parceria= '" + cbouf.SelectedIndex + "', " +
                            "telefone1_parceria= '" + txttelefone1.Text + "', " +
                            "telefone2_parceria= '" + txttelefone2.Text + "', " +
                            "contato_parceria= '" + txtcontato.Text + "', " +
                            "email_parceria= '" + txtemail.Text + "', " +
                            "obs_parceria= '" + txtobs.Text + "', " +
                            "status_parceria= '" + cbostatus.Text + "'" +
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
    }
}
