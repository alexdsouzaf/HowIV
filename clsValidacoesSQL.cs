using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDPadaria
{
    class clsValidacoesSQL
    {
        public static bool PermiteAlterar(string pId, string pDescricao = "", string pValor = "")
        {
            throw new NotImplementedException();
        }

        public static bool PermiteGravar(string pNome = "", string pDescricao = "", string pValor = "", string pVinculoEstoque = "", int pQuantidade = 0)
        {
            throw new NotImplementedException();
        }

        public static bool PermiteRemover(string pId)
        {
            bool bRetorno = true;
            StringBuilder sbMensagem = new StringBuilder();

            if (pId == string.Empty)
                sbMensagem.AppendLine(" - A Id não pode ser um valor em branco");

            if (pId == null)
                sbMensagem.AppendLine(" - A Id não pode ser nula");

            if (sbMensagem.ToString() != string.Empty)
            {
                bRetorno = false;
                Util.Invalidacoes(sbMensagem.ToString());
            }

            return bRetorno;
            //throw new NotImplementedException();
        }
    }
}
