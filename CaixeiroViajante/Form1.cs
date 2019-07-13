using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixeiroViajante
{
    public partial class Form1 : Form
    {

        List<Cidades> Listacidades;
        Graphics grafico;
        int iPopulacao = 200;
        int iGeracoes = 0;
        List<Genes> ListaGenes;
        bool PrimeiraGen = true;
        //int[]
        int iCidades = 10;
        public Form1()
        {
            InitializeComponent();
            Listacidades = new List<Cidades>(10);
            ListaGenes = new List<Genes>();
            grafico = panel1.CreateGraphics();
            GerarCidadesRandom();
            DesenharCidades();
            txtCidades.Text = iCidades.ToString();
            groupBox1.Enabled = false;
        }

        private void InicializarListaGenes()
        {
            ListaGenes.Clear();
            for (int i = 0; i < iPopulacao; i++)
            {
                ListaGenes.Add(new Genes());
            }
            PrimeiraGen = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpar();

            Listacidades.Clear();

            iCidades = Convert.ToInt32(txtCidades.Text);

            for (int i = 0; i < iCidades; i++)
            {
                Listacidades.Add(new Cidades());
            }
            grafico.Clear(Color.White);
            GerarCidadesRandom();
            DesenharCidades();
        }

        private void DesenharCidades()
        {
            foreach (Cidades item in Listacidades)
            {
                Pen penvermelho = new Pen(Color.Red, 4);
                grafico.DrawEllipse(penvermelho, item.X, item.Y, 4, 4);
            }
        }

        private void GerarCidadesRandom()
        {
            Random rnd = new Random();

            foreach (Cidades cidade in Listacidades)
            {
                cidade.X = rnd.Next(50, 500);
                cidade.Y = rnd.Next(50, 500);
            }
        }

        private void GerarCidadesCirculo()
        {
            int centerx = panel1.Width/2;
            int centery = panel1.Height/2;

            double sigma = (2*Math.PI)/iCidades;

            for (int i = 0; i < iCidades; i++)
            {
                Listacidades[i].X = (int)Math.Round((150 * Math.Cos(sigma * i) + centerx), 0);
                Listacidades[i].Y = (int)Math.Round((150 * Math.Sin(sigma * i) + centery), 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grafico.Clear(Color.White);
            DesenharCidades();
            //iPopulacao = 50 * (trackBar1.Value + 1);
            int iqtd = 0;
            if (PrimeiraGen)
            {
                InicializarListaGenes();
                CriarPrimeiraGen();
            }
                do
                {
                    Evoluir();
                    iGeracoes++;
                    iqtd++;
                    this.Refresh();
                    DesenharCidades();
                    DesenharCaminhos();
                } while (iqtd < 100);
            

            DesenharCaminhos();
        }

        private void CriarPrimeiraGen()
        {
            Random rnd = new Random();

            for (int i = 0; i < iPopulacao; i++)
            {
                ListaGenes[i].Ordem = new List<int>(iCidades);
                List<int> possibilidades = new List<int>((iCidades - 1));

                for (int a = 0; a < iCidades; a++)
                {
                    possibilidades.Add(a + 1);
                }

                ListaGenes[i].Ordem.Add(0);

                for (int a = 1; a < iCidades; a++)
                {
                    int ivalor = rnd.Next(0, possibilidades.Count - 1);
                    ListaGenes[i].Ordem.Add(possibilidades[ivalor]);
                    possibilidades.RemoveAt(ivalor);
                }

                double iDistancia = 0;
                if (Listacidades.Count > 0)
                {
                    for (int a = 1; a < iCidades; a++)//começa do segundo item
                    {
                        iDistancia += Math.Sqrt(Math.Pow((Listacidades[ListaGenes[i].Ordem[a]].X - Listacidades[ListaGenes[i].Ordem[a - 1]].X), 2) + Math.Pow((Listacidades[ListaGenes[i].Ordem[a]].Y - Listacidades[ListaGenes[i].Ordem[a - 1]].Y), 2));
                    }
                    ListaGenes[i].Distancia = (int)Math.Round(iDistancia, 0);
                }
            }
            ListaGenes = ListaGenes.OrderBy(Genes => Genes.Distancia).ToList();

            chGrafico.Series[0].Points.AddXY(iGeracoes, ListaGenes[0].Distancia);
        }

        private void DesenharCaminhos()
        {
            Pen pen = new Pen(Color.Blue, 2);
            Genes Primeiro = ListaGenes[0];
            if (Listacidades.Count > 0)
            {
                for (int i = 1; i < iCidades; i++)//Pula o primeiro
                {
                    grafico.DrawLine(pen, Listacidades[Primeiro.Ordem[i]].X,
                                         Listacidades[Primeiro.Ordem[i]].Y,
                                         Listacidades[Primeiro.Ordem[i - 1]].X,
                                         Listacidades[Primeiro.Ordem[i - 1]].Y);
                }

                grafico.DrawLine(pen, Listacidades[Primeiro.Ordem[0]].X,
                                         Listacidades[Primeiro.Ordem[0]].Y,
                                         Listacidades[Primeiro.Ordem[iCidades-1]].X,
                                         Listacidades[Primeiro.Ordem[iCidades - 1]].Y);
            }
                richTextBox1.Text = "Distância: " + Primeiro.Distancia + "\n";
            
            foreach (int item in Primeiro.Ordem)
            {
                richTextBox1.Text += item + ",";
            }

            richTextBox1.Text += "\nGerações: " + iGeracoes;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Limpar();
            DesenharCidades();
        }

        private void Evoluir()
        {
            List<Genes> ListaGenesAnterior = new List<Genes>(ListaGenes);
            List<Genes> Campeoes = new List<Genes>();
            
            Random rnd = new Random();

            int distanciaCampeao = ListaGenes[0].Distancia;

            for (int i = 0; i < iPopulacao/50; i++)
            {
                Campeoes.Add((ListaGenes[i]));
                Campeoes.Add((ListaGenes[rnd.Next(5, iPopulacao)]));
                Genes geneReverso = new Genes();
                geneReverso.Ordem = new List<int>();
                geneReverso.Ordem.Add(0);
                for (int w = 1; w < iCidades; w++)
                {
                    geneReverso.Ordem.Add(ListaGenes[i].Ordem[iCidades - w]);
                }
                Campeoes.Add(geneReverso);

                if (checkBox1.CheckState == CheckState.Checked)
                {
                    Genes geneAleatorio = new Genes();
                    geneAleatorio.Ordem = new List<int>();
                    List<int> possibilidades = new List<int>((iCidades - 1));

                    for (int a = 0; a < iCidades; a++)
                    {
                        possibilidades.Add(a + 1);
                    }

                    geneAleatorio.Ordem.Add(0);

                    for (int a = 1; a < iCidades; a++)
                    {
                        int ivalor = rnd.Next(0, possibilidades.Count - 1);
                        geneAleatorio.Ordem.Add(possibilidades[ivalor]);
                        possibilidades.RemoveAt(ivalor);
                    }

                    Campeoes.Add(geneAleatorio);
                }
            }

            

            for (int i = 1; i < iPopulacao; i++)
            {
                int startIndexClone = rnd.Next(1, iCidades-1);
                List<int> CampeaoSorteado = new List<int>();
                CampeaoSorteado.AddRange(Campeoes[rnd.Next(0, Campeoes.Count)].Ordem);
                List<int> GeneAtual = new List<int>();
                //GeneAtual.AddRange((ListaGenes[i].Ordem));
                GeneAtual.AddRange(Campeoes[rnd.Next(0, Campeoes.Count)].Ordem);

                List<int> NovoGene = new List<int>(iCidades);// { 0, -1, -1, -1, -1, -1, -1, -1, -1, -1};

                NovoGene.Add(0);

                for (int a = 1; a < iCidades; a++)
                {
                    NovoGene.Add(-1);
                }

                int c = 0;
                //fator de descendencia
                int idesc = rnd.Next(0, iCidades);
                for (int a = 0; c < idesc; a++)
                {
                    if (startIndexClone + a == iCidades)
                    {
                        startIndexClone = 1;
                        a = 0;
                    }
                    
                    NovoGene[startIndexClone + a] = CampeaoSorteado[startIndexClone + a];
                    c++;
                }

                double iDistancia = 0;
                //completa o resto dos cromos
                for (int a = 1; a < iCidades; a++)
                {
                    if (!NovoGene.Contains(GeneAtual[a]))
                    {
                        if (NovoGene[a] == -1 && (rnd.Next(0, 100) < 80))
                        {
                            NovoGene[a] = GeneAtual[a];
                        }
                        else
                        {
                            for (int r = 0; r < iCidades; r++)
                            {
                                if (NovoGene[r] == -1)
                                {
                                    NovoGene[r] = GeneAtual[a];
                                    break;
                                }
                            }
                        }
                    }
                }

                
                for (int t = 0; t < iCidades/20; t++)
                {
                    if (rnd.Next(0, 100) > 70)
                    {
                        int iPosA = rnd.Next(1, iCidades - 1);
                        int iPosB = rnd.Next(1, iCidades - 1);

                        int iTempA = NovoGene[iPosA];

                        int iTempB = NovoGene[iPosB];

                        NovoGene[iPosA] = iTempB;
                        NovoGene[iPosB] = iTempA;
                    }
                }

                ListaGenes[i].Ordem = NovoGene;
                
                if (Listacidades.Count > 0)
                {
                    for (int a = 1; a < iCidades; a++)//começa do segundo item
                    {
                        iDistancia += Math.Sqrt(Math.Pow((Listacidades[ListaGenes[i].Ordem[a]].X - Listacidades[ListaGenes[i].Ordem[a - 1]].X), 2) + Math.Pow((Listacidades[ListaGenes[i].Ordem[a]].Y - Listacidades[ListaGenes[i].Ordem[a - 1]].Y), 2));
                    }
                    ListaGenes[i].Distancia = (int)Math.Round(iDistancia, 0);
                }
            }
            ListaGenes = ListaGenes.OrderBy(Genes => Genes.Distancia).ToList();

            chGrafico.Series[0].Points.AddXY(iGeracoes, ListaGenes[0].Distancia);
            chGrafico.ChartAreas[0].AxisY.Minimum = (ListaGenes[0].Distancia - 50);

        }
    
        private void button4_Click(object sender, EventArgs e)
        {
            grafico.Clear(Color.White);
            DesenharCidades();
            int iqtd = 0;
            int itemp = 0;
            if (PrimeiraGen)
            {
                InicializarListaGenes();
                CriarPrimeiraGen();
                
            }
            do
            {
                Evoluir();
                iGeracoes++;
                iqtd++;
                itemp++;
                if (itemp == 50)
                {
                    this.Refresh();
                    DesenharCidades();
                    DesenharCaminhos();
                    itemp = 0;
                }
            } while (iqtd < 500);

            this.Refresh();
            DesenharCidades();
            DesenharCaminhos();

        }

        private void Limpar()
        {
            ListaGenes.Clear();
            
            iGeracoes = 0;
            grafico.Clear(Color.White);
            PrimeiraGen = true;
            chGrafico.Series[0].Points.Clear();

        }
        private void button5_Click(object sender, EventArgs e)
        {
            Limpar();
            Listacidades.Clear();

            if (EhInteiro(txtCidades.Text))
            { 
                iCidades = Convert.ToInt32(txtCidades.Text);
                groupBox1.Enabled = true;
            }
            else
            {
                iCidades = 0;
                groupBox1.Enabled = false;
            }

            for (int i = 0; i < iCidades; i++)
            {
                Listacidades.Add(new Cidades());
            }

            GerarCidadesCirculo();
            DesenharCidades();
        }

        private bool EhInteiro(string sValor)
        {
            bool bretorno = true;
            try
            {
                int itemp = Convert.ToInt32(sValor);
            }
            catch
            {
                bretorno = false;
            }

            return bretorno;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            grafico.Clear(Color.White);
            DesenharCidades();
            int iqtd = 0;

            if (PrimeiraGen)
            {
                InicializarListaGenes();
                CriarPrimeiraGen();
            }

            int iTemp = 0;
                do
                {
                    Evoluir();
                    iGeracoes++;
                    iqtd++;

                if (iTemp == Convert.ToInt32(((Button)sender).Text) / 10 && !chbApenasUltimaGer.Checked)
                {
                    this.Refresh();
                    DesenharCidades();
                    DesenharCaminhos();
                    iTemp = 0;
                }

                iTemp++;

                } while (iqtd < Convert.ToInt32(((Button)sender).Text));

            this.Refresh();
            DesenharCidades();
            DesenharCaminhos();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            iPopulacao = 200 * (trackBar1.Value + 1);
            Random rnd = new Random();
            if (ListaGenes.Count < iPopulacao)
            {
                for (int i = ListaGenes.Count; i < iPopulacao; i++)
                {
                    ListaGenes.Add(new Genes());


                    ListaGenes[i].Ordem = new List<int>(iCidades);
                    List<int> possibilidades = new List<int>(iCidades - 1);

                    for (int a = 0; a < iCidades; a++)
                    {
                        possibilidades.Add(a + 1);
                    }

                    ListaGenes[i].Ordem.Add(0);

                    for (int a = 1; a < iCidades; a++)
                    {
                        int ivalor = rnd.Next(0, possibilidades.Count - 1);
                        ListaGenes[i].Ordem.Add(possibilidades[ivalor]);
                        possibilidades.RemoveAt(ivalor);
                    }

                    double iDistancia = 0;
                    if (Listacidades.Count > 0)
                    {
                        for (int a = 1; a < iCidades; a++)//começa do segundo item
                        {
                            iDistancia += Math.Sqrt(Math.Pow((Listacidades[ListaGenes[i].Ordem[a]].X - Listacidades[ListaGenes[i].Ordem[a - 1]].X), 2) + Math.Pow((Listacidades[ListaGenes[i].Ordem[a]].Y - Listacidades[ListaGenes[i].Ordem[a - 1]].Y), 2));
                        }
                        ListaGenes[i].Distancia = (int)Math.Round(iDistancia, 0);
                    }
                }
            }
            else
            {
                for (int i = ListaGenes.Count; i < iPopulacao; i++)
                {
                    ListaGenes.RemoveAt((ListaGenes.Count - 1));
                }
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Listacidades.Clear();
            groupBox1.Enabled = false;
            Limpar();
        }

        private void ChbGrafico_CheckedChanged(object sender, EventArgs e)
        {
            chGrafico.Visible = chbGrafico.Checked;
            
        }

        private void TxtCidades_TextChanged(object sender, EventArgs e)
        {
            Limpar();
            Listacidades.Clear();
            groupBox1.Enabled = false;
            
        }
    }

    public class Cidades
    {
        public int X { get; set; }

        public int Y { get; set; }
    }

    public class Genes
    {
        public List<int> Ordem { get; set; }
        public int Distancia { get; set; }
    }
}
