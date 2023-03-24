using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Escola.model;
using MySql.Data.MySqlClient;

namespace Escola.controller
{
    public class alunoController
    {
        private MySqlConnection conexao;

        public alunoController()
        {
            this.conexao = new conn().getconnection();
        }

        public void cadrastroAluno(Aluno obj)
        {
            try
            {
                //1 passo - definir o comando sql
                string sql = @"insert into aluno
                (nome,rg,cpf,email,celular,cep,endereco,numero,bairro,cidade,uf) values
                (@nome,@rg,@cpf,@email,@celular,@cep,@endereco,@numero,@bairro,@cidade,@uf)";

                //2´passo - organizar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql,conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@uf", obj.uf);

                //3 passso - abrir a conexao executar o comando osql

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Aluno cadrastrado com sucesso!");

                //4 passo fechar o banco de dados
                conexao.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu um erro: " + ex.Message);
            }
        }


        public DataTable listarAlunos()
        {
            try
            {
                //1 passo - Criar o DataTable e o comando SQL
                DataTable tabela = new DataTable();
                string sql = "SELECT * FROM aluno;";

                //2 passo - Organizar o SQL e Executar
                MySqlCommand  executacmd = new MySqlCommand(sql,conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o adapter para preencher os dados na datatable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabela);

                //4 passo - Fechar a conexão do DB
                conexao.Close();

                return tabela;

            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao executar o comando SQL: "+ ex);
                return null;
            }
        }



        public DataTable buscaPorNome(string nome)
        {
            try
            {
                //1 passo - Criar o DataTable e o comando SQL
                DataTable tabela = new DataTable();
                String sql = "SELECT id, nome as 'Nome Completo',rg,cpf,email,celular,cep,endereco,numero,bairro,cidade, uf FROM aluno WHERE nome LIKE @nome;";
                //String sql = "SELECT id, nome as nome completo, * FROM aluno WHERE nome LIKE @nome;";
                //2 passo - Organizar o comando SQL e executar 
                MySqlCommand executaCMD = new MySqlCommand(sql,conexao);
                executaCMD.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executaCMD.ExecuteNonQuery();

                //3 passo - Criar o adapter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executaCMD);
                da.Fill(tabela);

                //4 passo - fechar
                conexao.Close();
                return tabela;

            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao executar sql: " + ex);
                return null;
            }


        }

        public void alterarAluno(Aluno obj)
        {
            try
            {
                //1 passo - definir o comando sql
                string sql = @"update aluno set nome=@nome,rg=@rg,cpf=@cpf,email=@email,
                celular=@celular,cep=@cep,endereco=@endereco,numero=@numero,bairro=@bairro,
                cidade=@cidade,uf=@uf where id=@id;";

                //2´passo - organizar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@uf", obj.uf);
                executacmd.Parameters.AddWithValue("@id", obj.Id);

                //3 passso - abrir a conexao executar o comando osql

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Aluno alterado com sucesso!");

                //4 passo fechar o banco de dados
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu um erro: " + ex.Message);
            }

        }


        public void excluirAluno(Aluno obj)
        {
            try
            {
                //Defenir o comando SQL
                string sql = "DELETE FROM aluno WHERE id = @id;";

                //Organizar o SQL e definir os parametros.
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.Id);

                //Abrir a conexao e executar o SQL
                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Aluno excluido com sucesso!");

                //Fechar conexao
                conexao.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Aconteceu um erro: "+ex);
            }
        }


    }
}
