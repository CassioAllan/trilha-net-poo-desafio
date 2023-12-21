using DesafioPOO.Models;

Console.WriteLine("Smatphone Nokia: ");
Smartphone nokia = new  Nokia(numeroInicial: "1234", modeloCelular: "Modelo 23", imeiCelular: "909090909099", memoriaCelular: 216);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");
nokia.ReceberLigacao();


Console.WriteLine("\n");

Console.WriteLine("Smatphone Iphone: ");
Smartphone iphone = new Iphone(numeroInicial: "9876", modeloCelular: "Modelo 98", imeiCelular: "3434334", memoriaCelular: 216);
iphone.Ligar();
iphone.InstalarAplicativo("Marvel Snap");
iphone.ReceberLigacao();

