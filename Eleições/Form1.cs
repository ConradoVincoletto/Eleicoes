using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eleições
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Eleições_Click(object sender, EventArgs e)
        {
            //Iniciar lista

            List<Candidatos> lista_candidato = new List<Candidatos>();
            lista_candidato.Add(new Candidatos() { Nome = "Izabel Ferrari", Votos = 0 });
            lista_candidato.Add(new Candidatos() { Nome = "Pedro Manoel Furlam", Votos = 0 });
            lista_candidato.Add(new Candidatos() { Nome = "Ivan Diniz Assan", Votos = 0 });
            lista_candidato.Add(new Candidatos() { Nome = "Thais Silveira Borges", Votos = 0 });

            lista_candidato.Add(new Candidatos() { Nome = "BRANCOS", Votos = 0 });
            lista_candidato.Add(new Candidatos() { Nome = "NULOS", Votos = 0 });

            // Iniciar mecanismo randômico

            Random rdm = new Random();

            // Atribuição de voto Brancos

            for (int i = 0; i < Quantidade_Votos.Value; i++)
            {
                if (rdm.Next(1, 100) <= track_votos_brancos.Value) //se a frequencia estiver entre 1 e 100 no trackbar, ele atribuirá votos no Nome Branco
                {
                    lista_candidato.Where(x => x.Nome == "BRANCOS").First().Votos++;
                    continue;
                }
            }
        }


    }
}
