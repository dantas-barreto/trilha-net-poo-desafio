namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        private string Modelo { get; }
        private string IMEI { get; }
        private int Memoria { get; }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando...");
        }
    }
}