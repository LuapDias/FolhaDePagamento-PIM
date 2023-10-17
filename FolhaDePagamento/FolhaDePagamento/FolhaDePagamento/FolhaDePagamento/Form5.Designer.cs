namespace FolhaDePagamento
{
    partial class Form5
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
            imageList1 = new ImageList(components);
            Empresa = new Button();
            FolhaPagamento = new Button();
            Holerite = new Button();
            Funcionario = new Button();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Empresa
            // 
            Empresa.Font = new Font("Segoe UI", 18.25F, FontStyle.Regular, GraphicsUnit.Point);
            Empresa.Location = new Point(12, 12);
            Empresa.Name = "Empresa";
            Empresa.Size = new Size(123, 43);
            Empresa.TabIndex = 5;
            Empresa.Text = "Empresa";
            Empresa.UseVisualStyleBackColor = true;
            Empresa.Click += Empresa_Click;
            // 
            // FolhaPagamento
            // 
            FolhaPagamento.Font = new Font("Segoe UI", 18.25F, FontStyle.Regular, GraphicsUnit.Point);
            FolhaPagamento.Location = new Point(141, 13);
            FolhaPagamento.Name = "FolhaPagamento";
            FolhaPagamento.Size = new Size(253, 42);
            FolhaPagamento.TabIndex = 6;
            FolhaPagamento.Text = "Folha de Pagamento";
            FolhaPagamento.UseVisualStyleBackColor = true;
            FolhaPagamento.Click += FolhaPagamento_Click;
            // 
            // Holerite
            // 
            Holerite.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Holerite.Location = new Point(556, 13);
            Holerite.Name = "Holerite";
            Holerite.Size = new Size(111, 42);
            Holerite.TabIndex = 10;
            Holerite.Text = "Holerite";
            Holerite.UseVisualStyleBackColor = true;
            Holerite.Click += Holerite_Click;
            // 
            // Funcionario
            // 
            Funcionario.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Funcionario.Location = new Point(400, 12);
            Funcionario.Name = "Funcionario";
            Funcionario.Size = new Size(150, 42);
            Funcionario.TabIndex = 11;
            Funcionario.Text = "Funcionário";
            Funcionario.UseVisualStyleBackColor = true;
            Funcionario.Click += Funcionario_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(820, 700);
            Controls.Add(Funcionario);
            Controls.Add(Holerite);
            Controls.Add(FolhaPagamento);
            Controls.Add(Empresa);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form5_Load;
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private Button Empresa;
        private Button FolhaPagamento;
        private Button Holerite;
        private Button Funcionario;
    }
}