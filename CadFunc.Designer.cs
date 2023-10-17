namespace FolhaDePagamento
{
    partial class CadFunc
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
            panel1 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            label4 = new Label();
            label5 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label7 = new Label();
            maskedTextBox4 = new MaskedTextBox();
            label8 = new Label();
            label9 = new Label();
            textBox5 = new TextBox();
            label10 = new Label();
            textBox6 = new TextBox();
            imageList1 = new ImageList(components);
            label11 = new Label();
            textBox7 = new TextBox();
            label12 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label13 = new Label();
            textBox8 = new TextBox();
            label14 = new Label();
            maskedTextBox5 = new MaskedTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 626);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(232, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(232, 29);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 2;
            label1.Text = "Matricula";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(232, 200);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(441, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(232, 177);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 4;
            label2.Text = "Nome completo *";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(679, 177);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 5;
            label3.Text = "CPF *";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(679, 200);
            maskedTextBox1.Mask = "000,000,000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 6;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(891, 200);
            maskedTextBox2.Mask = "00/00/0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(74, 23);
            maskedTextBox2.TabIndex = 7;
            maskedTextBox2.TextAlign = HorizontalAlignment.Center;
            maskedTextBox2.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(891, 177);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(61, 20);
            label4.TabIndex = 8;
            label4.Text = "Dt. nasc";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(785, 177);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 9;
            label5.Text = "Telefone";
            label5.Click += label5_Click;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(785, 200);
            maskedTextBox3.Mask = "(00) 0 0000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(100, 23);
            maskedTextBox3.TabIndex = 10;
            maskedTextBox3.MaskInputRejected += maskedTextBox3_MaskInputRejected;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(232, 259);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 12;
            label6.Text = "Endereço";
            label6.Click += label6_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(232, 282);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(561, 23);
            textBox3.TabIndex = 11;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(799, 282);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(38, 23);
            textBox4.TabIndex = 13;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(799, 259);
            label7.Name = "label7";
            label7.Size = new Size(23, 20);
            label7.TabIndex = 14;
            label7.Text = "nº";
            label7.Click += label7_Click;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(843, 282);
            maskedTextBox4.Mask = "00000-000";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(100, 23);
            maskedTextBox4.TabIndex = 16;
            maskedTextBox4.MaskInputRejected += maskedTextBox4_MaskInputRejected;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(843, 259);
            label8.Name = "label8";
            label8.Size = new Size(33, 20);
            label8.TabIndex = 15;
            label8.Text = "cep";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(949, 259);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 18;
            label9.Text = "Bairro";
            label9.Click += label9_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(949, 282);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(134, 23);
            textBox5.TabIndex = 17;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(232, 496);
            label10.Name = "label10";
            label10.Size = new Size(49, 20);
            label10.TabIndex = 20;
            label10.Text = "Cargo";
            label10.Click += label10_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(232, 519);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(206, 23);
            textBox6.TabIndex = 19;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(232, 337);
            label11.Name = "label11";
            label11.Size = new Size(52, 20);
            label11.TabIndex = 22;
            label11.Text = "E-mail";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(232, 360);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(255, 23);
            textBox7.TabIndex = 21;
            textBox7.TextChanged += textBox7_TextChanged_1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(978, 177);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.No;
            label12.Size = new Size(41, 20);
            label12.TabIndex = 23;
            label12.Text = "Sexo";
            label12.Click += label12_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(978, 216);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(80, 19);
            radioButton1.TabIndex = 24;
            radioButton1.TabStop = true;
            radioButton1.Text = "Masculino";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(978, 200);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(75, 19);
            radioButton2.TabIndex = 25;
            radioButton2.TabStop = true;
            radioButton2.Text = "Feminino";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(232, 113);
            label13.Name = "label13";
            label13.Size = new Size(66, 20);
            label13.TabIndex = 27;
            label13.Text = "Empresa";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(232, 136);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(255, 23);
            textBox8.TabIndex = 26;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(511, 113);
            label14.Name = "label14";
            label14.Size = new Size(41, 20);
            label14.TabIndex = 29;
            label14.Text = "CNPJ";
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.Location = new Point(511, 136);
            maskedTextBox5.Mask = "00,000,000/0000-00";
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.Size = new Size(100, 23);
            maskedTextBox5.TabIndex = 30;
            maskedTextBox5.MaskInputRejected += maskedTextBox5_MaskInputRejected;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(1008, 26);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 31;
            button1.Text = "Criar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CadFunc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(147, 213, 242);
            ClientSize = new Size(1116, 621);
            Controls.Add(button1);
            Controls.Add(maskedTextBox5);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(textBox8);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(textBox7);
            Controls.Add(label10);
            Controls.Add(textBox6);
            Controls.Add(label9);
            Controls.Add(textBox5);
            Controls.Add(maskedTextBox4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(maskedTextBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadFunc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadFunc";
            Load += CadFunc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private Label label4;
        private Label label5;
        private MaskedTextBox maskedTextBox3;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label7;
        private MaskedTextBox maskedTextBox4;
        private Label label8;
        private Label label9;
        private TextBox textBox5;
        private Label label10;
        private TextBox textBox6;
        private ImageList imageList1;
        private Label label11;
        private TextBox textBox7;
        private Label label12;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label13;
        private TextBox textBox8;
        private Label label14;
        private MaskedTextBox maskedTextBox5;
        private Button button1;
    }
}