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
    internal class cursoController
    {
        private MySqlConnection conexao;

        public cursoController()
        {
            this.conexao = new conn().getconnection();
        }

        public void cadrastroCurso(Curso obj)
        {
            try
            {
                //Definir o comando sql
                string sql = @"insert into curso
                (nome_curso,carga_horaria, periodo, nome_coordenador, objetivo,perfil_egresso) values
                (@nome_curso,@carga_horaria,@periodo,@nome_coordenador,@objetivo,@perfil_egresso)";

                //Organizar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome_curso", obj.nome_curso);
                executacmd.Parameters.AddWithValue("@carga_horaria", obj.carga_horaria);
                executacmd.Parameters.AddWithValue("@periodo", obj.periodo);
                executacmd.Parameters.AddWithValue("@nome_coordenador", obj.nome_coordenador);
                executacmd.Parameters.AddWithValue("@objetivo", obj.objetivo);
                executacmd.Parameters.AddWithValue("@perfil_egresso", obj.perfil_egresso);

                //Abrir a conexao executar o comando osql

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Curso cadrastrado com sucesso!");

                //Fechar o banco de dados
                conexao.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu um erro: " + ex.Message);
            }
        }


        public DataTable listarCursos()
        {
            try
            {
                //Criar o DataTable e o comando SQL
                DataTable tabela = new DataTable();
                string sql = "SELECT * FROM curso;";

                //2 passo - Organizar o SQL e Executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - Criar o adapter para preencher os dados na datatable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabela);

                //4 passo - Fechar a conexão do DB
                conexao.Close();

                return tabela;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Listar Cursos !!!\nErro ao executar o comando SQL: " + ex);
                return null;
            }
        }

        public DataTable buscaPorNome(string nome_curso)
        {
            try
            {
                //1 passo - Criar o DataTable e o comando SQL
                DataTable tabela = new DataTable();
                String sql = "SELECT * FROM curso WHERE nome_curso LIKE @nome_curso;";

                //2 passo - Organizar o comando SQL e executar 
                MySqlCommand executaCMD = new MySqlCommand(sql, conexao);
                executaCMD.Parameters.AddWithValue("@nome_curso", nome_curso);

                conexao.Open();
                executaCMD.ExecuteNonQuery();

                //Criar o adapter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executaCMD);
                da.Fill(tabela);

                //4 passo - fechar
                conexao.Close();
                return tabela;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar sql: " + ex);
                return null;
            }


        }

        public void alterarCurso(Curso obj)
        {
            try
            {
                //Definir o comando sql
                string sql = @"update curso set nome_curso=@nome_curso,
                carga_horaria=@carga_horaria,periodo=@periodo,
                nome_coordenador=@nome_coordenador,objetivo=@objetivo,
                perfil_egresso=@perfil_egresso where id=@id;";

                //Organizar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome_curso", obj.nome_curso);
                executacmd.Parameters.AddWithValue("@carga_horaria", obj.carga_horaria);
                executacmd.Parameters.AddWithValue("@periodo", obj.periodo);
                executacmd.Parameters.AddWithValue("@nome_coordenador", obj.nome_coordenador);
                executacmd.Parameters.AddWithValue("@objetivo", obj.objetivo);
                executacmd.Parameters.AddWithValue("@perfil_egresso", obj.perfil_egresso);
                executacmd.Parameters.AddWithValue("@id", obj.Id);

                //Abrir a conexao executar o comando osql

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Curso @nome_curso alterado com sucesso!");

                //Fechar o banco de dados
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu um erro: " + ex.Message);
            }

        }









    }
}
