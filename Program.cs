using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//* IMPLEMENTADO

Console.WriteLine("----------------  Nokia  --------------");
Nokia nokia = new("1234-5678", "Modelo 1", "111111111", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("YouTube");

Console.WriteLine("\n");

Console.WriteLine("--------------  Iphone  ----------------");
Iphone iphone = new("4323-8974", "Modelo 5", "222222222", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Netflix");