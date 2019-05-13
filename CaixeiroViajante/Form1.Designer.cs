namespace CaixeiroViajante
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.chGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnUmaGen = new System.Windows.Forms.Button();
            this.txtCidades = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbGrafico = new System.Windows.Forms.CheckBox();
            this.chbApenasUltimaGer = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chGrafico)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(662, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gerar Cidades Random";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 604);
            this.panel1.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "3069.png");
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(522, 141);
            this.trackBar1.Maximum = 3;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(244, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "População";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "200";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "400";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(668, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "600";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(741, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "800";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Melhor Gene";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(518, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(248, 66);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 62);
            this.button2.TabIndex = 0;
            this.button2.Text = "100";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button8_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(531, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 62);
            this.button3.TabIndex = 0;
            this.button3.Text = "Limpar Genes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chGrafico
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Maroon;
            chartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.DarkRed;
            chartArea1.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.DimGray;
            chartArea1.BorderColor = System.Drawing.Color.Maroon;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.White;
            this.chGrafico.ChartAreas.Add(chartArea1);
            legend1.ForeColor = System.Drawing.Color.DarkRed;
            legend1.HeaderSeparatorColor = System.Drawing.Color.White;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.chGrafico.Legends.Add(legend1);
            this.chGrafico.Location = new System.Drawing.Point(785, 12);
            this.chGrafico.Name = "chGrafico";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.MarkerStep = 3;
            series1.Name = "Series1";
            this.chGrafico.Series.Add(series1);
            this.chGrafico.Size = new System.Drawing.Size(467, 604);
            this.chGrafico.TabIndex = 11;
            this.chGrafico.Text = "chart1";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 155);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 62);
            this.button4.TabIndex = 12;
            this.button4.Text = "500";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(531, 253);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 62);
            this.button5.TabIndex = 0;
            this.button5.Text = "Gerar Cidades Circulo";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(13, 87);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 62);
            this.button6.TabIndex = 0;
            this.button6.Text = "50";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(140, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(108, 62);
            this.button7.TabIndex = 0;
            this.button7.Text = "10";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnUmaGen
            // 
            this.btnUmaGen.Location = new System.Drawing.Point(13, 19);
            this.btnUmaGen.Name = "btnUmaGen";
            this.btnUmaGen.Size = new System.Drawing.Size(108, 62);
            this.btnUmaGen.TabIndex = 0;
            this.btnUmaGen.Text = "1";
            this.btnUmaGen.UseVisualStyleBackColor = true;
            this.btnUmaGen.Click += new System.EventHandler(this.button8_Click);
            // 
            // txtCidades
            // 
            this.txtCidades.Location = new System.Drawing.Point(531, 205);
            this.txtCidades.Name = "txtCidades";
            this.txtCidades.Size = new System.Drawing.Size(100, 20);
            this.txtCidades.TabIndex = 13;
            this.txtCidades.TextChanged += new System.EventHandler(this.TxtCidades_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(528, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cidades";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(662, 169);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Fator Aleatório";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(140, 155);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(108, 62);
            this.button8.TabIndex = 12;
            this.button8.Text = "1000";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(662, 321);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(108, 62);
            this.button9.TabIndex = 0;
            this.button9.Text = "Limpar Tudo";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUmaGen);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(518, 389);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 227);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " + Gerações";
            // 
            // chbGrafico
            // 
            this.chbGrafico.AutoSize = true;
            this.chbGrafico.Checked = true;
            this.chbGrafico.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbGrafico.Location = new System.Drawing.Point(662, 192);
            this.chbGrafico.Name = "chbGrafico";
            this.chbGrafico.Size = new System.Drawing.Size(93, 17);
            this.chbGrafico.TabIndex = 15;
            this.chbGrafico.Text = "Gráfico Visivel";
            this.chbGrafico.UseVisualStyleBackColor = true;
            this.chbGrafico.CheckedChanged += new System.EventHandler(this.ChbGrafico_CheckedChanged);
            // 
            // chbApenasUltimaGer
            // 
            this.chbApenasUltimaGer.AutoSize = true;
            this.chbApenasUltimaGer.Location = new System.Drawing.Point(662, 215);
            this.chbApenasUltimaGer.Name = "chbApenasUltimaGer";
            this.chbApenasUltimaGer.Size = new System.Drawing.Size(100, 17);
            this.chbApenasUltimaGer.TabIndex = 15;
            this.chbApenasUltimaGer.Text = "Apenas últ. ger.";
            this.chbApenasUltimaGer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 625);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chbApenasUltimaGer);
            this.Controls.Add(this.chbGrafico);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCidades);
            this.Controls.Add(this.chGrafico);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Caixeiro Viajante - Algoritimo Genético";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chGrafico)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chGrafico;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnUmaGen;
        private System.Windows.Forms.TextBox txtCidades;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbGrafico;
        private System.Windows.Forms.CheckBox chbApenasUltimaGer;
    }
}

