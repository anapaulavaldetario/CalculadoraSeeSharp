namespace Calculadora
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
            BtnResultado = new TextBox();
            btn0 = new Button();
            Btn1 = new Button();
            Btn2 = new Button();
            Btn3 = new Button();
            Btn4 = new Button();
            Btn5 = new Button();
            Btn6 = new Button();
            Btn7 = new Button();
            Btn8 = new Button();
            Btn9 = new Button();
            Btndivisao = new Button();
            BtnMultiplicacao = new Button();
            BtnMenos = new Button();
            Btnponto = new Button();
            Btnigual = new Button();
            BtnMais = new Button();
            BtnLimpar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // BtnResultado
            // 
            BtnResultado.BackColor = Color.SpringGreen;
            BtnResultado.ForeColor = SystemColors.ControlText;
            BtnResultado.Location = new Point(30, 30);
            BtnResultado.Name = "BtnResultado";
            BtnResultado.ReadOnly = true;
            BtnResultado.Size = new Size(212, 23);
            BtnResultado.TabIndex = 0;
            BtnResultado.TextAlign = HorizontalAlignment.Right;
            BtnResultado.TextChanged += BtnResultado_TextChanged;
            // 
            // btn0
            // 
            btn0.Location = new Point(84, 278);
            btn0.Name = "btn0";
            btn0.Size = new Size(48, 46);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // Btn1
            // 
            Btn1.Location = new Point(30, 226);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(48, 46);
            Btn1.TabIndex = 2;
            Btn1.Text = "1";
            Btn1.UseVisualStyleBackColor = true;
            Btn1.Click += Btn1_Click;
            // 
            // Btn2
            // 
            Btn2.Location = new Point(84, 226);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(48, 46);
            Btn2.TabIndex = 3;
            Btn2.Text = "2";
            Btn2.UseVisualStyleBackColor = true;
            Btn2.Click += Btn2_Click;
            // 
            // Btn3
            // 
            Btn3.Location = new Point(138, 226);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(48, 46);
            Btn3.TabIndex = 4;
            Btn3.Text = "3";
            Btn3.UseVisualStyleBackColor = true;
            Btn3.Click += Btn3_Click;
            // 
            // Btn4
            // 
            Btn4.Location = new Point(30, 174);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(48, 46);
            Btn4.TabIndex = 5;
            Btn4.Text = "4";
            Btn4.UseVisualStyleBackColor = true;
            Btn4.Click += Btn4_Click;
            // 
            // Btn5
            // 
            Btn5.Location = new Point(84, 174);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(48, 46);
            Btn5.TabIndex = 6;
            Btn5.Text = "5";
            Btn5.UseVisualStyleBackColor = true;
            Btn5.Click += Btn5_Click;
            // 
            // Btn6
            // 
            Btn6.Location = new Point(138, 174);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(48, 46);
            Btn6.TabIndex = 7;
            Btn6.Text = "6";
            Btn6.UseVisualStyleBackColor = true;
            Btn6.Click += Btn6_Click;
            // 
            // Btn7
            // 
            Btn7.Location = new Point(30, 122);
            Btn7.Name = "Btn7";
            Btn7.Size = new Size(48, 46);
            Btn7.TabIndex = 8;
            Btn7.Text = "7";
            Btn7.UseVisualStyleBackColor = true;
            Btn7.Click += Btn7_Click;
            // 
            // Btn8
            // 
            Btn8.Location = new Point(84, 122);
            Btn8.Name = "Btn8";
            Btn8.Size = new Size(48, 46);
            Btn8.TabIndex = 9;
            Btn8.Text = "8";
            Btn8.UseVisualStyleBackColor = true;
            Btn8.Click += Btn8_Click;
            // 
            // Btn9
            // 
            Btn9.Location = new Point(138, 122);
            Btn9.Name = "Btn9";
            Btn9.Size = new Size(48, 46);
            Btn9.TabIndex = 10;
            Btn9.Text = "9";
            Btn9.UseVisualStyleBackColor = true;
            Btn9.Click += Btn9_Click;
            // 
            // Btndivisao
            // 
            Btndivisao.BackgroundImageLayout = ImageLayout.None;
            Btndivisao.Location = new Point(194, 122);
            Btndivisao.Name = "Btndivisao";
            Btndivisao.Size = new Size(48, 46);
            Btndivisao.TabIndex = 11;
            Btndivisao.Text = "/";
            Btndivisao.UseVisualStyleBackColor = true;
            Btndivisao.Click += Btndivisao_Click;
            // 
            // BtnMultiplicacao
            // 
            BtnMultiplicacao.Location = new Point(192, 174);
            BtnMultiplicacao.Name = "BtnMultiplicacao";
            BtnMultiplicacao.Size = new Size(48, 46);
            BtnMultiplicacao.TabIndex = 12;
            BtnMultiplicacao.Text = "x";
            BtnMultiplicacao.UseVisualStyleBackColor = true;
            BtnMultiplicacao.Click += BtnMultiplicacao_Click;
            // 
            // BtnMenos
            // 
            BtnMenos.Location = new Point(192, 226);
            BtnMenos.Name = "BtnMenos";
            BtnMenos.Size = new Size(48, 46);
            BtnMenos.TabIndex = 13;
            BtnMenos.Text = "-";
            BtnMenos.UseVisualStyleBackColor = true;
            BtnMenos.Click += BtnMenos_Click;
            // 
            // Btnponto
            // 
            Btnponto.Location = new Point(30, 278);
            Btnponto.Name = "Btnponto";
            Btnponto.Size = new Size(48, 46);
            Btnponto.TabIndex = 14;
            Btnponto.Text = ".";
            Btnponto.UseVisualStyleBackColor = true;
            Btnponto.Click += Btnponto_Click;
            // 
            // Btnigual
            // 
            Btnigual.Location = new Point(138, 278);
            Btnigual.Name = "Btnigual";
            Btnigual.Size = new Size(48, 46);
            Btnigual.TabIndex = 15;
            Btnigual.Text = "=";
            Btnigual.UseVisualStyleBackColor = true;
            Btnigual.Click += Btnigual_Click;
            // 
            // BtnMais
            // 
            BtnMais.Location = new Point(194, 278);
            BtnMais.Name = "BtnMais";
            BtnMais.Size = new Size(48, 46);
            BtnMais.TabIndex = 16;
            BtnMais.Text = "+";
            BtnMais.UseVisualStyleBackColor = true;
            BtnMais.Click += BtnMais_Click;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(192, 70);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(48, 46);
            BtnLimpar.TabIndex = 17;
            BtnLimpar.Text = "C";
            BtnLimpar.UseVisualStyleBackColor = true;
            BtnLimpar.Click += BtnLimpar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.HotPink;
            label1.Location = new Point(36, 33);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 33);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepPink;
            ClientSize = new Size(270, 366);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnLimpar);
            Controls.Add(BtnMais);
            Controls.Add(Btnigual);
            Controls.Add(Btnponto);
            Controls.Add(BtnMenos);
            Controls.Add(BtnMultiplicacao);
            Controls.Add(Btndivisao);
            Controls.Add(Btn9);
            Controls.Add(Btn8);
            Controls.Add(Btn7);
            Controls.Add(Btn6);
            Controls.Add(Btn5);
            Controls.Add(Btn4);
            Controls.Add(Btn3);
            Controls.Add(Btn2);
            Controls.Add(Btn1);
            Controls.Add(btn0);
            Controls.Add(BtnResultado);
            Cursor = Cursors.Hand;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox BtnResultado;
        private Button btn0;
        private Button Btn1;
        private Button Btn2;
        private Button Btn3;
        private Button Btn4;
        private Button Btn5;
        private Button Btn6;
        private Button Btn7;
        private Button Btn8;
        private Button Btn9;
        private Button Btndivisao;
        private Button BtnMultiplicacao;
        private Button BtnMenos;
        private Button Btnponto;
        private Button Btnigual;
        private Button BtnMais;
        private Button BtnLimpar;
        private Label label1;
        private Label label2;
    }
}