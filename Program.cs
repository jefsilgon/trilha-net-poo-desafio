using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smatphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo:"Modelo 1",imei:"11111", memoria:64);

nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smatphone iPhone:");
Smartphone iphone = new Iphone(numero: "9854554", modelo:"Modelo 2",imei:"222222", memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");