namespace Diario_De_Bordo_DSM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            btn_salvar = new ToolStripButton();
            lbl_salvar = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            btn_editar = new ToolStripButton();
            lbl_editar = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            btn_todos = new ToolStripButton();
            lbl_todos = new ToolStripLabel();
            toolStripSeparator3 = new ToolStripSeparator();
            btn_favoritos = new ToolStripButton();
            lbl_favoritos = new ToolStripLabel();
            toolStripSeparator4 = new ToolStripSeparator();
            btn_excluir = new ToolStripButton();
            lbl_excluir = new ToolStripLabel();
            toolStripSeparator5 = new ToolStripSeparator();
            btn_config = new ToolStripButton();
            lbl_conexao = new ToolStripLabel();
            toolStripSeparator6 = new ToolStripSeparator();
            btn_sair = new ToolStripButton();
            lbl_sair = new ToolStripLabel();
            pnl_home = new Panel();
            groupBox2 = new GroupBox();
            btn_pesq = new Button();
            txt_pesq_numero = new TextBox();
            txt_pesq_nome = new TextBox();
            label4 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            txt_cad_numero = new TextBox();
            label2 = new Label();
            txt_cad_descricao = new TextBox();
            label1 = new Label();
            toolStrip1.SuspendLayout();
            pnl_home.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_salvar, lbl_salvar, toolStripSeparator1, btn_editar, lbl_editar, toolStripSeparator2, btn_todos, lbl_todos, toolStripSeparator3, btn_favoritos, lbl_favoritos, toolStripSeparator4, btn_excluir, lbl_excluir, toolStripSeparator5, btn_config, lbl_conexao, toolStripSeparator6, btn_sair, lbl_sair });
            toolStrip1.Location = new Point(0, 409);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(663, 41);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_salvar
            // 
            btn_salvar.AutoSize = false;
            btn_salvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_salvar.Image = (Image)resources.GetObject("btn_salvar.Image");
            btn_salvar.ImageScaling = ToolStripItemImageScaling.None;
            btn_salvar.ImageTransparentColor = Color.Magenta;
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(35, 35);
            btn_salvar.Text = "toolStripButton1";
            btn_salvar.ToolTipText = "Salvar novo registro";
            btn_salvar.Click += btn_salvar_Click;
            // 
            // lbl_salvar
            // 
            lbl_salvar.Name = "lbl_salvar";
            lbl_salvar.Size = new Size(38, 38);
            lbl_salvar.Text = "Salvar";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 41);
            // 
            // btn_editar
            // 
            btn_editar.AutoSize = false;
            btn_editar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_editar.Image = (Image)resources.GetObject("btn_editar.Image");
            btn_editar.ImageScaling = ToolStripItemImageScaling.None;
            btn_editar.ImageTransparentColor = Color.Magenta;
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(35, 35);
            btn_editar.Text = "toolStripButton1";
            btn_editar.ToolTipText = "Editar registro anterior";
            // 
            // lbl_editar
            // 
            lbl_editar.Name = "lbl_editar";
            lbl_editar.Size = new Size(37, 38);
            lbl_editar.Text = "Editar";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 41);
            // 
            // btn_todos
            // 
            btn_todos.AutoSize = false;
            btn_todos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_todos.Image = (Image)resources.GetObject("btn_todos.Image");
            btn_todos.ImageScaling = ToolStripItemImageScaling.None;
            btn_todos.ImageTransparentColor = Color.Magenta;
            btn_todos.Name = "btn_todos";
            btn_todos.Size = new Size(35, 35);
            btn_todos.Text = "toolStripButton1";
            btn_todos.ToolTipText = "Buscar todos os registros";
            btn_todos.Click += btn_todos_Click;
            // 
            // lbl_todos
            // 
            lbl_todos.Name = "lbl_todos";
            lbl_todos.Size = new Size(75, 38);
            lbl_todos.Text = "Buscar todos";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 41);
            // 
            // btn_favoritos
            // 
            btn_favoritos.AutoSize = false;
            btn_favoritos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_favoritos.Image = (Image)resources.GetObject("btn_favoritos.Image");
            btn_favoritos.ImageScaling = ToolStripItemImageScaling.None;
            btn_favoritos.ImageTransparentColor = Color.Magenta;
            btn_favoritos.Name = "btn_favoritos";
            btn_favoritos.Size = new Size(35, 35);
            btn_favoritos.Text = "toolStripButton2";
            btn_favoritos.ToolTipText = "Buscar favoritos";
            // 
            // lbl_favoritos
            // 
            lbl_favoritos.Name = "lbl_favoritos";
            lbl_favoritos.Size = new Size(91, 38);
            lbl_favoritos.Text = "Buscar favoritos";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 41);
            // 
            // btn_excluir
            // 
            btn_excluir.AutoSize = false;
            btn_excluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_excluir.Image = (Image)resources.GetObject("btn_excluir.Image");
            btn_excluir.ImageScaling = ToolStripItemImageScaling.None;
            btn_excluir.ImageTransparentColor = Color.Magenta;
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(35, 35);
            btn_excluir.Text = "Excluir registro";
            // 
            // lbl_excluir
            // 
            lbl_excluir.Name = "lbl_excluir";
            lbl_excluir.Size = new Size(42, 38);
            lbl_excluir.Text = "Excluir";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 41);
            // 
            // btn_config
            // 
            btn_config.AutoSize = false;
            btn_config.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_config.Image = (Image)resources.GetObject("btn_config.Image");
            btn_config.ImageScaling = ToolStripItemImageScaling.None;
            btn_config.ImageTransparentColor = Color.Magenta;
            btn_config.Name = "btn_config";
            btn_config.Size = new Size(35, 35);
            btn_config.Text = "toolStripButton1";
            btn_config.ToolTipText = "Configurar conexão";
            // 
            // lbl_conexao
            // 
            lbl_conexao.Name = "lbl_conexao";
            lbl_conexao.Size = new Size(54, 38);
            lbl_conexao.Text = "Conexão";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 41);
            // 
            // btn_sair
            // 
            btn_sair.AutoSize = false;
            btn_sair.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_sair.Image = (Image)resources.GetObject("btn_sair.Image");
            btn_sair.ImageScaling = ToolStripItemImageScaling.None;
            btn_sair.ImageTransparentColor = Color.Magenta;
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(35, 35);
            btn_sair.Text = "Sair do sistema";
            btn_sair.Click += btn_sair_Click;
            // 
            // lbl_sair
            // 
            lbl_sair.Name = "lbl_sair";
            lbl_sair.Size = new Size(26, 38);
            lbl_sair.Text = "Sair";
            // 
            // pnl_home
            // 
            pnl_home.Controls.Add(groupBox2);
            pnl_home.Controls.Add(groupBox1);
            pnl_home.Location = new Point(0, 0);
            pnl_home.Name = "pnl_home";
            pnl_home.Size = new Size(662, 406);
            pnl_home.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_pesq);
            groupBox2.Controls.Add(txt_pesq_numero);
            groupBox2.Controls.Add(txt_pesq_nome);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(352, 61);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(273, 284);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pesquisa rápida";
            // 
            // btn_pesq
            // 
            btn_pesq.Location = new Point(44, 236);
            btn_pesq.Name = "btn_pesq";
            btn_pesq.Size = new Size(190, 23);
            btn_pesq.TabIndex = 5;
            btn_pesq.Text = "Pesquisa rápida";
            btn_pesq.UseVisualStyleBackColor = true;
            // 
            // txt_pesq_numero
            // 
            txt_pesq_numero.Location = new Point(6, 174);
            txt_pesq_numero.Name = "txt_pesq_numero";
            txt_pesq_numero.Size = new Size(261, 23);
            txt_pesq_numero.TabIndex = 4;
            // 
            // txt_pesq_nome
            // 
            txt_pesq_nome.Location = new Point(6, 97);
            txt_pesq_nome.Name = "txt_pesq_nome";
            txt_pesq_nome.Size = new Size(261, 23);
            txt_pesq_nome.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 156);
            label4.Name = "label4";
            label4.Size = new Size(145, 15);
            label4.TabIndex = 4;
            label4.Text = "Número do equipamento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 79);
            label3.Name = "label3";
            label3.Size = new Size(152, 15);
            label3.TabIndex = 4;
            label3.Text = "Descrição do equipamento:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_cad_numero);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_cad_descricao);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(34, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 284);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastrar nova máquina";
            // 
            // txt_cad_numero
            // 
            txt_cad_numero.Location = new Point(6, 174);
            txt_cad_numero.Name = "txt_cad_numero";
            txt_cad_numero.Size = new Size(258, 23);
            txt_cad_numero.TabIndex = 3;
            txt_cad_numero.TextChanged += txt_cad_numero_TextChanged;
            txt_cad_numero.KeyPress += txt_cad_numero_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 156);
            label2.Name = "label2";
            label2.Size = new Size(145, 15);
            label2.TabIndex = 2;
            label2.Text = "Número do equipamento:";
            // 
            // txt_cad_descricao
            // 
            txt_cad_descricao.Location = new Point(6, 97);
            txt_cad_descricao.Name = "txt_cad_descricao";
            txt_cad_descricao.Size = new Size(258, 23);
            txt_cad_descricao.TabIndex = 1;
            txt_cad_descricao.TextChanged += txt_cad_descricao_TextChanged;
            txt_cad_descricao.KeyPress += txt_cad_descricao_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 79);
            label1.Name = "label1";
            label1.Size = new Size(152, 15);
            label1.TabIndex = 0;
            label1.Text = "Descrição do equipamento:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 450);
            Controls.Add(pnl_home);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Diário de bordo";
            Load += Form1_Load_1;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            pnl_home.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btn_salvar;
        private ToolStripLabel lbl_salvar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btn_editar;
        private ToolStripLabel lbl_editar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btn_todos;
        private ToolStripLabel lbl_todos;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btn_favoritos;
        private ToolStripLabel lbl_favoritos;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btn_excluir;
        private ToolStripLabel lbl_excluir;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton btn_sair;
        private ToolStripLabel lbl_sair;
        private ToolStripButton btn_config;
        private ToolStripLabel lbl_conexao;
        private ToolStripSeparator toolStripSeparator6;
        private Panel pnl_home;
        private GroupBox groupBox1;
        private TextBox txt_cad_numero;
        private Label label2;
        private TextBox txt_cad_descricao;
        private Label label1;
        private GroupBox groupBox2;
        private Button btn_pesq;
        private TextBox txt_pesq_numero;
        private TextBox txt_pesq_nome;
        private Label label4;
        private Label label3;
    }
}