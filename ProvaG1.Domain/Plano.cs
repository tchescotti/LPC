namespace ProvaG1.Domain
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