using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia1 = new Nokia(numero: "1357824", modelo: "Nokia Tijolão", imei: "a1b2c3", memoria: 64);
nokia1.Ligar();
nokia1.InstalarAplicativo("Zap");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone1 = new Iphone(numero: "1357824", modelo: "Nokia Tijolão", imei: "a1b2c3", memoria: 64);
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Instagram");
