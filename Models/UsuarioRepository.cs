using System;
using System.Collections.Generic;
using MySqlConnector;

namespace PossoBeber.Models
{
    public class UsuarioRepository
    {        
        private const string DadosConexao = "Database=PossoBeber;Data Source=localhost; User Id=root;";
        public void TestarConexao(){

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();
            Console.WriteLine("Banco de dados Usuario Funcionando");
            Conexao.Close();

        }

        //Login validação
        public Usuario ValidarLogin(Usuario usuario){

            //abrir conexão com banco de dados
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            //criar um usuario vazio com null
            Usuario usuarioEncontrado = null;

            //criando comando de SQL
            String Query = "SELECT * FROM Usuario WHERE Login=@Login and Senha=@Senha";
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);

            //validação de segurança de valor informado
            Comando.Parameters.AddWithValue("@Login",usuario.Login);
            Comando.Parameters.AddWithValue("@Senha",usuario.Senha);

            //executa o comando e guarda as informaçoes retornadas no objeto da classe MySqleDataReader
            MySqlDataReader Reader = Comando.ExecuteReader();

            if (Reader.Read()){

                usuarioEncontrado = new Usuario();

                usuarioEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome"))){
                    usuarioEncontrado.Nome = Reader.GetString("Nome");
                }
                if (!Reader.IsDBNull(Reader.GetOrdinal("Email"))){
                    usuarioEncontrado.Email = Reader.GetString("Email");
                }
                if (!Reader.IsDBNull(Reader.GetOrdinal("Login"))){
                    usuarioEncontrado.Login = Reader.GetString("Login");
                }
                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha"))){
                    usuarioEncontrado.Senha = Reader.GetString("Senha");
                }                
            }

            //fechar a conexao com banco de dados
            Conexao.Close();

            //retorna o usuario ou null
            return usuarioEncontrado;

        }

        //4 metodos para CRUD inserir, alterar, listar e excluir Usuarios no banco de dados
        public void inserir(Usuario novoUser){

            //abrir conexão com banco de dados
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            //criando comando de SQL 
            String Query = "INSERT INTO Usuario (Nome,Email,Login,Senha) VALUES (@Nome,@Email,@Login,@Senha)";
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);

            //validação de segurança de valor informado
            Comando.Parameters.AddWithValue("@Nome",novoUser.Nome);
            Comando.Parameters.AddWithValue("@Email",novoUser.Email);
            Comando.Parameters.AddWithValue("@Login",novoUser.Login);
            Comando.Parameters.AddWithValue("@Senha",novoUser.Senha);            
                        
            //executa o comando
            Comando.ExecuteNonQuery();

            //fechar a conexao com banco de dados
            Conexao.Close();

        }
        public void atualizar(Usuario user){

            //abrir conexão com banco de dados
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            //criando comando de SQL 
            String Query = "UPDATE Usuario SET Nome=@Nome, Email=@Email, Login=@Login, Senha=@Senha WHERE Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);

            //validação de segurança de valor informado
            Comando.Parameters.AddWithValue("@Nome",user.Nome);
            Comando.Parameters.AddWithValue("@Email",user.Email);
            Comando.Parameters.AddWithValue("@Login",user.Login);
            Comando.Parameters.AddWithValue("@Senha",user.Senha);            
            Comando.Parameters.AddWithValue("@Id",user.Id);
            
            //executa o comando
            Comando.ExecuteNonQuery();

            //fechar a conexao com banco de dados
            Conexao.Close();

        }
        public void remover(Usuario user){

            //abrir conexão com banco de dados
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            //criando comando de SQL 
            String Query = "DELETE FROM Usuario WHERE Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);

            //validação de segurança de valor informado
            Comando.Parameters.AddWithValue("@Id",user.Id);
            
            //executa o comando
            Comando.ExecuteNonQuery();

            //fechar a conexao com banco de dados
            Conexao.Close();

        }
        public Usuario Buscar(int Id){

            //abrir conexão com banco de dados
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            //criar um usuario vazio
            Usuario usuarioEncontrado = new Usuario();

            //criando comando de SQL
            String Query = "SELECT * FROM Usuario WHERE Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);

            //validação de segurança de valor informado
            Comando.Parameters.AddWithValue("@Id",Id);

            //executa o comando e guarda as informaçoes retornadas no objeto da classe MySqleDataReader
            MySqlDataReader Reader = Comando.ExecuteReader();

            if (Reader.Read()){

                usuarioEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome"))){
                    usuarioEncontrado.Nome = Reader.GetString("Nome");
                }
                if (!Reader.IsDBNull(Reader.GetOrdinal("Email"))){
                    usuarioEncontrado.Email = Reader.GetString("Email");
                }
                if (!Reader.IsDBNull(Reader.GetOrdinal("Login"))){
                    usuarioEncontrado.Login = Reader.GetString("Login");
                }
                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha"))){
                    usuarioEncontrado.Senha = Reader.GetString("Senha");
                }                
            }

            //fechar a conexao com banco de dados
            Conexao.Close();

            //retorno o usuario
            return usuarioEncontrado;

        }
        public List<Usuario> Listar(){

            //abrir conexão com banco de dados
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            //criando a lista de dados vazia
            List<Usuario> ListaDeUsuarios = new List<Usuario>();

            //criando comando de SQL 
            String Query = "SELECT * FROM   Usuario";

            //infroma uma Query do objeto Conexao
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);

            //executa o comando e guarda as informaçoes no objeto da classe MySqlDataReader
            MySqlDataReader Reader = Comando.ExecuteReader();

            //percorrer registro a registro o Reader retornado
            while(Reader.Read()){

                Usuario UsuarioEncontrado = new Usuario();

                UsuarioEncontrado.Id = Reader.GetInt32("Id");

                //tratativa para não permitir inserir na lista dados null
                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome"))){
                    UsuarioEncontrado.Nome = Reader.GetString("Nome");
                }
                if (!Reader.IsDBNull(Reader.GetOrdinal("Email"))){
                    UsuarioEncontrado.Email = Reader.GetString("Email");
                }
                //tratativa para não permitir inserir na lista dados null
                if (!Reader.IsDBNull(Reader.GetOrdinal("Login"))){
                    UsuarioEncontrado.Login = Reader.GetString("Login");
                }
                //tratativa para não permitir inserir na lista dados null
                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha"))){
                    UsuarioEncontrado.Senha = Reader.GetString("Senha");
                }   

                ListaDeUsuarios.Add(UsuarioEncontrado);
            }

            //fechar a conexao com banco de dados
            Conexao.Close();

            //retorno a lista
            return ListaDeUsuarios;
        }
    }
}