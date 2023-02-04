using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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

            Random Rnd = new Random();

            //atribuição de votos

            for(int i = 0; i < Quantidade_Votos.Value; i++)
            {
                //definir se para atribuir voto Branco
                if(Rnd.Next(0, 100) < track_votos_brancos.Value)
                {
                    lista_candidato.Where(x => x.Nome == "BRANCOS").First().Votos++;
                    continue;
                   
                }
                if(Rnd.Next(0,100) < track_votos_nulos.Value)
                {
                    lista_candidato.Where(x => x.Nome == "NULOS").First() .Votos++;
                    continue;
                }

                //atribuir votos aos candidatos
                lista_candidato[Rnd.Next(0, lista_candidato.Count - 2)].Votos++;
            }
            //apresentar os resultados
            Resultado_Eleições.Items.Clear();
            var candidatos = lista_candidato.Where(x => x.Nome != "BRANCOS" && x.Nome != "NULOS");
            int posição = 1;
            foreach(var candidato in candidatos)
            {
                Resultado_Eleições.Items.Add(posição.ToString() + "° " + ConstroiLinha(candidato));
                posição++;
            }
            //apresentar brancos e nulos
            Resultado_Eleições.Items.Add(" ");
            var outros_resultados = lista_candidato.Where(x => x.Nome == "BRANCOS" || x.Nome == "NULOS");
            foreach(var outro_resultado in outros_resultados)
            {
                Resultado_Eleições.Items.Add(outro_resultado.Nome.ToString() + ConstroiLinha(outro_resultado));
            }
                      
              
        }
        private string ConstroiLinha(Candidatos item)
        {
            //construir a linha de resultados
            
            StringBuilder sb = new StringBuilder();
            sb.Append(item.Nome);
            sb.Append(new string('.', 30 - item.Nome.Length));
            sb.Append(item.Votos);
            return sb.ToString();

        }


    }
}
