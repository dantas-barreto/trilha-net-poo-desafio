namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string _numero;
        public string Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O numero nao pode ser vazio");
                }
            }
        }

        private string Modelo { get; }

        private string IMEI { get; }

        private int Memoria { get; }

        public Smartphone(string numero)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}