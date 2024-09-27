using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx;

namespace Armazenador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=root;database=filmes");
                conn.Open(); MySqlCommand comando = new MySqlCommand("INSERT INTO `gerente` (`nome`, `senha`) VALUES (@nome, @senha);", conn);
                comando.Parameters.AddWithValue("@nome", txbNome.Text);
                comando.Parameters.AddWithValue("@senha", txbSenha.Text);

                comando.ExecuteNonQuery();
                conn.Close();

                txbNome.Text = "";
                txbSenha.Text = "";

            }
            catch (Exception ex)
            {
                label2.Text = ex.Message;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=root;database=filmes");
                conn.Open(); MySqlCommand comando = new MySqlCommand("INSERT INTO `armazem` (`nome`, `data`, `classificacao`, `duracao`, `categoria`, `locacao`, `valorFilme`, `endereco`, `telefone`, `email`) VALUES (@nome, @data, @classificacao, @duracao, @categoria, @locacao, @valorFilme, @endereco, @telefone, @email);", conn);
                comando.Parameters.AddWithValue("@nome", txb1.Text);
                comando.Parameters.AddWithValue("@data", txb2.Text);
                comando.Parameters.AddWithValue("@classificacao", txb3.Text);
                comando.Parameters.AddWithValue("@duracao", txb4.Text);
                comando.Parameters.AddWithValue("@categoria", txb5.Text);
                comando.Parameters.AddWithValue("@locacao", txb6.Text);
                comando.Parameters.AddWithValue("@valorFilme", txb7.Text);
                comando.Parameters.AddWithValue("@endereco", txb8.Text);
                comando.Parameters.AddWithValue("@telefone", txb9.Text);
                comando.Parameters.AddWithValue("@email", txb10.Text);

                comando.ExecuteNonQuery();
                conn.Close();

                txb1.Text = "";
                txb2.Text = "";
                txb3.Text = "";
                txb4.Text = "";
                txb5.Text = "";
                txb6.Text = "";
                txb7.Text = "";
                txb8.Text = "";
                txb9.Text = "";
                txb10.Text = "";

            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void btnCadas_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=root;database=filmes");
                conn.Open(); MySqlCommand comandoo = new MySqlCommand("SELECT * from `usuarios` WHERE `login` = @login AND `senha` = @senha;", conn);
                comandoo.Parameters.AddWithValue("@login", txbLogin.Text);
                comandoo.Parameters.AddWithValue("@senha", txbSenh.Text);

                object controle = comandoo.ExecuteScalar();
                conn.Close();

                if (controle == null)
                {
                    MessageBox.Show("algo está errado.\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    //this.Close();
                    tabControl1.TabPages.Add(tabPage1);
                    tabControl1.TabPages.Add(tabPage2);
                    tabControl1.TabPages.Add(tabPage3);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("algo está errado.\n" + erro.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=root;database=filmes");
                conn.Open();

                if (txbFilme.Text == "")
                {
                    MySqlCommand comandos = new MySqlCommand("SELECT `nome`, `data`, `classificacao`, `duracao`, `categoria`, `locacao`, `valorFilme`, `endereco`, `telefone`, `email` FROM `armazem`;'", conn);
                    var reader = comandos.ExecuteReader();

                    while (reader.Read())
                    {
                        richTextBox1.Text = "Nome: " + reader.GetString(0) + "Data: " + reader.GetString(1) + "Classificação: " + reader.GetString(2) + "Duração: " + reader.GetString(3) + "Categoria: " + reader.GetString(4) + "Locação: " + reader.GetString(5) + "Valor do Filme: " + reader.GetString(6) + "Endereço: " + reader.GetString(7) + "Telefone: " + reader.GetString(8) + "Email: " + reader.GetString(9);
                    }
                }
                else
                {
                    MySqlCommand comandos = new MySqlCommand("SELECT * FROM `armazem` WHERE `nome` = @nome;'", conn);
                    comandos.Parameters.AddWithValue("@nome", txb1.Text);

                    var reader = comandos.ExecuteReader();

                    while (reader.Read())
                    {
                        richTextBox1.Text = "Nome: " + reader.GetString(0) + "Data: " + reader.GetString(1) + "Classificação: " + reader.GetString(2) + "Duração: " + reader.GetString(3) + "Categoria: " + reader.GetString(4) + "Locação: " + reader.GetString(5) + "Valor do Filme: " + reader.GetString(6) + "Endereço: " + reader.GetString(7) + "Telefone: " + reader.GetString(8) + "Email: " + reader.GetString(9);
                    }

                }
                if (conn.State.ToString() != "Close")
                {
                    conn.Close();
                }
            }
        catch (Exception erro)
        {

        }
        finally
        {
            txb1.Text = "";
            txb2.Text = "";
            txb3.Text = "";
            txb4.Text = "";
            txb5.Text = "";
            txb6.Text = "";
            txb7.Text = "";
            txb8.Text = "";
            txb9.Text = "";
            txb10.Text = "";
            }
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    } }
            
    