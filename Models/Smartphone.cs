namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string _numero;
        public string Numero { get; set; }

        public Smartphone(string numero)
        {
            Numero = numero;
        }

        public void Ligar(string telefone)
        {
            Console.WriteLine($"Ligando para o número: {telefone}");
        }

        public void ReceberLigacao(string telefone)
        {
            Console.WriteLine($"Recebendo ligação de {telefone}");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}