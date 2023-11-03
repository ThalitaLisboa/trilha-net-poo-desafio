using System.Text;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

List<Smartphone> smartphones = new List<Smartphone>();


Nokia nokia105 = new Nokia("12345678912", "Nokia 105", "123456789", "1 GB");
Nokia nokia205 = new Nokia("12345678912", "Nokia 205", "123456789", "1 GB");
Iphone iphone15 = new Iphone("12312312300", "Iphone 15", "789456123", "512 GB");
Iphone iphone13 = new Iphone("12312312300", "Iphone 13", "789456123", "512 GB");

smartphones.Add(nokia105);
smartphones.Add(nokia205);
smartphones.Add(iphone15);
smartphones.Add(iphone13);

foreach(var celular in smartphones)
{
    Console.WriteLine("Inicio teste ...");
    Console.WriteLine("\n");    
    Console.WriteLine($"Smartphone Número {celular.Numero}");    
    celular.Ligar(); 
    celular.ReceberLigacao();  
    Console.WriteLine("\n"); 
    celular.InstalarAplicativo("Whatsapp");
    celular.InstalarAplicativo("Telegram");    
    Console.WriteLine("Fim teste..."); 
    Console.WriteLine("\n");
}

