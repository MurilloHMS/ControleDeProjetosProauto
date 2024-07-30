namespace ControleDeProjetosProauto.Views.Forms
{
    partial class Frm_Busca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Busca));
            panel1 = new Panel();
            toolStrip1 = new ToolStrip();
            novaToolStripButton = new ToolStripButton();
            abrirToolStripButton = new ToolStripButton();
            salvarToolStripButton = new ToolStripButton();
            imprimirToolStripButton = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            recortarToolStripButton = new ToolStripButton();
            copiarToolStripButton = new ToolStripButton();
            colarToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            ajudaToolStripButton = new ToolStripButton();
            groupBox1 = new GroupBox();
            cbStatusProjeto = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            dgvDadosProdutos = new DataGridView();
            pRONIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pROSNPRODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pRODDATCADDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pROSDESPRODataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pROCSTATDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pROSOBRIGDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            projetosBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDadosProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)projetosBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(toolStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(728, 27);
            panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { novaToolStripButton, abrirToolStripButton, salvarToolStripButton, imprimirToolStripButton, toolStripSeparator, recortarToolStripButton, copiarToolStripButton, colarToolStripButton, toolStripSeparator1, ajudaToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(728, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // novaToolStripButton
            // 
            novaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            novaToolStripButton.Image = (Image)resources.GetObject("novaToolStripButton.Image");
            novaToolStripButton.ImageTransparentColor = Color.Magenta;
            novaToolStripButton.Name = "novaToolStripButton";
            novaToolStripButton.Size = new Size(23, 22);
            novaToolStripButton.Text = "&Nova";
            // 
            // abrirToolStripButton
            // 
            abrirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            abrirToolStripButton.Image = (Image)resources.GetObject("abrirToolStripButton.Image");
            abrirToolStripButton.ImageTransparentColor = Color.Magenta;
            abrirToolStripButton.Name = "abrirToolStripButton";
            abrirToolStripButton.Size = new Size(23, 22);
            abrirToolStripButton.Text = "&Abrir";
            // 
            // salvarToolStripButton
            // 
            salvarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            salvarToolStripButton.Image = (Image)resources.GetObject("salvarToolStripButton.Image");
            salvarToolStripButton.ImageTransparentColor = Color.Magenta;
            salvarToolStripButton.Name = "salvarToolStripButton";
            salvarToolStripButton.Size = new Size(23, 22);
            salvarToolStripButton.Text = "&Salvar";
            // 
            // imprimirToolStripButton
            // 
            imprimirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            imprimirToolStripButton.Image = (Image)resources.GetObject("imprimirToolStripButton.Image");
            imprimirToolStripButton.ImageTransparentColor = Color.Magenta;
            imprimirToolStripButton.Name = "imprimirToolStripButton";
            imprimirToolStripButton.Size = new Size(23, 22);
            imprimirToolStripButton.Text = "&Imprimir";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 25);
            // 
            // recortarToolStripButton
            // 
            recortarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            recortarToolStripButton.Image = (Image)resources.GetObject("recortarToolStripButton.Image");
            recortarToolStripButton.ImageTransparentColor = Color.Magenta;
            recortarToolStripButton.Name = "recortarToolStripButton";
            recortarToolStripButton.Size = new Size(23, 22);
            recortarToolStripButton.Text = "R&ecortar";
            // 
            // copiarToolStripButton
            // 
            copiarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            copiarToolStripButton.Image = (Image)resources.GetObject("copiarToolStripButton.Image");
            copiarToolStripButton.ImageTransparentColor = Color.Magenta;
            copiarToolStripButton.Name = "copiarToolStripButton";
            copiarToolStripButton.Size = new Size(23, 22);
            copiarToolStripButton.Text = "&Copiar";
            // 
            // colarToolStripButton
            // 
            colarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            colarToolStripButton.Image = (Image)resources.GetObject("colarToolStripButton.Image");
            colarToolStripButton.ImageTransparentColor = Color.Magenta;
            colarToolStripButton.Name = "colarToolStripButton";
            colarToolStripButton.Size = new Size(23, 22);
            colarToolStripButton.Text = "&Colar";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // ajudaToolStripButton
            // 
            ajudaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ajudaToolStripButton.Image = (Image)resources.GetObject("ajudaToolStripButton.Image");
            ajudaToolStripButton.ImageTransparentColor = Color.Magenta;
            ajudaToolStripButton.Name = "ajudaToolStripButton";
            ajudaToolStripButton.Size = new Size(23, 22);
            ajudaToolStripButton.Text = "Aju&da";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbStatusProjeto);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(704, 95);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ferramentas de Busca";
            // 
            // cbStatusProjeto
            // 
            cbStatusProjeto.FormattingEnabled = true;
            cbStatusProjeto.Location = new Point(535, 47);
            cbStatusProjeto.Name = "cbStatusProjeto";
            cbStatusProjeto.Size = new Size(163, 23);
            cbStatusProjeto.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(421, 47);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(108, 23);
            dateTimePicker2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(535, 29);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 1;
            label4.Text = "Status Projeto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(421, 29);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 1;
            label3.Text = "Data Entrega";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(307, 47);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(108, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 29);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 1;
            label2.Text = "Data Cadastro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 32);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(279, 23);
            textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDadosProdutos);
            groupBox2.Location = new Point(12, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(704, 359);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados";
            // 
            // dgvDadosProdutos
            // 
            dgvDadosProdutos.AutoGenerateColumns = false;
            dgvDadosProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDadosProdutos.Columns.AddRange(new DataGridViewColumn[] { pRONIDDataGridViewTextBoxColumn, pROSNPRODataGridViewTextBoxColumn, pRODDATCADDataGridViewTextBoxColumn, pROSDESPRODataGridViewTextBoxColumn, pROCSTATDataGridViewTextBoxColumn, pROSOBRIGDataGridViewTextBoxColumn });
            dgvDadosProdutos.DataSource = projetosBindingSource;
            dgvDadosProdutos.Dock = DockStyle.Fill;
            dgvDadosProdutos.Location = new Point(3, 19);
            dgvDadosProdutos.Name = "dgvDadosProdutos";
            dgvDadosProdutos.Size = new Size(698, 337);
            dgvDadosProdutos.TabIndex = 0;
            // 
            // pRONIDDataGridViewTextBoxColumn
            // 
            pRONIDDataGridViewTextBoxColumn.DataPropertyName = "PRONID";
            pRONIDDataGridViewTextBoxColumn.HeaderText = "PRONID";
            pRONIDDataGridViewTextBoxColumn.Name = "pRONIDDataGridViewTextBoxColumn";
            // 
            // pROSNPRODataGridViewTextBoxColumn
            // 
            pROSNPRODataGridViewTextBoxColumn.DataPropertyName = "PROSNPRO";
            pROSNPRODataGridViewTextBoxColumn.HeaderText = "PROSNPRO";
            pROSNPRODataGridViewTextBoxColumn.Name = "pROSNPRODataGridViewTextBoxColumn";
            // 
            // pRODDATCADDataGridViewTextBoxColumn
            // 
            pRODDATCADDataGridViewTextBoxColumn.DataPropertyName = "PRODDATCAD";
            pRODDATCADDataGridViewTextBoxColumn.HeaderText = "PRODDATCAD";
            pRODDATCADDataGridViewTextBoxColumn.Name = "pRODDATCADDataGridViewTextBoxColumn";
            // 
            // pROSDESPRODataGridViewTextBoxColumn
            // 
            pROSDESPRODataGridViewTextBoxColumn.DataPropertyName = "PROSDESPRO";
            pROSDESPRODataGridViewTextBoxColumn.HeaderText = "PROSDESPRO";
            pROSDESPRODataGridViewTextBoxColumn.Name = "pROSDESPRODataGridViewTextBoxColumn";
            // 
            // pROCSTATDataGridViewTextBoxColumn
            // 
            pROCSTATDataGridViewTextBoxColumn.DataPropertyName = "PROCSTAT";
            pROCSTATDataGridViewTextBoxColumn.HeaderText = "PROCSTAT";
            pROCSTATDataGridViewTextBoxColumn.Name = "pROCSTATDataGridViewTextBoxColumn";
            // 
            // pROSOBRIGDataGridViewTextBoxColumn
            // 
            pROSOBRIGDataGridViewTextBoxColumn.DataPropertyName = "PROSOBRIG";
            pROSOBRIGDataGridViewTextBoxColumn.HeaderText = "PROSOBRIG";
            pROSOBRIGDataGridViewTextBoxColumn.Name = "pROSOBRIGDataGridViewTextBoxColumn";
            // 
            // projetosBindingSource
            // 
            projetosBindingSource.DataSource = typeof(Models.Projetos);
            // 
            // Frm_Busca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 516);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Frm_Busca";
            Text = "Frm_Busca";
            Load += Frm_Busca_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDadosProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)projetosBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private DataGridView dgvDadosProdutos;
        private DataGridViewTextBoxColumn pRONIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pROSNPRODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pRODDATCADDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pROSDESPRODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pROCSTATDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pROSOBRIGDataGridViewTextBoxColumn;
        private BindingSource projetosBindingSource;
        private ToolStrip toolStrip1;
        private ToolStripButton novaToolStripButton;
        private ToolStripButton abrirToolStripButton;
        private ToolStripButton salvarToolStripButton;
        private ToolStripButton imprimirToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton recortarToolStripButton;
        private ToolStripButton copiarToolStripButton;
        private ToolStripButton colarToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton ajudaToolStripButton;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private ComboBox cbStatusProjeto;
        private Label label4;
    }
}