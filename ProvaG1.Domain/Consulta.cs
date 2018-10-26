namespace ProvaG1.Domain
{
    public class Consulta
    {
        public Consulta(){}
        
        public Consulta(int id,
                        string status,
                        string data,
                        string horario,
                        string descricao,
                        string numeroDeConsultas,
                        double valor,
                        Cliente cliente)
        {
            this.id = 0;
            this.status = status;
            this.data = data;
            this.horario = horario;
            this.descricao = descricao;
            this.numeroDeConsultas = numeroDeConsultas;
            this.valor = valor;
            this.cliente = cliente;
        }

        public int id { get; set; }
        public string status { get; set; }
        public string data { get; set; }
        public string horario { get; set; }
        public string descricao { get; set; }
        public string numeroDeConsultas { get; set; }
        public double valor { get; set; }
        public Cliente cliente { get; set; }
    }
}