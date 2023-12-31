using DesafioPOO.Models;

Console.WriteLine("Iphone:");
Smartphone iphone = new Iphone(numero: "556489", modelo: "Modelo 1", imei: "012345678910", memoria: 32);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");

Console.WriteLine("\n\nNokia:");
Smartphone nokia = new Nokia(numero: "132498", modelo: "Modelo 2", imei: "109876543210", memoria: 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");
