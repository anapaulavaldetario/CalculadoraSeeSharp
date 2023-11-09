using LanguageExt.TypeClasses;


namespace Calculadora
{
    public partial class Form1 : Form
    {
        public decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }
        public decimal Resultado { get; private set; }

        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao,
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            BtnResultado.Text += "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            BtnResultado.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            BtnResultado.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            BtnResultado.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            BtnResultado.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            BtnResultado.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            BtnResultado.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            BtnResultado.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            BtnResultado.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            BtnResultado.Text += "9";
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            BtnResultado.Text = "";
            label1.Text = "";
        }

        private void Btnponto_Click(object sender, EventArgs e)
        {
            if (!BtnResultado.Text.Contains("."))
            {
                BtnResultado.Text += ",";
            }
        }

        private void Btnigual_Click(object sender, EventArgs e)
        {

            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(BtnResultado.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(BtnResultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(BtnResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(BtnResultado.Text);
                    break;
            }
            BtnResultado.Text = Convert.ToString(Resultado);
            label1.Text = "=";
        }

        private void BtnMais_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(BtnResultado.Text);
            BtnResultado.Text = "";
            label1.Text = "+";

        }

        private void BtnMenos_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(BtnResultado.Text);
            BtnResultado.Text = "";
            label1.Text = "-";
        }

        private void BtnMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(BtnResultado.Text);
            BtnResultado.Text = "";
            label1.Text = "*";
        }

        private void Btndivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(BtnResultado.Text);
            BtnResultado.Text = "";
            label1.Text = "/";
        }

        private void BtnResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}