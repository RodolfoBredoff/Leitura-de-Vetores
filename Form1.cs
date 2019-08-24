using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeituraVetores
{
    public partial class Form1 : Form
    {
        int[] soma;
        int[] vetor1;
        int[] vetor2;
        int tamanho;
        Random random = new Random();
        private string strPathFile = @"C:\temp\ArquivoResultado.txt";

        private void LeVetor1()
        {
            tamanho = random.Next(10, 50);
            vetor1 = new int[tamanho];

            for (int i = 0; i < vetor1.Length; i++)
            {
                vetor1[i] = random.Next(1, 25);
            }

        }

        private void LeVetor2()
        {
            tamanho = random.Next(10, 50);
            vetor2 = new int[tamanho];

            for (int i = 0; i < vetor2.Length; i++)
            {
                vetor2[i] = random.Next(1, 25);
            }
        }

        private void ResultadoVetor()
        {
            tamanho = random.Next(10, 50);
            soma = new int[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                soma[i] = vetor1[i] + vetor2[i];
            }
                try
                {
                    using (FileStream fs = File.Create(strPathFile))
                    {
                        using (StreamWriter sw = new StreamWriter(fs))
                        {
                            for(int i=0;i< tamanho; i++)
                            {
                            Console.WriteLine("\n");
                                sw.Write(soma[i].ToString()+"\n");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Arquivo criado com sucesso!!!");
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVetor1_Click(object sender, EventArgs e)
        {
            LeVetor1();
        }

        private void BtnVetor2_Click(object sender, EventArgs e)
        {
            LeVetor2();
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            ResultadoVetor();
        }
    }
}
