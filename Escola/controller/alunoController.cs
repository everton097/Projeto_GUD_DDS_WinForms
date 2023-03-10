using System;
using System.Collections.Generic;
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


    }
}
