namespace DesafioPOO.Models
{
    public abstract class Smartphone(string numero, string modelo, string IMEI, int memoria)
    {
        public string Numero { get; set; } = numero;
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo = modelo;
        private string IMEI = IMEI;
        private int Memoria = memoria;

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