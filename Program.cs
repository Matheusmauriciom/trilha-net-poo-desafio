using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone Nokia = new Nokia(numero: "123456", modelo: "Nokia 2.4 Cinza", imei: "11111", memoria: 64);
Nokia.Ligar();
Nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone Iphone = new Iphone(numero: "123456", modelo: "iPhone 15 Pro Max", imei: "11111", memoria: 256);
Iphone.Ligar();
Iphone.InstalarAplicativo("Telegram");
