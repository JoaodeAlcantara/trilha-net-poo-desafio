using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Iphone: ");
Iphone iphone = new("999112233", "Iphone 13", "1212121212", 8);

iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n---\n");

Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new("999887766", "Nokia Tijolão", "34534534534", 4);

nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");