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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace V2_BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionarCarro_Click(object sender, EventArgs e)
        {
            Carro carro = new Carro(tbxNome.Text, tbxMarca.Text, Convert.ToInt32(tbxAno.Text), Convert.ToDouble(tbxValor.Text), Convert.ToDouble(tbxQuilometragem.Text), tbxCor.Text, tbxCambio.Text, tbxCombustivel.Text);

            SqlConnection sqlConexao = new SqlConnection("Data Source=DESKTOP-UNADQGL\\SQLEXPRESS;Initial Catalog=V2_BD;Integrated Security=True");

            string query = "INSERT INTO Carro(nome, marca, ano, valor, km, cor, cambio, combustivel) VALUES(@nome, @marca, @ano, @valor, @km, @cor, @cambio, @combustivel)";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, sqlConexao))
                {
                    cmd.Parameters.AddWithValue("@nome", carro.Nome);
                    cmd.Parameters.AddWithValue("@marca", carro.Marca);
                    cmd.Parameters.AddWithValue("@ano", carro.Ano);
                    cmd.Parameters.AddWithValue("@valor", carro.Valor);
                    cmd.Parameters.AddWithValue("@km", carro.Km);
                    cmd.Parameters.AddWithValue("@cor", carro.Cor);
                    cmd.Parameters.AddWithValue("@cambio", carro.Cambio);
                    cmd.Parameters.AddWithValue("@combustivel", carro.Combustivel);

                    sqlConexao.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Carro adicionado com sucesso!");

                    limparTextBoxCarro();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Erro ao realizar o cadastro! {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}");
            }
        }
        private void limparTextBoxCarro()
        {
            tbxNome.Text = string.Empty;
            tbxMarca.Text = string.Empty;
            tbxAno.Text = string.Empty;
            tbxValor.Text = string.Empty;
            tbxQuilometragem.Text = string.Empty;
            tbxCor.Text = string.Empty;
            tbxCambio.Text = string.Empty;
            tbxCombustivel.Text = string.Empty;
        }

        private void limparTextBoxMoto()
        {
            tbxNomeM.Text = string.Empty;
            tbxMarcaM.Text = string.Empty;
            tbxAnoM.Text = string.Empty;
            tbxValorM.Text = string.Empty;
            tbxQuilometragemM.Text = string.Empty;
            tbxCorM.Text = string.Empty;
            tbxEstiloM.Text = string.Empty;
            tbxMarchasM.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.Carro'. Você pode movê-la ou removê-la conforme necessário.
            this.carroTableAdapter.Fill(this.dataSet1.Carro);

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConexao = new SqlConnection("Data Source=DESKTOP-UNADQGL\\SQLEXPRESS;Initial Catalog=V2_BD;Integrated Security=True"))
                {
                    string query = "SELECT * FROM Carro ORDER by cod_carro";
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlConexao);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvCarro.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar recuperar os dados: {ex.Message}");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarMoto_Click(object sender, EventArgs e)
        {
            Moto moto = new Moto(tbxNomeM.Text, tbxMarcaM.Text, Convert.ToInt32(tbxAnoM.Text), Convert.ToDouble(tbxValorM.Text), Convert.ToDouble(tbxQuilometragemM.Text), tbxCorM.Text, tbxEstiloM.Text, tbxMarchasM.Text);

            SqlConnection sqlConexao = new SqlConnection("Data Source=DESKTOP-UNADQGL\\SQLEXPRESS;Initial Catalog=V2_BD;Integrated Security=True");

            string query = "INSERT INTO Moto(nome, marca, ano, valor, km, cor, estilo, marchas) VALUES(@nome, @marca, @ano, @valor, @km, @cor, @estilo, @marchas)";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, sqlConexao))
                {
                    cmd.Parameters.AddWithValue("@nome", moto.Nome);
                    cmd.Parameters.AddWithValue("@marca", moto.Marca);
                    cmd.Parameters.AddWithValue("@ano", moto.Ano);
                    cmd.Parameters.AddWithValue("@valor", moto.Valor);
                    cmd.Parameters.AddWithValue("@km", moto.Km);
                    cmd.Parameters.AddWithValue("@cor", moto.Cor);
                    cmd.Parameters.AddWithValue("@estilo", moto.Estilo);
                    cmd.Parameters.AddWithValue("@marchas", moto.Marchas);

                    sqlConexao.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Moto adicionada com sucesso!");

                    limparTextBoxMoto();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Erro ao realizar o cadastro! {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}");
            }
        }

        private void btnMostrarMoto_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConexao = new SqlConnection("Data Source=DESKTOP-UNADQGL\\SQLEXPRESS;Initial Catalog=V2_BD;Integrated Security=True"))
                {
                    string query = "SELECT * FROM Moto ORDER by cod_moto";
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlConexao);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvMoto.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar recuperar os dados: {ex.Message}");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxNome.Text) || string.IsNullOrWhiteSpace(tbxValor.Text) || string.IsNullOrWhiteSpace(tbxQuilometragem.Text))
                {
                    MessageBox.Show("Os campos Nome, Valor e Quilometragem devem ser preenchidos.");
                    return;
                }

                double valor;
                double km;

                if (!double.TryParse(tbxValor.Text, out valor))
                {
                    MessageBox.Show("Valor inválido.");
                    return;
                }

                if (!double.TryParse(tbxQuilometragem.Text, out km))
                {
                    MessageBox.Show("Quilometragem inválida.");
                    return;
                }

                using (SqlConnection sqlConexao = new SqlConnection("Data Source=DESKTOP-UNADQGL\\SQLEXPRESS;Initial Catalog=V2_BD;Integrated Security=True"))
                {
                    string query = "UPDATE Carro SET valor = @valor, km = @km WHERE nome = @nome";

                    using (SqlCommand cmd = new SqlCommand(query, sqlConexao))
                    {
                        cmd.Parameters.AddWithValue("@valor", valor);
                        cmd.Parameters.AddWithValue("@km", km);
                        cmd.Parameters.AddWithValue("@nome", tbxNome.Text);

                        sqlConexao.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Carro atualizado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Nenhum carro encontrado com o nome especificado.");
                        }

                        limparTextBoxCarro();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}");
            }
        }

        private void btnEditarM_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxNomeM.Text) || string.IsNullOrWhiteSpace(tbxValorM.Text) || string.IsNullOrWhiteSpace(tbxQuilometragemM.Text))
                {
                    MessageBox.Show("Os campos Nome, Valor e Quilometragem devem ser preenchidos.");
                    return;
                }

                double valor;
                double km;

                if (!double.TryParse(tbxValorM.Text, out valor))
                {
                    MessageBox.Show("Valor inválido.");
                    return;
                }

                if (!double.TryParse(tbxQuilometragemM.Text, out km))
                {
                    MessageBox.Show("Quilometragem inválida.");
                    return;
                }

                using (SqlConnection sqlConexao = new SqlConnection("Data Source=DESKTOP-UNADQGL\\SQLEXPRESS;Initial Catalog=V2_BD;Integrated Security=True"))
                {
                    string query = "UPDATE Moto SET valor = @valor, km = @km WHERE nome = @nome";

                    using (SqlCommand cmd = new SqlCommand(query, sqlConexao))
                    {
                        cmd.Parameters.AddWithValue("@valor", valor);
                        cmd.Parameters.AddWithValue("@km", km);
                        cmd.Parameters.AddWithValue("@nome", tbxNomeM.Text);

                        sqlConexao.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Moto atualizada com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Nenhuma moto encontrada com o nome especificado.");
                        }

                        limparTextBoxMoto();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}");
            }
        }
    }
}