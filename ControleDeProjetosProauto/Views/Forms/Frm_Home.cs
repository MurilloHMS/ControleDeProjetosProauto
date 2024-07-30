using ControleDeProjetosProauto.Views;

namespace ControleDeProjetosProauto
{
    public partial class Frm_Home : Form
    {
        public Frm_Home()
        {
            InitializeComponent();
        }

        private void Frm_Home_Load(object sender, EventArgs e)
        {
            Frm_CadastroProjeto_UC frm = new Frm_CadastroProjeto_UC();
            frm.Dock = DockStyle.Fill;
            TabPage tb = new TabPage();
            tb.Name = "Home";
            tb.Text = "Cadastro projetos";
            tb.Controls.Add(frm);
            tabControl1.TabPages.Add(tb);
            
        }
    }
}
