using DesafioPOO.Models;

// IMPLEMENTADO
Console.WriteLine("Para o Iphone:");
Iphone iphone = new Iphone(numero: "123456789", modelo: "Modelo 2", imei: "111111", memoria: 120);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\nPara o Nokia:");
Nokia nokia = new Nokia(numero: "987654321", modelo: "Modelo 5", imei:"444444", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");