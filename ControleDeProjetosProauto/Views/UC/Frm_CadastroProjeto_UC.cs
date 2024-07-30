using ControleDeProjetosProauto.Models;
using ControleDeProjetosProauto.Models.Enums;
using ControleDeProjetosProauto.Setup.DataBase;
using ControleDeProjetosProauto.Views.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeProjetosProauto.Views
{
    public partial class Frm_CadastroProjeto_UC : UserControl
    {
        public Frm_CadastroProjeto_UC()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                ProjetoService projetoService = new ProjetoService(new ProjetoRepository());

                Projetos projeto = ColetarDados();

                projetoService.Incluir(projeto);
                LimparFormulario();
                MessageBox.Show("Dados incluidos com sucesso!", "Conclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao salvar o projeto/n/nCódito de erro: {ex.HResult}\nInnerException: {ex.InnerException}\nMensagem de erro: {ex.Message}",
                    $"Error Handle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private Projetos ColetarDados()
        {
            E_StatusProjeto status;
            Projetos p = new Projetos();
            if (tbID.Text.Trim().Length > 0)
            {
                p.PRONID = int.Parse(tbID.Text.Trim());
            }

            p.PROSNPRO = tbNomeProjeto.Text.Trim();
            p.PROSDESPRO = tbDescritivo.Text.Trim();
            p.PRODDATCAD = DateTime.Parse(dtpDataCadastro.Text.Trim());
            p.PROSOBRIG = tbObrigacoes.Text.Trim();
            Enum.TryParse<E_StatusProjeto>(cbStatusProjeto.SelectedValue.ToString(), out status);
            p.PROCSTAT = (char)status;
            

            return p;

        }

        #region Metodos

        private void LimparFormulario()
        {
            tbID.Clear();
            tbNomeProjeto.Clear();
            tbDescritivo.Clear();
            tbObrigacoes.Clear();
            dtpDataCadastro.Value = DateTime.Now;
            cbStatusProjeto.SelectedIndex = -1;
        }

        #endregion

        private void btnBusca_Click(object sender, EventArgs e)
        {
            Frm_Busca busca = new Frm_Busca();
            busca.ShowDialog();
        }

        private void Frm_CadastroProjeto_UC_Load(object sender, EventArgs e)
        {
            cbStatusProjeto.DisplayMember = "Value";  // Exibir o valor amigável para o usuário
            cbStatusProjeto.ValueMember = "Key";     // O valor real associado ao enum
            cbStatusProjeto.DataSource = Enum.GetValues(typeof(E_StatusProjeto))
                .Cast<E_StatusProjeto>()
                .Select(e => new { Key = e, Value = e.ToString() })
                .ToList();
        }
    }
}
