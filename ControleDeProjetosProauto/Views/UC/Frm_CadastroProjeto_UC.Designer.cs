namespace ControleDeProjetosProauto.Views
{
    partial class Frm_CadastroProjeto_UC
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            btnInserir = new Button();
            cbStatusProjeto = new ComboBox();
            tbID = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            tbDescritivo = new TextBox();
            label2 = new Label();
            tbNomeProjeto = new TextBox();
            label3 = new Label();
            dtpDataCadastro = new DateTimePicker();
            tbObrigacoes = new TextBox();
            label4 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            btnBusca = new Button();
            btnDeletar = new Button();
            btnAtualizar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(38, 416);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 3;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // cbStatusProjeto
            // 
            cbStatusProjeto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatusProjeto.FormattingEnabled = true;
            cbStatusProjeto.Location = new Point(16, 169);
            cbStatusProjeto.Name = "cbStatusProjeto";
            cbStatusProjeto.Size = new Size(264, 23);
            cbStatusProjeto.TabIndex = 2;
            // 
            // tbID
            // 
            tbID.Location = new Point(16, 55);
            tbID.Name = "tbID";
            tbID.Size = new Size(62, 23);
            tbID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 37);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbDescritivo);
            groupBox1.Location = new Point(328, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 457);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Descritivo";
            // 
            // tbDescritivo
            // 
            tbDescritivo.Location = new Point(21, 34);
            tbDescritivo.Multiline = true;
            tbDescritivo.Name = "tbDescritivo";
            tbDescritivo.Size = new Size(337, 405);
            tbDescritivo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 92);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome do Projeto";
            // 
            // tbNomeProjeto
            // 
            tbNomeProjeto.Location = new Point(16, 110);
            tbNomeProjeto.Name = "tbNomeProjeto";
            tbNomeProjeto.Size = new Size(264, 23);
            tbNomeProjeto.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 37);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 0;
            label3.Text = "Data de Cadastro";
            // 
            // dtpDataCadastro
            // 
            dtpDataCadastro.Format = DateTimePickerFormat.Short;
            dtpDataCadastro.Location = new Point(183, 55);
            dtpDataCadastro.Name = "dtpDataCadastro";
            dtpDataCadastro.Size = new Size(97, 23);
            dtpDataCadastro.TabIndex = 5;
            // 
            // tbObrigacoes
            // 
            tbObrigacoes.Location = new Point(16, 225);
            tbObrigacoes.Multiline = true;
            tbObrigacoes.Name = "tbObrigacoes";
            tbObrigacoes.Size = new Size(264, 166);
            tbObrigacoes.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 207);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 0;
            label4.Text = "Obrigações";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 151);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 0;
            label5.Text = "Status do Projeto";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBusca);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(tbObrigacoes);
            groupBox2.Controls.Add(dtpDataCadastro);
            groupBox2.Controls.Add(btnDeletar);
            groupBox2.Controls.Add(btnAtualizar);
            groupBox2.Controls.Add(btnInserir);
            groupBox2.Controls.Add(cbStatusProjeto);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(tbID);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(tbNomeProjeto);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(18, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(304, 457);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // btnBusca
            // 
            btnBusca.Location = new Point(84, 55);
            btnBusca.Name = "btnBusca";
            btnBusca.Size = new Size(30, 23);
            btnBusca.TabIndex = 6;
            btnBusca.Text = "...";
            btnBusca.UseVisualStyleBackColor = true;
            btnBusca.Click += btnBusca_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(200, 416);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 23);
            btnDeletar.TabIndex = 3;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(119, 416);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 3;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // Frm_CadastroProjeto_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Frm_CadastroProjeto_UC";
            Size = new Size(705, 496);
            Load += Frm_CadastroProjeto_UC_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnInserir;
        private ComboBox cbStatusProjeto;
        private TextBox tbID;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox tbNomeProjeto;
        private Label label3;
        private DateTimePicker dtpDataCadastro;
        private TextBox tbDescritivo;
        private TextBox tbObrigacoes;
        private Label label4;
        private Label label5;
        private GroupBox groupBox2;
        private Button btnDeletar;
        private Button btnAtualizar;
        private Button btnBusca;
    }
}
