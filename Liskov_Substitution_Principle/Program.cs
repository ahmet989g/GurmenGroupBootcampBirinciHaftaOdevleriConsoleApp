using Liskov_Substitution_Principle;

Kare kare = new Kare(5);
Console.WriteLine("Karenin Alanı: " + kare.AlanHesapla());

Dikdortgen dikdortgen = new Dikdortgen(10,4);
Console.WriteLine("Dikdörtgenin Alanı: " + dikdortgen.AlanHesapla());