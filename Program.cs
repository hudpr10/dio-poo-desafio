using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("5535931845093", "Nokia", "038210983109", 256);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine();

Console.WriteLine("Smartphone iPhone:");
Iphone iphone = new Iphone("5535980716451", "iPhone", "039210983109", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");  