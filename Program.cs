using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Nokia myNokia = new Nokia(numero: "983999999", modelo: "Nokia G21", imei: "IMEI999", memoria: 128);
myNokia.Ligar(); 
myNokia.InstalarAplicativo("WhatsApp"); 

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Iphone myIphone = new Iphone(numero: "986888888", modelo: "iPhone 15 Pro Max", imei: "IMEI777", memoria: 64);
myIphone.ReceberLigacao();
myIphone.InstalarAplicativo("Telegram");

