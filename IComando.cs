using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//using MySqlConnector;

namespace CRUDPadaria
{
    /// <summary>
    /// INTERFACE GENERICA PARA SER PAU PRA TODA OBRA NO SISTEMA
    /// </summary>
    interface ICadastro
    {
        /// <summary>
        /// METODO PARA GRAVAR O PRODUTO NO BANCO
        /// </summary>
        /// <param name="pNome"></param>
        /// <param name="pDescricao"></param>
        /// <param name="pValor"></param>
        /// <param name="pVinculoEstoque"></param>
        /// <param name="pQuantidade"></param>
        void GravarProduto(string pNome = "", string pDescricao = "", string pValor = "", string pVinculoEstoque = "", int pQuantidade = 0);
        /// <summary>
        /// METODO PARA ALTERAR O PRODUTO NO BANCO
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pDescricao"></param>
        /// <param name="pValor"></param>
        void AlterarProduto(string pId, string pDescricao = "", string pValor = "");
        /// <summary>
        /// METODO PARA CONSULTAR O PRODUTO NO BANCO
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        SqlDataReader ConsultarProduto(string pId = "");
        /// <summary>
        /// METODO PARA REMOVER O PRODUTO NO BANCO
        /// </summary>
        /// <param name="pId"></param>
        void RemoverProduto(string pId);
        /// <summary>
        /// METODO PARA CONECTAR NO BANCO
        /// </summary>
        /// <returns></returns>
        SqlConnection Conexao();
    }
}
