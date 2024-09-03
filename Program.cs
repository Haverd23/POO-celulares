using DesafioPOO.Models;

Nokia nokia = new Nokia("12345678","C2","76576543443",500);
nokia.InstalarAplicativo("Linkedin");
nokia.Ligar();
nokia.ReceberLigacao();

Console.WriteLine("--------------------------------------");

Iphone iphone = new Iphone("87654321","13","0917346243",1000);
iphone.InstalarAplicativo("Facebook");
iphone.Ligar();
iphone.ReceberLigacao();