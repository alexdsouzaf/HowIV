using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySqlConnector;

namespace CRUDPadaria
{
    class clsProduto : ICadastro
    {

        public SqlCommand oComando = new SqlCommand();

        public HowIV.frmProduto frmProduto
        {
            get => default;
            set
            {
            }
        }

        internal clsValidacoesSQL clsValidacoesSQL
        {
            get => default;
            set
            {
            }
        }

        clsProduto ICadastro.clsProduto { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// ALTERA SOMENTE DESCRICAO E VALOR
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pDescricao"></param>
        /// <param name="pValor"></param>
        public void AlterarProduto(string pId, string pObs = "", string pValor = "")
        {
            try
            {
                StringBuilder sbSQL = new StringBuilder();
                sbSQL.AppendLine(" UPDATE PRODUTO ");
                sbSQL.AppendLine($" SET OBS = '{pObs}' , ");
                sbSQL.AppendLine($" VAL_UN = {pValor} ");
                sbSQL.AppendLine($" WHERE ID = {pId} ");

                Util.ExecutaSQL(sbSQL.ToString());
            }
            catch (Exception ex)
            {
                Util.ErroComandos(ex.Message);
                //throw;
            }
            //throw new NotImplementedException();
        }

        /// <summary>
        /// TALVEZ CAIA EM DESUSO
        /// </summary>
        /// <returns></returns>
        public SqlConnection Conexao()
        {
            try
            {
                SqlConnection conexao = new SqlConnection("");
                conexao.Open();
                return conexao;
            }
            catch (Exception ex)
            {
                
                Util.ErroComandos(ex.Message);
                throw;
            }
            //throw new NotImplementedException();
        }


        
        /// <summary>
        /// CONSULTA OS PRODUTOS GRAVADOS
        /// </summary>
        /// <param name="pId"></param>
        public SqlDataReader ConsultarProduto(string pId = "" )
        {
            try
            {
                StringBuilder sbSQL = new StringBuilder();
                sbSQL.AppendLine("SELECT * FROM PRODUTO");
                
                if (pId != string.Empty)
                    sbSQL.AppendLine($"WHERE ID = {pId}");



                return Util.ExecutaSQL(sbSQL.ToString());
            }
            catch (Exception ex)
            {
                Util.ErroComandos(ex.Message);
                throw null;
            }
            //throw new NotImplementedException();
        }
        
        /// <summary>
        /// GRAVA UM NOVO PRODUTO NO BANCO
        /// </summary>
        /// <param name="pNome"></param>
        /// <param name="pDescricao"></param>
        /// <param name="pValor"></param>
        /// <param name="pVinculoEstoque"></param>
        /// <param name="pQuantidade"></param>
        public void GravarProduto(string pNome = "", string pDescricao = "", string pValor = "", int pVinculoEstoque = 1, int pQuantidade = 0)
        {
            try
            {
                DateTime dt = DateTime.Now;
                string data = dt.ToString("yyy-MM-dd HH:mm:ss");
                StringBuilder sbSQL = new StringBuilder();
                sbSQL.AppendLine("INSERT INTO PRODUTO");
                sbSQL.AppendLine("(NOME,OBS,QUANTIDADE, DATA_CADASTRO, VAL_UN, VINCULO_ESTOQUE)");
                sbSQL.AppendLine("VALUES");
                sbSQL.AppendLine($"('{pNome}','{pDescricao}',{pQuantidade},'{data}',{pValor},'{pVinculoEstoque}');");
                                
                Util.ExecutaSQL(sbSQL.ToString());
            }
            catch (Exception ex)
            {
                Util.ErroComandos(ex.Message);
                //throw;
            }
            //throw new NotImplementedException();
        }
        
        /// <summary>
        /// REMOVE UM PRODUTO PERMANENTEMENTE DO BANCO
        /// </summary>
        /// <param name="pId"></param>
        public void RemoverProduto(string pId)
        {
            try
            {
                if (clsValidacoesSQL.PermiteRemover(pId))
                {
                    StringBuilder sbSQL = new StringBuilder();
                    sbSQL.AppendLine("DELETE FROM PRODUTO");
                    sbSQL.AppendLine($"WHERE ID = {pId}");

                    Util.ExecutaSQL(sbSQL.ToString());
                }

            }
            catch (Exception ex)
            {
                Util.ErroComandos(ex.Message);
                //throw;
            }
            //throw new NotImplementedException();
        }
    }
}
