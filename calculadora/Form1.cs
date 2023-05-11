using System.Globalization;

namespace calculadora
{
    public partial class Calculadora : Form
    {
        private const int StartIndex = 0;

        // CONSTRUTOR
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        }

        // R E S U L T A D O 

        // =
        private void Btn_equal_Click(object sender, EventArgs e)
        {
            // isolando os numeros
            int cont = 0;
            int num1 = 0;
            int num2 = 0;
            int res = 0;
            foreach (char c in visor.Text)
            {
                if (c == '+' || c == '-' || c == '*' || c == '/')
                {
                    num1 = int.Parse(visor.Text.Substring(StartIndex, cont));
                    num2 = int.Parse(visor.Text.Substring(cont));
                    // soma
                    if (c == '+') 
                    {
                        res = num1 + num2;
                    }
                    // subtracao
                    if (c == '-')
                    {
                        res = num1 - num2;
                    }
                    // divisao
                    if (c == '/')
                    {
                        res = num1 / num2;
                    }
                    // multiplicacao
                    if (c == '*')
                    {
                        res = num1 * num2;
                    }
                }
                cont++;
            }
            resultado.Text = res.ToString();
        }

        // O P E R A C O E S

        // -
        private void Btn_subtracao_Click(object sender, EventArgs e)
        {
            visor.Text += "-";
        }
        // +
        private void Btn_soma_Click(object sender, EventArgs e)
        {
            visor.Text += "+";
        }
        // /
        private void Btn_divisao_Click(object sender, EventArgs e)
        {
            visor.Text += "/";
        }
        // *
        private void Btn_multiplicacao_Click(object sender, EventArgs e)
        {
            visor.Text += "*";
        }

        // N U M E R O S

        // 1
        private void Btn_1_Click(object sender, EventArgs e)
        {
            visor.Text += "1";
        }
        // 2
        private void Btn_2_Click(object sender, EventArgs e)
        {
            visor.Text += "2";
        }
        // 3
        private void Btn_3_Click(object sender, EventArgs e)
        {
            visor.Text += "3";
        }
        // 4
        private void Btn_4_Click(object sender, EventArgs e)
        {
            visor.Text += "4";
        }
        // 5
        private void Btn_5_Click(object sender, EventArgs e)
        {
            visor.Text += "5";
        }
        // 6
        private void Btn_6_Click(object sender, EventArgs e)
        {
            visor.Text += "6";
        }
        // 7
        private void Btn_7_Click(object sender, EventArgs e)
        {
            visor.Text += "7";
        }
        // 8
        private void Btn_8_Click(object sender, EventArgs e)
        {
            visor.Text += "8";
        }
        // 9
        private void Btn_9_Click(object sender, EventArgs e)
        {
            visor.Text += "9";
        }
        // 0
        private void Btn_0_Click(object sender, EventArgs e)
        {
            visor.Text += "0";
        }

        // LIMPAR VISOR
        private void Btn_apagar_Click(object sender, EventArgs e)
        {
            visor.Text = "";
        }
    }
}
