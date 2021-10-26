using CRUDPadaria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowIV
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            clsProduto oProduto = new clsProduto();
            oProduto.RemoverProduto(txtId.Text);
            Util.AcaoConcluida();
            Util.conexao.Close();
            LimparCampos();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            clsProduto oProduto = new clsProduto();
            var oRetorno = oProduto.ConsultarProduto(txtId.Text);
            grdProduto.Rows.Clear();
            while (oRetorno.Read())
            {
                DataGridViewRow linha = (DataGridViewRow)grdProduto.Rows[0].Clone();
                linha.Cells[0].Value = oRetorno.GetInt32(0);
                linha.Cells[1].Value = oRetorno.GetString(1);
                linha.Cells[2].Value = oRetorno.IsDBNull(2) ? string.Empty : oRetorno.GetString(2);
                linha.Cells[3].Value = oRetorno.GetInt32(3);
                linha.Cells[4].Value = oRetorno.GetDateTime(4);
                linha.Cells[5].Value = oRetorno.GetDouble(5);
                linha.Cells[6].Value = oRetorno.GetInt32(6);
                grdProduto.Rows.Add(linha);
            }
            Util.AcaoConcluida();
            Util.conexao.Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            clsProduto oProduto = new clsProduto();
            oProduto.GravarProduto(txtDesc.Text, txtObs.Text, txtVal.Text, txtEst.Text, Convert.ToInt32(txtQuant.Text));
            Util.AcaoConcluida();
            Util.conexao.Close();
            LimparCampos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Util.AcaoConcluida();
            Util.conexao.Close();
        }

        private void grdProduto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //TEM QUE ARRUAMR ISSO AQUI
            //if (grdProduto.Columns.Contains("ID"))
            //{
            LimparCampos();
            clsProduto oProduto = new clsProduto();
            var oRetorno = oProduto.ConsultarProduto(txtId.Text);

            while (oRetorno.Read())
            {
                txtId.Text = oRetorno.GetInt32(0).ToString();
                txtDesc.Text = oRetorno.GetString(1);
                txtObs.Text = oRetorno.IsDBNull(2) ? string.Empty : oRetorno.GetString(2);
                txtQuant.Text = oRetorno.GetInt32(3).ToString();
                txtData.Text = oRetorno.GetDateTime(4).ToString();
                txtVal.Text = oRetorno.GetDouble(5).ToString();
                txtEst.Text = oRetorno.GetInt32(6).ToString();

            }
            Util.conexao.Close();
            tabControl1.SelectedTab = tabPage2;
            btnAlterar.Visible = true;
            btnGravar.Visible = false;
            //}
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtDesc.Clear();
            txtObs.Clear();
            txtQuant.Clear();
            txtData.Clear();
            txtVal.Clear();
            txtEst.Clear();
        }
    
    }
}
