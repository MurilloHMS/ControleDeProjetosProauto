using ControleDeProjetosProauto.Models;
using ControleDeProjetosProauto.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeProjetosProauto.Views.Forms
{
    public partial class Frm_Busca : Form
    {
        public Frm_Busca()
        {
            InitializeComponent();
        }

        

        private void PreencherDados()
        {
            ProjetoService projetoService = new ProjetoService(new ProjetoRepository());
            
            Projetos projetos = new Projetos();
            IEnumerable<Projetos> dados = projetoService.GetAll();
            
            dgvDadosProdutos.DataSource = dados;
        }

        private void Frm_Busca_Load(object sender, EventArgs e)
        {
            cbStatusProjeto.DataSource = Enum.GetValues(typeof(E_StatusProjeto));
            PreencherDados();
        }
    }
}
