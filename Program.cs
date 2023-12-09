using System;
using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        // Testando a classe Nokia
        Nokia nokia = new Nokia("13579", "Nokia ModeloX", "IMEI001", 01);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Telegram");

        Console.WriteLine();

        // Testando a classe Iphone
        Iphone iphone = new Iphone("02468", "iPhone 12", "IMEI002", 02);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Whatsapp");
    }
}