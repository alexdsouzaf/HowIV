using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySqlConnector;

namespace CRUDPadaria
{
    class Util
    {
        public static SqlConnection conexao { get; set; }
        //private static string sConnectionString = "server = localhost; user id = root; database = db_how;  Password=usandopraestudar; ConvertZeroDateTime=True ";
        private static string sConnectionStringDBHOW = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Directory.GetCurrentDirectory()}\DB_TESTE.mdf;Integrated Security=True";
        /// <summary>
        /// MENSAGEM DE RETORNO QUANDO UM ERRO REFERENTE AOS SQL ACONTECER
        /// </summary>
        /// <param name="pException"></param>
        public static void ErroComandos(string pException)
        {
            MessageBox.Show("Ocorreu um erro ao executar o SQL.\r\n" + pException);
        }

        /// <summary>
        /// METODO ONDE SERAO DE FATO EXECUTADOS OS COMANDOS PARA O BANCO DE DADOS | SQL
        /// </summary>
        /// <param name="pComando"></param>
        public static SqlDataReader ExecutaSQL(string pComando)
        {
            try
            {
                conexao = new SqlConnection(sConnectionStringDBHOW);

                //string s = Directory.GetCurrentDirectory();                    

                SqlCommand oComando = new SqlCommand(pComando, conexao);
                conexao.Open();
                SqlDataReader oReader = oComando.ExecuteReader();                
                return oReader;


            }
            catch (Exception ex)
            {
                ErroComandos(ex.Message);
                throw;
            }            
        }

        /// <summary>
        /// METODO ONDE SERAO DE FATO EXECUTADOS OS COMANDOS PARA O BANCO DE DADOS | MYSQL WORKBENCH
        /// </summary>
        //public static MySqlDataReader ExecutaMySQL(string pComando)
        //{
        //    try
        //    {
        //        MySqlConnection conexao = new MySqlConnection(sConnectionString);
                
        //        MySqlCommand oComando = new MySqlCommand(pComando, conexao);
        //        conexao.Open();
        //        return oComando.ExecuteReader();
                
        //    }
        //    catch (Exception ex)
        //    {
        //        ErroComandos(ex.Message);
        //        throw;
        //    }
        //}


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pException"></param>
        public static void Invalidacoes( string pSbMensagem )
        {
            MessageBox.Show("Não foi possível continuar o processo por um ou mais motivos: \r\n" + pSbMensagem);
        }
    }
}
