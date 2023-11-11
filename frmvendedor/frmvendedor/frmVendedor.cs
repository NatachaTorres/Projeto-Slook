using System.Data;
using System.Data.SqlClient;

namespace slooknatacha
{
    public partial class frmVendedor : Form
    {
        string stringConexao = "" + "Data Source=FAC0539709W10-1;Initial Catalog=t14_projeto_slook;User ID=sa;Password=123456";

        private void TestarConexao()
        {
            SqlConnection conn = new SqlConnection(stringConexao);


            try
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.ToString());
                Application.Exit();
            }

        }
        public frmVendedor()
        {
            InitializeComponent();
        }

        private void btosair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btolimpar_Click(object sender, EventArgs e)
        {
            txtbairro.Text = "";
            txtcep.Text = "";
            txtcidade.Text = "";
            txtcomplemento.Text = "";
            txtcpf.Text = "";
            txtemail.Text = "";
            txtnascimento.Text = "";
            txtlogradouro.Text = "";
            txtnome.Text = "";
            txtnumero.Text = "0";
            txttelefone1.Text = "";
            txttelefone2.Text = "";
            cbouf.Text = "";

            txtbairroloja.Text = "";
            txtceploja.Text = "";
            txtcidadeloja.Text = "";
            txtcomplementoloja.Text = "";
            txtcnpjloja.Text = "";
            txtdataloja.Text = "";
            txtemailloja.Text = "";
            txtidloja.Text = "";
            txtlogradouroloja.Text = "";
            txtnomeloja.Text = "";
            txtnumeroloja.Text = "0";
            txttelefone1loja.Text = "";
            txttelefone2loja.Text = "";
            cboufloja.Text = "";
            cbostatusloja.SelectedIndex = -1;
            txtobs.Text = "";
            txtnome.Focus();
        }

        private void btocadastrar_Click(object sender, EventArgs e)
        {
            string cpf = txtcpf.Text;
            cpf = cpf.Replace(",", ".");

            string cnpj = txtcnpjloja.Text;
            cnpj = cnpj.Replace(",", ".");

            string sql = "insert into vendedor (nome_vendedor,nasc_vendedor," +
                         "cpf_vendedor,logradouro_vendedor,numero_vendedor,comp_vendedor," +
                         "cep_vendedor,bairro_vendedor,cidade_vendedor,uf_vendedor," +
                         "telefone1_vendedor,telefone2_vendedor,email_vendedor,nomeloja_vendedor," +
                         "cnpjloja_vendedor,logradouroloja_vendedor,numeroloja_vendedor,comploja_vendedor," +
                         "ceploja_vendedor,bairroloja_vendedor,cidadeloja_vendedor,ufloja_vendedor," +
                          "telefone1loja_vendedor,telefone2loja_vendedor,obsloja_vendedor,statusloja_vendedor)" +

                        "values" +

                        "('" + txtnome.Text + "'," +
                        "'" + txtnascimento.Text + "','" + cpf + "','" + txtlogradouro.Text + "'," +
                        "" + txtnumero.Text + ",'" + txtcomplemento.Text + "','" + txtcep.Text + "'," +
                        "'" + txtbairro.Text + "','" + txtcidade.Text + "','" + cbouf.Text + "','" + txttelefone1.Text + "'," +
                        "'" + txttelefone2.Text + "','" + txtemail.Text + "','" + txtnomeloja.Text + "','" + cnpj + "'," +
                        "'" + txtlogradouroloja.Text + "','" + txtnumeroloja.Text + "','" + txtcomplementoloja.Text + "'," +
                        "'" + txtceploja.Text + "','" + txtbairroloja.Text + "','" + txtcidadeloja.Text + "','" + cboufloja.Text + "'," +
                        "'" + txttelefone1loja.Text + "','" + txttelefone2loja.Text + "','" + txtobs.Text + "','" + cbostatusloja.Text + "')" +
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

                    txtidloja.Text = leitura[0].ToString();

                    btoprequisar.PerformClick();
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

        private void btoprequisar_Click(object sender, EventArgs e)
        {
            string sql = "select * from vendedor where id_vendedor=" + txtidloja.Text;

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
                    txtidloja.Text = leitura[0].ToString();
                    txtnome.Text = leitura[1].ToString();
                    txtdataloja.Text = leitura[2].ToString();
                    txtnascimento.Text = leitura[3].ToString();
                    txtcpf.Text = leitura[4].ToString();
                    txtlogradouro.Text = leitura[5].ToString();
                    txtnumero.Text = leitura[6].ToString();
                    txtcomplemento.Text = leitura[7].ToString();
                    txtcep.Text = leitura[8].ToString();
                    txtbairro.Text = leitura[9].ToString();
                    txtcidade.Text = leitura[10].ToString();
                    cbouf.Text = leitura[11].ToString();
                    txttelefone1.Text = leitura[12].ToString();
                    txttelefone2.Text = leitura[13].ToString();
                    txtemail.Text = leitura[14].ToString();
                    txtnomeloja.Text = leitura[15].ToString();
                    txtcnpjloja.Text = leitura[16].ToString();
                    txtlogradouroloja.Text = leitura[17].ToString();
                    txtnumeroloja.Text = leitura[18].ToString();
                    txtcomplementoloja.Text = leitura[19].ToString();
                    txtceploja.Text = leitura[20].ToString();
                    txtbairroloja.Text = leitura[21].ToString();
                    txtcidadeloja.Text = leitura[22].ToString();
                    cboufloja.Text = leitura[23].ToString();
                    txttelefone1loja.Text = leitura[24].ToString();
                    txttelefone2loja.Text = leitura[25].ToString();
                    txtobs.Text = leitura[26].ToString();
                    cbostatusloja.Text = leitura[27].ToString();

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

        private void btoalterar_Click(object sender, EventArgs e)
        {

            string cpf = txtcpf.Text;
            cpf = cpf.Replace(",", ".");

            string cnpj = txtcnpjloja.Text;
            cnpj = cnpj.Replace(",", ".");


            string sql = "update vendedor set " +
                        "nome_vendedor='" + txtnome.Text + "'," +
                        "nasc_vendedor='" + txtnascimento.Text + "'," +
                        "cpf_vendedor='" + cpf + "'," +
                        "logradouro_vendedor='" + txtlogradouro.Text + "'," +
                        "numero_vendedor=" + txtnumero.Text + "," +
                        "comp_vendedor='" + txtcomplemento.Text + "'," +
                        "cep_vendedor='" + txtcep.Text + "'," +
                        "bairro_vendedor='" + txtbairro.Text + "'," +
                        "cidade_vendedor='" + txtcidade.Text + "'," +
                        "uf_vendedor='" + cbouf.Text + "'," +
                        "telefone1_vendedor='" + txttelefone1.Text + "'," +
                        "telefone2_vendedor='" + txttelefone2.Text + "'," +
                        "email_vendedor='" + txtemail.Text + "'," +
                        "nomeloja_vendedor='" + txtnomeloja.Text + "'," +
                        "cnpjloja_vendedor='" + cnpj + "'," +
                        "logradouroloja_vendedor='" + txtlogradouroloja.Text + "'," +
                        "numeroloja_vendedor='" + txtnumeroloja.Text + "'," +
                        "comploja_vendedor='" + txtcomplementoloja.Text + "'," +
                        "ceploja_vendedor='" + txtceploja.Text + "'," +
                        "bairroloja_vendedor='" + txtbairroloja.Text + "'," +
                        "cidadeloja_vendedor='" + txtcidadeloja.Text + "'," +
                        "ufloja_vendedor='" + cboufloja.Text + "'," +
                        "telefone1loja_vendedor='" + txttelefone1loja.Text + "'," +
                        "telefone2loja_vendedor='" + txttelefone2loja.Text + "'," +
                        "obsloja_vendedor='" + txtobs.Text + "'," +
                        "statusloja_vendedor='" + cbostatusloja.Text + "'" +
                        "where id_vendedor =  " + txtidloja.Text;




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

        private void btoexcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete from vendedor where id_vendedor = " + txtidloja.Text;

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

        private void frmVendedor_Load(object sender, EventArgs e)
        {

        }

        private void txtlogradouro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txttelefone2loja_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }
    }
}