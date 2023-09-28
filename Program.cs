using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("88156740", "ABC", "IMEI55200", 16);
Console.WriteLine("Nokia: " + nokia.Imei);

nokia.Ligar("99999999");
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("---------------------");

Iphone iphone = new Iphone("99999999", "XYZ", "IMEI1651", 16);
Console.WriteLine("iPhone: " + iphone.Imei);

iphone.ReceberLigacao("988156740");
iphone.InstalarAplicativo("Google");
