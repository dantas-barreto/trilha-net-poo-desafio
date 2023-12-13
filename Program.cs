using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("99999-9999", "Modelo 1", "1234567890", 64);
nokia.Ligar("22 92222-2222");
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone("98888-8888", "Modelo 2", "0987654321", 128);
iphone.ReceberLigacao("11 91111-1111");
iphone.InstalarAplicativo("Youtube");