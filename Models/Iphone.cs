namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numeroInicial, string modeloCelular, string imeiCelular, int memoriaCelular) : base(numeroInicial, modeloCelular, imeiCelular, memoriaCelular)
        {
            
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando "+ nomeApp+" no Iphone");

        }
    }
}