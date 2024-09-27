namespace Armazenador
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCada = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txb5 = new System.Windows.Forms.TextBox();
            this.txb4 = new System.Windows.Forms.TextBox();
            this.txb3 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.lbl10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txb10 = new System.Windows.Forms.TextBox();
            this.txb7 = new System.Windows.Forms.TextBox();
            this.txb6 = new System.Windows.Forms.TextBox();
            this.txb9 = new System.Windows.Forms.TextBox();
            this.txb8 = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblFilme = new System.Windows.Forms.Label();
            this.txbFilme = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.error = new System.Windows.Forms.Label();
            this.lblSenh = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnCadas = new System.Windows.Forms.Button();
            this.txbSenh = new System.Windows.Forms.TextBox();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(763, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LavenderBlush;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnCada);
            this.tabPage1.Controls.Add(this.lblSenha);
            this.tabPage1.Controls.Add(this.lblNome);
            this.tabPage1.Controls.Add(this.txbSenha);
            this.tabPage1.Controls.Add(this.txbNome);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(755, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "<Error>";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCada
            // 
            this.btnCada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCada.ForeColor = System.Drawing.Color.Black;
            this.btnCada.Location = new System.Drawing.Point(290, 190);
            this.btnCada.Name = "btnCada";
            this.btnCada.Size = new System.Drawing.Size(75, 23);
            this.btnCada.TabIndex = 4;
            this.btnCada.Text = "Cadastra";
            this.btnCada.UseVisualStyleBackColor = false;
            this.btnCada.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(275, 133);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(275, 71);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(84, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Insira seu nome:";
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(278, 149);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(100, 20);
            this.txbSenha.TabIndex = 1;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(278, 87);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LavenderBlush;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lbl5);
            this.tabPage2.Controls.Add(this.lbl4);
            this.tabPage2.Controls.Add(this.lbl3);
            this.tabPage2.Controls.Add(this.lbl2);
            this.tabPage2.Controls.Add(this.txb5);
            this.tabPage2.Controls.Add(this.txb4);
            this.tabPage2.Controls.Add(this.txb3);
            this.tabPage2.Controls.Add(this.lbl1);
            this.tabPage2.Controls.Add(this.txb2);
            this.tabPage2.Controls.Add(this.txb1);
            this.tabPage2.Controls.Add(this.lbl10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txb10);
            this.tabPage2.Controls.Add(this.txb7);
            this.tabPage2.Controls.Add(this.txb6);
            this.tabPage2.Controls.Add(this.txb9);
            this.tabPage2.Controls.Add(this.txb8);
            this.tabPage2.Controls.Add(this.btnCadastrar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(755, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastrar Filmes";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "<Error>";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(246, 254);
            this.lbl5.Name = "lbl5";
            this.lbl5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl5.Size = new System.Drawing.Size(52, 13);
            this.lbl5.TabIndex = 30;
            this.lbl5.Text = "Categoria";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(249, 194);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(48, 13);
            this.lbl4.TabIndex = 29;
            this.lbl4.Text = "Duração";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(242, 133);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(69, 13);
            this.lbl3.TabIndex = 28;
            this.lbl3.Text = "Classificação";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(255, 77);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(30, 13);
            this.lbl2.TabIndex = 27;
            this.lbl2.Text = "Data";
            // 
            // txb5
            // 
            this.txb5.Location = new System.Drawing.Point(225, 270);
            this.txb5.Name = "txb5";
            this.txb5.Size = new System.Drawing.Size(100, 20);
            this.txb5.TabIndex = 26;
            // 
            // txb4
            // 
            this.txb4.Location = new System.Drawing.Point(225, 210);
            this.txb4.Name = "txb4";
            this.txb4.Size = new System.Drawing.Size(100, 20);
            this.txb4.TabIndex = 25;
            // 
            // txb3
            // 
            this.txb3.Location = new System.Drawing.Point(225, 149);
            this.txb3.Name = "txb3";
            this.txb3.Size = new System.Drawing.Size(100, 20);
            this.txb3.TabIndex = 24;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(235, 23);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(72, 13);
            this.lbl1.TabIndex = 23;
            this.lbl1.Text = "Titulo do filme";
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(225, 96);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(100, 20);
            this.txb2.TabIndex = 22;
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(225, 39);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(100, 20);
            this.txb1.TabIndex = 21;
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Location = new System.Drawing.Point(435, 251);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(32, 13);
            this.lbl10.TabIndex = 20;
            this.lbl10.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(425, 191);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Telefone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(424, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Endereço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Valor do fime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Locação";
            // 
            // txb10
            // 
            this.txb10.Location = new System.Drawing.Point(402, 267);
            this.txb10.Name = "txb10";
            this.txb10.Size = new System.Drawing.Size(100, 20);
            this.txb10.TabIndex = 10;
            // 
            // txb7
            // 
            this.txb7.Location = new System.Drawing.Point(399, 96);
            this.txb7.Name = "txb7";
            this.txb7.Size = new System.Drawing.Size(100, 20);
            this.txb7.TabIndex = 6;
            // 
            // txb6
            // 
            this.txb6.Location = new System.Drawing.Point(399, 39);
            this.txb6.Name = "txb6";
            this.txb6.Size = new System.Drawing.Size(100, 20);
            this.txb6.TabIndex = 5;
            // 
            // txb9
            // 
            this.txb9.Location = new System.Drawing.Point(402, 207);
            this.txb9.Name = "txb9";
            this.txb9.Size = new System.Drawing.Size(100, 20);
            this.txb9.TabIndex = 4;
            // 
            // txb8
            // 
            this.txb8.Location = new System.Drawing.Point(399, 145);
            this.txb8.Name = "txb8";
            this.txb8.Size = new System.Drawing.Size(100, 20);
            this.txb8.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrar.Location = new System.Drawing.Point(326, 322);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LavenderBlush;
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Controls.Add(this.btnPesquisar);
            this.tabPage3.Controls.Add(this.lblFilme);
            this.tabPage3.Controls.Add(this.txbFilme);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(755, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Listar Filmes";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(184, 58);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(490, 316);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisar.Location = new System.Drawing.Point(35, 84);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblFilme
            // 
            this.lblFilme.AutoSize = true;
            this.lblFilme.Location = new System.Drawing.Point(21, 39);
            this.lblFilme.Name = "lblFilme";
            this.lblFilme.Size = new System.Drawing.Size(34, 13);
            this.lblFilme.TabIndex = 1;
            this.lblFilme.Text = "Filme:";
            // 
            // txbFilme
            // 
            this.txbFilme.Location = new System.Drawing.Point(21, 58);
            this.txbFilme.Name = "txbFilme";
            this.txbFilme.Size = new System.Drawing.Size(100, 20);
            this.txbFilme.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.LavenderBlush;
            this.tabPage4.Controls.Add(this.error);
            this.tabPage4.Controls.Add(this.lblSenh);
            this.tabPage4.Controls.Add(this.lblLogin);
            this.tabPage4.Controls.Add(this.btnCadas);
            this.tabPage4.Controls.Add(this.txbSenh);
            this.tabPage4.Controls.Add(this.txbLogin);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(755, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cadastrar Clientes";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(224, 225);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(37, 13);
            this.error.TabIndex = 5;
            this.error.Text = "<erro>";
            // 
            // lblSenh
            // 
            this.lblSenh.AutoSize = true;
            this.lblSenh.Location = new System.Drawing.Point(286, 110);
            this.lblSenh.Name = "lblSenh";
            this.lblSenh.Size = new System.Drawing.Size(38, 13);
            this.lblSenh.TabIndex = 4;
            this.lblSenh.Text = "Senha";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(286, 49);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login";
            // 
            // btnCadas
            // 
            this.btnCadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCadas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadas.Location = new System.Drawing.Point(302, 161);
            this.btnCadas.Name = "btnCadas";
            this.btnCadas.Size = new System.Drawing.Size(75, 23);
            this.btnCadas.TabIndex = 2;
            this.btnCadas.Text = "Logar";
            this.btnCadas.UseVisualStyleBackColor = false;
            this.btnCadas.Click += new System.EventHandler(this.btnCadas_Click);
            // 
            // txbSenh
            // 
            this.txbSenh.Location = new System.Drawing.Point(289, 126);
            this.txbSenh.Name = "txbSenh";
            this.txbSenh.Size = new System.Drawing.Size(100, 20);
            this.txbSenh.TabIndex = 1;
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(289, 65);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(100, 20);
            this.txbLogin.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCada;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txb10;
        private System.Windows.Forms.TextBox txb7;
        private System.Windows.Forms.TextBox txb6;
        private System.Windows.Forms.TextBox txb9;
        private System.Windows.Forms.TextBox txb8;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txb5;
        private System.Windows.Forms.TextBox txb4;
        private System.Windows.Forms.TextBox txb3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.Label lblFilme;
        private System.Windows.Forms.TextBox txbFilme;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label lblSenh;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnCadas;
        private System.Windows.Forms.TextBox txbSenh;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

