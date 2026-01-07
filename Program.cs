using DesafioPOO.Models;

List<Smartphone> smartphones = new();
Iphone iphone = new Iphone("123456789", "iPhone 12", "IMEI123456789", 128);
Nokia nokia = new Nokia("987654321", "Nokia 3310", "IMEI987654321", 64);

smartphones.Add(iphone);
smartphones.Add(nokia);

foreach (var phone in smartphones)
{
    Console.Write("\n");
    if (phone is Iphone)
    {
        phone.InstalarAplicativo("WhatsApp");
    }
    else if (phone is Nokia)
    {
        phone.InstalarAplicativo("Telegram");
    }
    else
    {
        throw new NotImplementedException("Modelo desconhecido...");
    }

    phone.Ligar();
    phone.ReceberLigacao();
    Console.WriteLine("********************************");
}