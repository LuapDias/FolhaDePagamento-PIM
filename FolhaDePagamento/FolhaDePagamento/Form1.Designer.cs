namespace FolhaDePagamento
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
            this.tituloLabel1 = new System.Windows.Forms.Label();
            this.usuarioLabel1 = new System.Windows.Forms.Label();
            this.textBoxEmail1 = new System.Windows.Forms.TextBox();
            this.esqueciSenhaLinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxSenha1 = new System.Windows.Forms.TextBox();
            this.senhaLabel1 = new System.Windows.Forms.Label();
            this.loginButton1 = new System.Windows.Forms.Button();
            this.fecharLinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tituloLabel1
            // 
            this.tituloLabel1.AutoSize = true;
            this.tituloLabel1.BackColor = System.Drawing.Color.Transparent;
            this.tituloLabel1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tituloLabel1.ForeColor = System.Drawing.Color.Black;
            this.tituloLabel1.Location = new System.Drawing.Point(160, 141);
            this.tituloLabel1.Name = "tituloLabel1";
            this.tituloLabel1.Size = new System.Drawing.Size(291, 36);
            this.tituloLabel1.TabIndex = 0;
            this.tituloLabel1.Text = "Seja Bem-Vindo(a)!";
            // 
            // usuarioLabel1
            // 
            this.usuarioLabel1.AutoSize = true;
            this.usuarioLabel1.BackColor = System.Drawing.Color.Transparent;
            this.usuarioLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usuarioLabel1.ForeColor = System.Drawing.Color.Black;
            this.usuarioLabel1.Location = new System.Drawing.Point(119, 241);
            this.usuarioLabel1.Name = "usuarioLabel1";
            this.usuarioLabel1.Size = new System.Drawing.Size(76, 24);
            this.usuarioLabel1.TabIndex = 2;
            this.usuarioLabel1.Text = "E-mail:";
            // 
            // textBoxEmail1
            // 
            this.textBoxEmail1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmail1.Location = new System.Drawing.Point(119, 271);
            this.textBoxEmail1.Multiline = true;
            this.textBoxEmail1.Name = "textBoxEmail1";
            this.textBoxEmail1.Size = new System.Drawing.Size(359, 28);
            this.textBoxEmail1.TabIndex = 3;
            // 
            // esqueciSenhaLinkLabel1
            // 
            this.esqueciSenhaLinkLabel1.AutoSize = true;
            this.esqueciSenhaLinkLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.esqueciSenhaLinkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(97)))), ((int)(((byte)(189)))));
            this.esqueciSenhaLinkLabel1.Location = new System.Drawing.Point(119, 403);
            this.esqueciSenhaLinkLabel1.Name = "esqueciSenhaLinkLabel1";
            this.esqueciSenhaLinkLabel1.Size = new System.Drawing.Size(135, 21);
            this.esqueciSenhaLinkLabel1.TabIndex = 6;
            this.esqueciSenhaLinkLabel1.TabStop = true;
            this.esqueciSenhaLinkLabel1.Text = "Esqueci a senha";
            this.esqueciSenhaLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.esqueciSenhaLinkLabel1_LinkClicked);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(330, 402);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(148, 25);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Mostrar senha";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBoxSenha1
            // 
            this.textBoxSenha1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSenha1.Location = new System.Drawing.Point(119, 368);
            this.textBoxSenha1.Multiline = true;
            this.textBoxSenha1.Name = "textBoxSenha1";
            this.textBoxSenha1.PasswordChar = '*';
            this.textBoxSenha1.Size = new System.Drawing.Size(359, 28);
            this.textBoxSenha1.TabIndex = 9;
            // 
            // senhaLabel1
            // 
            this.senhaLabel1.AutoSize = true;
            this.senhaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.senhaLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.senhaLabel1.ForeColor = System.Drawing.Color.Black;
            this.senhaLabel1.Location = new System.Drawing.Point(119, 338);
            this.senhaLabel1.Name = "senhaLabel1";
            this.senhaLabel1.Size = new System.Drawing.Size(79, 24);
            this.senhaLabel1.TabIndex = 8;
            this.senhaLabel1.Text = "Senha:";
            // 
            // loginButton1
            // 
            this.loginButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(97)))), ((int)(((byte)(189)))));
            this.loginButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton1.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginButton1.ForeColor = System.Drawing.Color.White;
            this.loginButton1.Location = new System.Drawing.Point(197, 492);
            this.loginButton1.Name = "loginButton1";
            this.loginButton1.Size = new System.Drawing.Size(193, 47);
            this.loginButton1.TabIndex = 10;
            this.loginButton1.Text = "Entrar";
            this.loginButton1.UseVisualStyleBackColor = false;
            this.loginButton1.Click += new System.EventHandler(this.loginButton1_Click);
            // 
            // fecharLinkLabel1
            // 
            this.fecharLinkLabel1.AutoSize = true;
            this.fecharLinkLabel1.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fecharLinkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(97)))), ((int)(((byte)(189)))));
            this.fecharLinkLabel1.Location = new System.Drawing.Point(249, 559);
            this.fecharLinkLabel1.Name = "fecharLinkLabel1";
            this.fecharLinkLabel1.Size = new System.Drawing.Size(90, 27);
            this.fecharLinkLabel1.TabIndex = 11;
            this.fecharLinkLabel1.TabStop = true;
            this.fecharLinkLabel1.Text = "Fechar";
            this.fecharLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.fecharLinkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(598, 674);
            this.Controls.Add(this.fecharLinkLabel1);
            this.Controls.Add(this.loginButton1);
            this.Controls.Add(this.textBoxSenha1);
            this.Controls.Add(this.senhaLabel1);
            this.Controls.Add(this.esqueciSenhaLinkLabel1);
            this.Controls.Add(this.textBoxEmail1);
            this.Controls.Add(this.usuarioLabel1);
            this.Controls.Add(this.tituloLabel1);
            this.Controls.Add(this.checkBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label tituloLabel1;
        private Label usuarioLabel1;
        private TextBox textBoxEmail1;
        private LinkLabel esqueciSenhaLinkLabel1;
        private CheckBox checkBox1;
        private TextBox textBoxSenha1;
        private Label senhaLabel1;
        private Button loginButton1;
        private LinkLabel fecharLinkLabel1;
    }
}