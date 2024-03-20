//  P1_NEUROGM
//  Gustavo Gouveia     186766
//  Manoela Alvares     190565

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace P1_NEUROGM
{
    public partial class FORM_P1 : Form
    {
        public FORM_P1()
        {
            InitializeComponent();
            AdicionaValoresP1();
        }

        #region Declarações iniciais

        int IndexTreino, IndexEvoluc, QtdeCasos;
        double w1, w2, w0, x0, alfa, ValMaxTreino, erro, y;

        #endregion

        #region Botões
        private void BT_TREINAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TB_BIAS_W0.Text) || string.IsNullOrWhiteSpace(TB_BIAS_X0.Text) || string.IsNullOrWhiteSpace(TB_PESOS_W1.Text) || string.IsNullOrWhiteSpace(TB_PESOS_W2.Text) || string.IsNullOrWhiteSpace(TB_TREINO_ALFA.Text) || string.IsNullOrWhiteSpace(TB_MAXTREINO.Text)) 
            { 
                MessageBox.Show("Entradas inválidas ou um campo está vazio", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                LT_LOG_TREINO.Items.Clear();
                LB_QTDE_TREINOS.Text = "";
                IndexTreino = 0;
                QtdeCasos = TAB_CASOS.RowCount - 1;

                //Atribui os valores das text boxes para suas respectivas variáveis
                #region Variáveis - Text Boxes
                w1 = double.Parse(TB_PESOS_W1.Text);
                w2 = double.Parse(TB_PESOS_W2.Text);

                x0 = double.Parse(TB_BIAS_X0.Text);
                w0 = double.Parse(TB_BIAS_W0.Text);

                alfa = double.Parse(TB_TREINO_ALFA.Text);
                ValMaxTreino = double.Parse(TB_MAXTREINO.Text);
                #endregion


                //Criação Grafico de Casos
                PlotaGraficoCaso();

                //Criação Grafico de Pesos
                PlotaGraficoPeso();

                //Metodo Widrow Hoff
                WidrowHoff();
            }
        }

        // Botão para adicionar novo caso a tabela
        private void BT_TAB_ADD_Click(object sender, EventArgs e)
        {
            // Declaração das variáveis x1_tabela, x2_tabela e target_tabela
            int x1_tabela, x2_tabela, target_tabela = 0;

            // Obtém os valores de X1 e X2 dos campos de texto
            if (int.TryParse(TB_TAB_CASOS_X1.Text, out x1_tabela) && int.TryParse(TB_TAB_CASOS_X2.Text, out x2_tabela))
            {
                // Verifica qual botão de rádio está marcado e atribui o valor correspondente a target_tabela
                if (RB_1POS.Checked)
                    target_tabela = 1; // Se o botão de rádio RB_1POS está marcado, target_tabela recebe 1
                else if (RB_1NEG.Checked)
                    target_tabela = -1; // Se o botão de rádio RB_1NEG está marcado, target_tabela recebe -1

                // Adiciona os valores de X1, X2 e target_tabela à tabela TAB_CASOS
                TAB_CASOS.Rows.Add(x1_tabela, x2_tabela, target_tabela);

                // Limpa os campos de texto após adicionar os valores à tabela
                TB_TAB_CASOS_X1.Clear();
                TB_TAB_CASOS_X2.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, insira números válidos para X1 e X2.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Botão para limpar todos os dados inseridos na tabela
        private void BT_LIMPA_TAB_Click(object sender, EventArgs e)
        {
            TAB_CASOS.Rows.Clear();
        }

        // Reseta a tabela para os valores de P1, limpando tudo que anteriormente estava na tabela
        private void BT_RESET_TAB_Click(object sender, EventArgs e)
        {
            TAB_CASOS.Rows.Clear();
            AdicionaValoresP1();
        }

        #endregion

        #region Algoritmo Widrow-Hoff

        public void WidrowHoff() 
        {
            // Cálculos e posterior adição de seus resultados na aba "LOG" da janela principal
            // Obs.: Dependendo da quantidade de treinamentos, essa aba pode demorar um pouco para carregar

            LT_LOG_TREINO.Items.Add("NeuroGM, projeto desenvolvido pelos alunos Gustavo Gouveia e Manoela Alvares");
            LT_LOG_TREINO.Items.Add("Data de entrega: 18/10/2023");
            LT_LOG_TREINO.Items.Add("============================================================================");

            for (int i = 0; i < ValMaxTreino; i++)
            {
                IndexEvoluc = 0;

                LT_LOG_TREINO.Items.Add("=====================================");
                LT_LOG_TREINO.Items.Add("NUM. TREINO:" + IndexTreino);
                LT_LOG_TREINO.Items.Add("w1: " + w1);
                LT_LOG_TREINO.Items.Add("w2: " + w2);
                LT_LOG_TREINO.Items.Add("w0: " + w0);
                LT_LOG_TREINO.Items.Add("=====================================");


                for (int k = 0; k < QtdeCasos; k++)
                {
                    // Atribui os valores da tabela, linha por linha, em variáveis para cada execução do laço de repetição,
                    // até que todos sejam utilizados.

                    double val_x1 = double.Parse(TAB_CASOS.Rows[k].Cells[0].Value.ToString());
                    double val_x2 = double.Parse(TAB_CASOS.Rows[k].Cells[1].Value.ToString());
                    double val_target = double.Parse(TAB_CASOS.Rows[k].Cells[2].Value.ToString());
                    double val_mod = Math.Sqrt(Math.Pow(val_x1, 2) + Math.Pow(val_x2, 2) + Math.Pow(x0, 2));


                    // Saída intermediária
                    double saida_interm = (w0 * x0) + (w1 * val_x1) + (w2 * val_x2);

                    // Atualiza o valor de y com base na saída intermediária
                    y = (saida_interm > 0) ? 1 : -1;

                    erro = val_target - saida_interm;


                    // Atualização os pontos ao gráfico
                    GRAF_PESOS.Series["W1"].Points.AddXY(w1, erro);
                    GRAF_PESOS.Series["W2"].Points.AddXY(w2, erro);

                    // Atualização dos pesos
                    w0 = w0 + (alfa * erro * (x0 / Math.Pow(val_mod, 2)));
                    w1 = w1 + (alfa * erro * (val_x1 / Math.Pow(val_mod, 2)));
                    w2 = w2 + (alfa * erro * (val_x2 / Math.Pow(val_mod, 2)));

                    // Adicionando as informações ao log de treino
                    LT_LOG_TREINO.Items.Add("Num. Caso: " + k);
                    LT_LOG_TREINO.Items.Add("x1: " + val_x1);
                    LT_LOG_TREINO.Items.Add("x2: " + val_x2);
                    LT_LOG_TREINO.Items.Add("val_target: " + val_target);


                    // Compara o valor do val_target com o Y, para saber se está igual ou ainda apresenta erro
                    if (val_target == y)
                    {
                        IndexEvoluc++;

                        LT_LOG_TREINO.Items.Add(" y: " + y + " OK");
                        LT_LOG_TREINO.Items.Add("==================");
                    }
                    else
                    {
                        LT_LOG_TREINO.Items.Add(" y: " + y + " ERRO");
                        LT_LOG_TREINO.Items.Add("==================");
                    }

                    // Verifica se a evolução já foi concluída, e em caso afirmativo, o laço for é interrompido
                    if (IndexEvoluc == QtdeCasos)
                    {
                        LB_QTDE_TREINOS.Text = (IndexTreino + 1).ToString();
                        break;
                    }

                }

                // Verifica se a evolução já foi concluída, interrompendo o laço, e em caso do limite de treinos for
                // detectado, essa informação será disposta na janela principal

                if (IndexEvoluc == QtdeCasos)
                    break;
                else 
                    LB_QTDE_TREINOS.Text = "Limite atingido";

                IndexTreino++;
            }

            // Atribuição dos valores dos pesos finais para as labels da janela principal
            LB_FINAL_W1.Text = w1.ToString("F7");
            LB_FINAL_W2.Text = w2.ToString("F7");
        }

        #endregion

        #region Insere valores iniciais na tabela
        //  No total, 16 casos
        //  8 casos para +1, 8 para -1
        public void AdicionaValoresP1()
        {
            TAB_CASOS.Rows.Clear();

            // Exemplos de casos cabelo/sapato para as mulheres
            TAB_CASOS.Rows.Add(25, 34, -1);
            TAB_CASOS.Rows.Add(22, 37, -1);
            TAB_CASOS.Rows.Add(30, 33, -1);
            TAB_CASOS.Rows.Add(27, 37, -1);
            TAB_CASOS.Rows.Add(35, 34, -1);
            TAB_CASOS.Rows.Add(33, 37, -1);
            TAB_CASOS.Rows.Add(40, 33, -1);
            TAB_CASOS.Rows.Add(25, 35, -1);

            // Exemplos de casos cabelo/sapato para os homens
            TAB_CASOS.Rows.Add(4, 40, 1);
            TAB_CASOS.Rows.Add(6, 38, 1);
            TAB_CASOS.Rows.Add(10, 44, 1);
            TAB_CASOS.Rows.Add(3, 42, 1);
            TAB_CASOS.Rows.Add(15, 45, 1);
            TAB_CASOS.Rows.Add(10, 38, 1);
            TAB_CASOS.Rows.Add(8, 42, 1);
            TAB_CASOS.Rows.Add(12, 41, 1);
        }
        #endregion

        #region Funções de gráficos

        public void PlotaGraficoPeso() 
        {
            // Limpa os títulos, séries e legendas do gráfico de pesos
            GRAF_PESOS.Titles.Clear();
            GRAF_PESOS.Series.Clear();
            GRAF_PESOS.Legends.Clear();

            // Adiciona um novo título ao gráfico de pesos
            GRAF_PESOS.Titles.Add("PESO");

            // Adiciona séries ao gráfico de pesos
            GRAF_PESOS.Series.Add("W1");
            GRAF_PESOS.Series.Add("W2");

            // Adiciona legendas às séries de pesos
            GRAF_PESOS.Legends.Add("W1");
            GRAF_PESOS.Legends.Add("W2");

            // Define os tipos de gráficos para as séries de pesos
            GRAF_PESOS.Series["W1"].ChartType = SeriesChartType.Spline;
            GRAF_PESOS.Series["W2"].ChartType = SeriesChartType.Spline;

        }

        public void PlotaGraficoCaso() 
        {
            // Limpa os títulos, séries e legendas do gráfico
            GRAF_CASOS.Titles.Clear();
            GRAF_CASOS.Series.Clear();
            GRAF_CASOS.Legends.Clear();

            // Adiciona um novo título ao gráfico
            GRAF_CASOS.Titles.Add("CASO");

            // Adiciona séries ao gráfico
            GRAF_CASOS.Series.Add("LINHA");
            GRAF_CASOS.Series.Add("X1");
            GRAF_CASOS.Series.Add("X2");

            // Adiciona legendas às séries
            GRAF_CASOS.Legends.Add("X1");
            GRAF_CASOS.Legends.Add("X2");

            // Define os tipos de gráficos para cada série
            GRAF_CASOS.Series["LINHA"].ChartType = SeriesChartType.Line;
            GRAF_CASOS.Series["X1"].ChartType = SeriesChartType.Point;
            GRAF_CASOS.Series["X2"].ChartType = SeriesChartType.Point;


            for (int i = 0; i < QtdeCasos; i++)
            {
                double val_x1_caso = Convert.ToDouble(TAB_CASOS.Rows[i].Cells[0].Value);
                double val_x2_caso = Convert.ToDouble(TAB_CASOS.Rows[i].Cells[1].Value);
                double val_target_caso = Convert.ToDouble(TAB_CASOS.Rows[i].Cells[2].Value);

                // Cálculo da linha do gráfico
                double X2Linha = -((w1 / w2) * val_x1_caso) - (w0 / w2);

                Series xSeries, linhaSeries;

                // Determina qual série adicionar com base no valor de val_target_caso
                if (val_target_caso == 1)
                {
                    xSeries = GRAF_CASOS.Series["X1"];
                    linhaSeries = GRAF_CASOS.Series["LINHA"];
                }
                else
                {
                    xSeries = GRAF_CASOS.Series["X2"];
                    linhaSeries = GRAF_CASOS.Series["LINHA"];
                }

                // Adiciona pontos ao gráfico
                xSeries.Points.AddXY(val_x1_caso, val_x2_caso);
                linhaSeries.Points.AddXY(val_x1_caso, X2Linha);
            }

        }
        #endregion

    }
}