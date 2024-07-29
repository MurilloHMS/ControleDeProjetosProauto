using ControleDeProjetosProauto.Models;
using ControleDeProjetosProauto.Setup.DataBase;
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
            }catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao salvar o projeto/n/nCódito de erro: {ex.HResult}\nInnerException: {ex.InnerException}\nMensagem de erro: {ex.Message}",
                    $"Error Handle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            
            
        }

        private Projetos ColetarDados()
        {
            Projetos p = new Projetos();
            if (tbID.Text.Trim().Length > 0)
            {
                p.PRONID = int.Parse(tbID.Text.Trim());
            }

            p.PROSNPRO = tbNomeProjeto.Text.Trim();
            p.PROSDESPRO = tbDescritivo.Text.Trim();
            p.PRODDATCAD = DateTime.Parse(dtpDataCadastro.Text.Trim());
            p.PROSOBRIG = tbObrigacoes.Text.Trim();

            switch (cbStatusProjeto.SelectedItem.ToString())
            {
                case "Iniciar":
                    p.PROCSTAT = 'I';
                    break;
                case "Em andamento":
                    p.PROCSTAT = 'A';
                    break;
                case "Finalizado":
                    p.PROCSTAT = 'F';
                    break;
            }

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
    }
}
