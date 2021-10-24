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



        /// <summary>
        /// PARA USAR O BANCO LOCAL DÊ DUPLO CLIQUE EM DB_TESTE NO GERENCIADOR DE SOLUÇÕES, NO GERENCIADO DE SERVIDORES ENTRE NAS PROPRIEDADES DE DB_TESTE.
        /// PEGUE A CADEIA DE CONEXAO SUBSTITUIA NA STRING ABAIXO.
        /// </summary>
        private static string sConnectionStringDBHOW = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Userwin\source\repos\HowIV\DB_TESTE.mdf;Integrated Security=True";
        
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

                SqlCommand oComando = new SqlCommand(pComando);
                conexao.Open();
                oComando.Connection = conexao;
                oComando.ExecuteNonQuery();
                SqlDataReader oReader = oComando.ExecuteReader();

                //SqlCommand oCmd = new SqlCommand(sCmd);
                //Conexao.Open();
                //oCmd.Connection = Conexao;
                //oCmd.ExecuteNonQuery();
                //leitor = oCmd.ExecuteReader();
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
