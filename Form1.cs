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
//using Microsoft.VisualBasic;
//using System.Reflection.PortableExecutable;
//using System.Net.NetworkInformation;
//using System.ComponentModel.DataAnnotations;

namespace Diario_De_Bordo_DSM
{
    public partial class Form1 : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        String SQL;
        String pc = Environment.MachineName;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {


            try
            {
                //SqlConnection conexao = new SqlConnection(@"=" + pc + ";Database=dbregistro;trusted_connection=yes");

                if (conexao.State == ConnectionState.Closed)
                {
                    //comando.Connection = conexao;
                    conexao.Open();
                }
                SQL = "insert into tb_maquinas values (@codigo,@maquina)";
                comando = new SqlCommand(SQL, conexao);
                comando.Parameters.AddWithValue("@codigo", txt_cad_numero.Text);
                comando.Parameters.AddWithValue("@maquina", txt_cad_descricao.Text);
                comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Máquina adicionada com sucesso!", "Atenção...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SQL = "select * from tb_maquinas order by nome asc";

                txt_cad_descricao.Clear();
                txt_cad_numero.Clear();

                txt_cad_descricao.Focus();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Falha ao gravar registro!", "Atenção...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conexao.Close();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            try
            {
                BeginInvoke((MethodInvoker)delegate
                {
                    try
                    {
                        
                        conexao = new SqlConnection(@"Data Source=" + pc + ";Database=dbregistro;trusted_connection=yes");

                        MessageBox.Show("Conexão estabelecida com sucesso!", "Atenção...", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btn_config.Image = Image.FromFile(Application.StartupPath + "\\imagens\\icones\\settings-green.png");

                        btn_salvar.Enabled = false;
                        lbl_salvar.Enabled = false;

                        btn_editar.Enabled = false;
                        lbl_editar.Enabled = false;

                        btn_excluir.Enabled = false;
                        lbl_excluir.Enabled = false;

                        //SQL = "select * from tb_problemas order by nome asc";
                        //SqlDataAdapter data = new SqlDataAdapter(SQL, conexao);
                        //DataSet tabela = new DataSet();
                        //data.Fill(tabela);



                    }
                    catch
                    {
                        MessageBox.Show("Falha ao estabelecer conexão!", "Atenção...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            }
            catch
            {
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja sair?", "Atenção...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_todos_Click(object sender, EventArgs e)
        {
            pnl_home.Visible = false;
        }

        private void txt_cad_descricao_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cad_descricao.Text))
            {
                btn_salvar.Enabled = false;
                lbl_salvar.Enabled = false;
            }
            else
            {
                if (string.IsNullOrEmpty(txt_cad_numero.Text))
                {
                    btn_salvar.Enabled = false;
                    lbl_salvar.Enabled = false;
                }
                else
                {
                    btn_salvar.Enabled = true;
                    lbl_salvar.Enabled = true;
                }
            }
        }

        private void txt_cad_numero_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cad_descricao.Text))
            {
                btn_salvar.Enabled = false;
                lbl_salvar.Enabled = false;
            }
            else
            {
                if (string.IsNullOrEmpty(txt_cad_numero.Text))
                {
                    btn_salvar.Enabled = false;
                    lbl_salvar.Enabled = false;
                }
                else
                {
                    btn_salvar.Enabled = true;
                    lbl_salvar.Enabled = true;
                }
            }
        }

        private void txt_cad_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_cad_numero.MaxLength = 4;
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_cad_descricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_cad_descricao.MaxLength = 40;
        }
    }
}