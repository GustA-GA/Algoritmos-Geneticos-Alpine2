namespace P1_NEUROGM
{
    partial class FORM_P1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_P1));
            this.GRAF_CASOS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GRAF_PESOS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LT_LOG_TREINO = new System.Windows.Forms.ListBox();
            this.TAB_CASOS = new System.Windows.Forms.DataGridView();
            this.X1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BT_RESET_TAB = new System.Windows.Forms.Button();
            this.BT_LIMPA_TAB = new System.Windows.Forms.Button();
            this.BT_TAB_ADD = new System.Windows.Forms.Button();
            this.RB_1NEG = new System.Windows.Forms.RadioButton();
            this.RB_1POS = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.TB_TAB_CASOS_X2 = new System.Windows.Forms.TextBox();
            this.TB_TAB_CASOS_X1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TB_PESOS_W2 = new System.Windows.Forms.TextBox();
            this.TB_PESOS_W1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TB_BIAS_X0 = new System.Windows.Forms.TextBox();
            this.TB_BIAS_W0 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TB_MAXTREINO = new System.Windows.Forms.TextBox();
            this.TB_TREINO_ALFA = new System.Windows.Forms.TextBox();
            this.LB_QTDE_TREINOS = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.LB_FINAL_W2 = new System.Windows.Forms.Label();
            this.LB_FINAL_W1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BT_TREINAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GRAF_CASOS)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRAF_PESOS)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TAB_CASOS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRAF_CASOS
            // 
            this.GRAF_CASOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            chartArea1.Name = "ChartArea1";
            this.GRAF_CASOS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GRAF_CASOS.Legends.Add(legend1);
            this.GRAF_CASOS.Location = new System.Drawing.Point(8, 10);
            this.GRAF_CASOS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GRAF_CASOS.Name = "GRAF_CASOS";
            this.GRAF_CASOS.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.GRAF_CASOS.Series.Add(series1);
            this.GRAF_CASOS.Size = new System.Drawing.Size(638, 362);
            this.GRAF_CASOS.TabIndex = 0;
            this.GRAF_CASOS.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(725, 275);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(654, 403);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GRAF_CASOS);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(646, 372);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Casos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GRAF_PESOS);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(638, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GRAF_PESOS
            // 
            this.GRAF_PESOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            chartArea2.Name = "ChartArea1";
            this.GRAF_PESOS.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.GRAF_PESOS.Legends.Add(legend2);
            this.GRAF_PESOS.Location = new System.Drawing.Point(8, 10);
            this.GRAF_PESOS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GRAF_PESOS.Name = "GRAF_PESOS";
            this.GRAF_PESOS.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.GRAF_PESOS.Series.Add(series2);
            this.GRAF_PESOS.Size = new System.Drawing.Size(676, 362);
            this.GRAF_PESOS.TabIndex = 0;
            this.GRAF_PESOS.Text = "chart1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.LT_LOG_TREINO);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(646, 372);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "LOG";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // LT_LOG_TREINO
            // 
            this.LT_LOG_TREINO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.LT_LOG_TREINO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LT_LOG_TREINO.FormattingEnabled = true;
            this.LT_LOG_TREINO.ItemHeight = 18;
            this.LT_LOG_TREINO.Location = new System.Drawing.Point(8, 5);
            this.LT_LOG_TREINO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LT_LOG_TREINO.Name = "LT_LOG_TREINO";
            this.LT_LOG_TREINO.Size = new System.Drawing.Size(634, 364);
            this.LT_LOG_TREINO.TabIndex = 0;
            // 
            // TAB_CASOS
            // 
            this.TAB_CASOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TAB_CASOS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.TAB_CASOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TAB_CASOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X1,
            this.X2,
            this.T});
            this.TAB_CASOS.Location = new System.Drawing.Point(199, 19);
            this.TAB_CASOS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TAB_CASOS.Name = "TAB_CASOS";
            this.TAB_CASOS.RowHeadersVisible = false;
            this.TAB_CASOS.Size = new System.Drawing.Size(493, 311);
            this.TAB_CASOS.TabIndex = 10;
            // 
            // X1
            // 
            this.X1.HeaderText = "X1";
            this.X1.Name = "X1";
            this.X1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // X2
            // 
            this.X2.HeaderText = "X2";
            this.X2.Name = "X2";
            this.X2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // T
            // 
            this.T.HeaderText = "Target";
            this.T.Name = "T";
            this.T.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.BT_RESET_TAB);
            this.groupBox1.Controls.Add(this.BT_LIMPA_TAB);
            this.groupBox1.Controls.Add(this.BT_TAB_ADD);
            this.groupBox1.Controls.Add(this.RB_1NEG);
            this.groupBox1.Controls.Add(this.RB_1POS);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.TB_TAB_CASOS_X2);
            this.groupBox1.Controls.Add(this.TB_TAB_CASOS_X1);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.TAB_CASOS);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(13, 338);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(705, 340);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Casos";
            // 
            // BT_RESET_TAB
            // 
            this.BT_RESET_TAB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.BT_RESET_TAB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_RESET_TAB.Location = new System.Drawing.Point(18, 218);
            this.BT_RESET_TAB.Name = "BT_RESET_TAB";
            this.BT_RESET_TAB.Size = new System.Drawing.Size(163, 45);
            this.BT_RESET_TAB.TabIndex = 35;
            this.BT_RESET_TAB.Text = "Resetar tabela";
            this.BT_RESET_TAB.UseVisualStyleBackColor = false;
            this.BT_RESET_TAB.Click += new System.EventHandler(this.BT_RESET_TAB_Click);
            // 
            // BT_LIMPA_TAB
            // 
            this.BT_LIMPA_TAB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.BT_LIMPA_TAB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_LIMPA_TAB.Location = new System.Drawing.Point(18, 269);
            this.BT_LIMPA_TAB.Name = "BT_LIMPA_TAB";
            this.BT_LIMPA_TAB.Size = new System.Drawing.Size(163, 46);
            this.BT_LIMPA_TAB.TabIndex = 34;
            this.BT_LIMPA_TAB.Text = "Limpar tabela";
            this.BT_LIMPA_TAB.UseVisualStyleBackColor = false;
            this.BT_LIMPA_TAB.Click += new System.EventHandler(this.BT_LIMPA_TAB_Click);
            // 
            // BT_TAB_ADD
            // 
            this.BT_TAB_ADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.BT_TAB_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_TAB_ADD.Location = new System.Drawing.Point(18, 169);
            this.BT_TAB_ADD.Name = "BT_TAB_ADD";
            this.BT_TAB_ADD.Size = new System.Drawing.Size(163, 43);
            this.BT_TAB_ADD.TabIndex = 33;
            this.BT_TAB_ADD.Text = "Adicionar caso";
            this.BT_TAB_ADD.UseVisualStyleBackColor = false;
            this.BT_TAB_ADD.Click += new System.EventHandler(this.BT_TAB_ADD_Click);
            // 
            // RB_1NEG
            // 
            this.RB_1NEG.AutoSize = true;
            this.RB_1NEG.Location = new System.Drawing.Point(134, 128);
            this.RB_1NEG.Name = "RB_1NEG";
            this.RB_1NEG.Size = new System.Drawing.Size(41, 22);
            this.RB_1NEG.TabIndex = 30;
            this.RB_1NEG.TabStop = true;
            this.RB_1NEG.Text = "-1";
            this.RB_1NEG.UseVisualStyleBackColor = true;
            // 
            // RB_1POS
            // 
            this.RB_1POS.AutoSize = true;
            this.RB_1POS.Location = new System.Drawing.Point(83, 128);
            this.RB_1POS.Name = "RB_1POS";
            this.RB_1POS.Size = new System.Drawing.Size(45, 22);
            this.RB_1POS.TabIndex = 29;
            this.RB_1POS.TabStop = true;
            this.RB_1POS.Text = "+1";
            this.RB_1POS.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(8, 128);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 18);
            this.label17.TabIndex = 28;
            this.label17.Text = "Target:";
            // 
            // TB_TAB_CASOS_X2
            // 
            this.TB_TAB_CASOS_X2.Location = new System.Drawing.Point(49, 87);
            this.TB_TAB_CASOS_X2.Name = "TB_TAB_CASOS_X2";
            this.TB_TAB_CASOS_X2.Size = new System.Drawing.Size(142, 26);
            this.TB_TAB_CASOS_X2.TabIndex = 27;
            // 
            // TB_TAB_CASOS_X1
            // 
            this.TB_TAB_CASOS_X1.Location = new System.Drawing.Point(49, 52);
            this.TB_TAB_CASOS_X1.Name = "TB_TAB_CASOS_X1";
            this.TB_TAB_CASOS_X1.Size = new System.Drawing.Size(142, 26);
            this.TB_TAB_CASOS_X1.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(8, 91);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 18);
            this.label16.TabIndex = 25;
            this.label16.Text = "X2:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(8, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 18);
            this.label15.TabIndex = 24;
            this.label15.Text = "X1:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(8, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 18);
            this.label14.TabIndex = 23;
            this.label14.Text = "Valores:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.TB_PESOS_W2);
            this.groupBox2.Controls.Add(this.TB_PESOS_W1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(15, 100);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(310, 150);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesos iniciais";
            // 
            // TB_PESOS_W2
            // 
            this.TB_PESOS_W2.Location = new System.Drawing.Point(52, 82);
            this.TB_PESOS_W2.Name = "TB_PESOS_W2";
            this.TB_PESOS_W2.Size = new System.Drawing.Size(100, 26);
            this.TB_PESOS_W2.TabIndex = 3;
            // 
            // TB_PESOS_W1
            // 
            this.TB_PESOS_W1.Location = new System.Drawing.Point(52, 48);
            this.TB_PESOS_W1.Name = "TB_PESOS_W1";
            this.TB_PESOS_W1.Size = new System.Drawing.Size(100, 26);
            this.TB_PESOS_W1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "W2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "W1:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.TB_BIAS_X0);
            this.groupBox3.Controls.Add(this.TB_BIAS_W0);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(352, 100);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(310, 150);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bias";
            // 
            // TB_BIAS_X0
            // 
            this.TB_BIAS_X0.Location = new System.Drawing.Point(47, 48);
            this.TB_BIAS_X0.Name = "TB_BIAS_X0";
            this.TB_BIAS_X0.Size = new System.Drawing.Size(100, 26);
            this.TB_BIAS_X0.TabIndex = 7;
            // 
            // TB_BIAS_W0
            // 
            this.TB_BIAS_W0.Location = new System.Drawing.Point(47, 84);
            this.TB_BIAS_W0.Name = "TB_BIAS_W0";
            this.TB_BIAS_W0.Size = new System.Drawing.Size(100, 26);
            this.TB_BIAS_W0.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "W0:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "X0:";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox5.Controls.Add(this.TB_MAXTREINO);
            this.groupBox5.Controls.Add(this.TB_TREINO_ALFA);
            this.groupBox5.Controls.Add(this.LB_QTDE_TREINOS);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(687, 100);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(330, 150);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Treinamento";
            // 
            // TB_MAXTREINO
            // 
            this.TB_MAXTREINO.Location = new System.Drawing.Point(221, 71);
            this.TB_MAXTREINO.Name = "TB_MAXTREINO";
            this.TB_MAXTREINO.Size = new System.Drawing.Size(100, 26);
            this.TB_MAXTREINO.TabIndex = 10;
            // 
            // TB_TREINO_ALFA
            // 
            this.TB_TREINO_ALFA.Location = new System.Drawing.Point(221, 30);
            this.TB_TREINO_ALFA.Name = "TB_TREINO_ALFA";
            this.TB_TREINO_ALFA.Size = new System.Drawing.Size(100, 26);
            this.TB_TREINO_ALFA.TabIndex = 9;
            // 
            // LB_QTDE_TREINOS
            // 
            this.LB_QTDE_TREINOS.AutoSize = true;
            this.LB_QTDE_TREINOS.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_QTDE_TREINOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.LB_QTDE_TREINOS.Location = new System.Drawing.Point(150, 104);
            this.LB_QTDE_TREINOS.Name = "LB_QTDE_TREINOS";
            this.LB_QTDE_TREINOS.Size = new System.Drawing.Size(25, 27);
            this.LB_QTDE_TREINOS.TabIndex = 8;
            this.LB_QTDE_TREINOS.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(8, 111);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Nº de treinamentos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(8, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nº máximo de treinamentos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(8, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Taxa de aprendizagem (passo):";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox6.Controls.Add(this.LB_FINAL_W2);
            this.groupBox6.Controls.Add(this.LB_FINAL_W1);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.Black;
            this.groupBox6.Location = new System.Drawing.Point(1047, 100);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Size = new System.Drawing.Size(310, 150);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Pesos finais";
            // 
            // LB_FINAL_W2
            // 
            this.LB_FINAL_W2.AutoSize = true;
            this.LB_FINAL_W2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_FINAL_W2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.LB_FINAL_W2.Location = new System.Drawing.Point(47, 87);
            this.LB_FINAL_W2.Name = "LB_FINAL_W2";
            this.LB_FINAL_W2.Size = new System.Drawing.Size(25, 27);
            this.LB_FINAL_W2.TabIndex = 10;
            this.LB_FINAL_W2.Text = "0";
            // 
            // LB_FINAL_W1
            // 
            this.LB_FINAL_W1.AutoSize = true;
            this.LB_FINAL_W1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LB_FINAL_W1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_FINAL_W1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.LB_FINAL_W1.Location = new System.Drawing.Point(47, 42);
            this.LB_FINAL_W1.Name = "LB_FINAL_W1";
            this.LB_FINAL_W1.Size = new System.Drawing.Size(25, 27);
            this.LB_FINAL_W1.TabIndex = 9;
            this.LB_FINAL_W1.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(8, 91);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "W2:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(8, 46);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "W1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 43);
            this.label5.TabIndex = 17;
            this.label5.Text = "P1 - NeuroGM";
            // 
            // BT_TREINAR
            // 
            this.BT_TREINAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.BT_TREINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_TREINAR.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_TREINAR.ForeColor = System.Drawing.Color.Black;
            this.BT_TREINAR.Location = new System.Drawing.Point(15, 265);
            this.BT_TREINAR.Name = "BT_TREINAR";
            this.BT_TREINAR.Size = new System.Drawing.Size(703, 58);
            this.BT_TREINAR.TabIndex = 22;
            this.BT_TREINAR.Text = "TREINAR";
            this.BT_TREINAR.UseVisualStyleBackColor = false;
            this.BT_TREINAR.Click += new System.EventHandler(this.BT_TREINAR_Click);
            // 
            // FORM_P1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1384, 701);
            this.Controls.Add(this.BT_TREINAR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(0)))), ((int)(((byte)(59)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FORM_P1";
            this.Text = "NeuroGM";
            ((System.ComponentModel.ISupportInitialize)(this.GRAF_CASOS)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRAF_PESOS)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TAB_CASOS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GRAF_CASOS;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView TAB_CASOS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataVisualization.Charting.Chart GRAF_PESOS;
        private System.Windows.Forms.ListBox LT_LOG_TREINO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_PESOS_W2;
        private System.Windows.Forms.TextBox TB_PESOS_W1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_BIAS_X0;
        private System.Windows.Forms.TextBox TB_BIAS_W0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LB_QTDE_TREINOS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LB_FINAL_W2;
        private System.Windows.Forms.Label LB_FINAL_W1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TB_MAXTREINO;
        private System.Windows.Forms.TextBox TB_TREINO_ALFA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn X1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X2;
        private System.Windows.Forms.DataGridViewTextBoxColumn T;
        private System.Windows.Forms.RadioButton RB_1NEG;
        private System.Windows.Forms.RadioButton RB_1POS;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TB_TAB_CASOS_X2;
        private System.Windows.Forms.TextBox TB_TAB_CASOS_X1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BT_TREINAR;
        private System.Windows.Forms.Button BT_TAB_ADD;
        private System.Windows.Forms.Button BT_LIMPA_TAB;
        private System.Windows.Forms.Button BT_RESET_TAB;
    }
}

