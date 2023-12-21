namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numeroInicial, string modeloCelular, string imeiCelular, int memoriaCelular) : base(numeroInicial, modeloCelular, imeiCelular, memoriaCelular)
        {
            
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando "+ nomeApp+" no Nokia");

        }
    }
}