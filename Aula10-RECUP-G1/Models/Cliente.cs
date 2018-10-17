namespace Aula10_Avaliacao_G1.Models
{
    public class Cliente
    {
        public Cliente(){}

        public Cliente (int id,
                        string nome,
                        string endereco, 
                        string email,
                        string fone,
                        string dataNascimento,
                        Plano plano)
        {
                        this.id = 0;
                        this.nome = nome;
                        this.endereco = endereco;
                        this.email = email;
                        this.fone = fone;
                        this.dataNascimento = dataNascimento;
                        this.plano = plano;
        }

        public int id { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string email { get; set; }       
        public string fone { get; set; }
        public string dataNascimento { get; set; }
        public Plano plano { get; set; }             
    }
}