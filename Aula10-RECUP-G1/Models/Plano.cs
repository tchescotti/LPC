using Aula10_Avaliacao_G1.Models;

namespace Aula10_Avaliacao_G1.Models
{
    public class Plano
    {
        public Plano(){}

        public Plano (int id,
                      string nome)
        {
                      this.id = 0;
                      this.nome = nome;
        }

        public int id { get; set; }
        public string nome { get; set; }
    }
}