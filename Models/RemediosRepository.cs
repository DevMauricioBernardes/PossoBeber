using System;
using System.Collections.Generic;
using MySqlConnector;

namespace PossoBeber.Models
{
    public class RemediosRepository
    {   
        private const string DadosConexao = "Database=PossoBeber;Data Source=localhost; User Id=root;";
        public void TestarConexao(){

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();
            Console.WriteLine("Banco de dados Remedios Funcionando");
            Conexao.Close();

        }
        //4 metodos para CRUD inserir, alterar, listar e excluir Pacotes no banco de dados
        public void inserir(Remedios novoRemedio){

            //abrir conexão com banco de dados
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            //criando comando de SQL 
            String Query = "INSERT INTO Remedios (Nome,Posso,Descricao,Usuario) VALUES (@Nome,@Posso,@Descricao,@Usuario)";
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);

            //validação de segurança de valor informado
            Comando.Parameters.AddWithValue("@Nome",novoRemedio.Nome);
            Comando.Parameters.AddWithValue("@Posso",novoRemedio.Posso);
            Comando.Parameters.AddWithValue("@Descricao",novoRemedio.Descricao);            
            Comando.Parameters.AddWithValue("@Usuario",novoRemedio.Usuario);
                        
            //executa o comando
            Comando.ExecuteNonQuery();

            //fechar a conexao com banco de dados
            Conexao.Close();
        }
        public void atualizar(Remedios remedios){

            //abrir conexão com banco de dados
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            //criando comando de SQL 
            String Query = "UPDATE Remedios SET Nome=@Nome, Posso=@Posso, Descricao=@Descricao, Usuario=@Usuario WHERE Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);

            //validação de segurança de valor informado
            Comando.Parameters.AddWithValue("@Nome",remedios.Nome);
            Comando.Parameters.AddWithValue("@Posso",remedios.Posso);
            Comando.Parameters.AddWithValue("@Descricao",remedios.Descricao);            
            Comando.Parameters.AddWithValue("@Usuario",remedios.Usuario);    
            Comando.Parameters.AddWithValue("@Id",remedios.Id);            
            
            //executa o comando
            Comando.ExecuteNonQuery();

            //fechar a conexao com banco de dados
            Conexao.Close();

        }
        public List<Remedios> Listar(){

            //abrir conexão com banco de dados
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            //criando a lista de dados vazia
            List<Remedios> ListaDeRemedios = new List<Remedios>();

            //criando comando de SQL 
            String Query = "SELECT * FROM   Remedios";

            //infroma uma Query do objeto Conexao
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);

            //executa o comando e guarda as informaçoes no objeto da classe MySqlDataReader
            MySqlDataReader Reader = Comando.ExecuteReader();

            //percorrer registro a registro o Reader retornado
            while(Reader.Read()){

                Remedios remedioEncontrado = new Remedios();

                remedioEncontrado.Id = Reader.GetInt32("Id");

                //tratativa para não permitir inserir na lista dados null
                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome"))){
                    remedioEncontrado.Nome = Reader.GetString("Nome");
                }
                //tratativa para não permitir inserir na lista dados null
                if (!Reader.IsDBNull(Reader.GetOrdinal("Posso"))){
                    remedioEncontrado.Posso = Reader.GetString("Posso");
                }
                //tratativa para não permitir inserir na lista dados null
                if (!Reader.IsDBNull(Reader.GetOrdinal("Descricao"))){
                    remedioEncontrado.Descricao = Reader.GetString("Descricao");
                }                

                remedioEncontrado.Usuario = Reader.GetInt32("Usuario");

                ListaDeRemedios.Add(remedioEncontrado);
            }

            //fechar a conexao com banco de dados
            Conexao.Close();

            //retorno a lista
            return ListaDeRemedios;
        }
        public void remover(Remedios remedios){

            //abrir conexão com banco de dados
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            //criando comando de SQL 
            String Query = "DELETE FROM Remedios WHERE Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);

            //validação de segurança de valor informado
            Comando.Parameters.AddWithValue("@Id",remedios.Id);
            
            //executa o comando
            Comando.ExecuteNonQuery();

            //fechar a conexao com banco de dados
            Conexao.Close();
        }
        public Remedios BuscarPorId(int Id){

            //abrir conexão com banco de dados
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            //criar um usuario vazio
            Remedios remedioEncontrado = new Remedios();

            //criando comando de SQL
            String Query = "SELECT * FROM Remedios WHERE Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);

            //validação de segurança de valor informado
            Comando.Parameters.AddWithValue("@Id",Id);

            //executa o comando e guarda as informaçoes retornadas no objeto da classe MySqleDataReader
            MySqlDataReader Reader = Comando.ExecuteReader();

            if (Reader.Read()){

                remedioEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome"))){
                    remedioEncontrado.Nome = Reader.GetString("Nome");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Posso"))){
                    remedioEncontrado.Posso = Reader.GetString("Posso");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Descricao"))){
                    remedioEncontrado.Descricao = Reader.GetString("Descricao");
                }

                remedioEncontrado.Usuario = Reader.GetInt32("Usuario");

            }

            //fechar a conexao com banco de dados
            Conexao.Close();

            //retorno o usuario
            return remedioEncontrado;

        }
        public List<Remedios> Buscar(string Nome){

            //abrir conexão com banco de dados
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            //criando a lista de dados vazia
            List<Remedios> ListaDeRemedios = new List<Remedios>();

            //criando comando de SQL            
            String Query = "SELECT * FROM Remedios WHERE Nome LIKE @Nome";

            //infroma uma Query do objeto Conexao
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            Comando.Parameters.AddWithValue("@Nome","%" + Nome + "%");

            //executa o comando e guarda as informaçoes no objeto da classe MySqlDataReader
            MySqlDataReader Reader = Comando.ExecuteReader();
            Console.WriteLine(Reader.HasRows);
            Console.WriteLine("teste");
            //percorrer registro a registro o Reader retornado
            while(Reader.Read()){
                Console.WriteLine("teste2");
                Remedios remedioEncontrado = new Remedios();

                remedioEncontrado.Id = Reader.GetInt32("Id");

                //tratativa para não permitir inserir na lista dados null
                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome"))){
                    remedioEncontrado.Nome = Reader.GetString("Nome");
                }
                //tratativa para não permitir inserir na lista dados null
                if (!Reader.IsDBNull(Reader.GetOrdinal("Posso"))){
                    remedioEncontrado.Posso = Reader.GetString("Posso");
                }
                //tratativa para não permitir inserir na lista dados null
                if (!Reader.IsDBNull(Reader.GetOrdinal("Descricao"))){
                    remedioEncontrado.Descricao = Reader.GetString("Descricao");
                }                

                remedioEncontrado.Usuario = Reader.GetInt32("Usuario");

                ListaDeRemedios.Add(remedioEncontrado);
            }

            //fechar a conexao com banco de dados
            Conexao.Close();

            //retorno a lista
            return ListaDeRemedios;

        }
    }
}