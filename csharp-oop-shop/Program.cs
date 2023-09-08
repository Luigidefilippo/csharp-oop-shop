using csharp_oop_shop;

Prodotto prodotto1 = new Prodotto();
prodotto1.Nome = "Monopattino ";
prodotto1.Descrizione = "Da usare in città per evitare il traffico ";
prodotto1.Prezzo = 500.0m;
prodotto1.IVA = 22.0m;

//CREAZIONE SECONDO PRODOTTO 
Prodotto prodotto2 = new Prodotto();
prodotto2.Nome = "Bicicletta all-road ";
prodotto2.Descrizione = "Leggera come una piuma ruote da 19' ";
prodotto2.Prezzo = 3000.0m;
prodotto2.IVA = 22.0m;

Console.WriteLine("Prodotto 1:");
Console.WriteLine($"Nome: {prodotto1.Nome}");
Console.WriteLine($"Descrizione: {prodotto1.Descrizione}");
Console.WriteLine($"Codice: {prodotto1.Codice}");
Console.WriteLine($"Prezzo Base: {prodotto1.PrezzoBase()}");
Console.WriteLine($"Prezzo con IVA: {prodotto1.PrezzoConIVA()}");
Console.WriteLine($"Nome Esteso: {prodotto1.NomeEsteso()}");

Console.WriteLine("\nProdotto 2:");
Console.WriteLine($"Nome: {prodotto2.Nome}");
Console.WriteLine($"Descrizione: {prodotto2.Descrizione}");
Console.WriteLine($"Codice: {prodotto2.Codice}");
Console.WriteLine($"Prezzo Base: {prodotto2.PrezzoBase()}");
Console.WriteLine($"Prezzo con IVA: {prodotto2.PrezzoConIVA()}");
Console.WriteLine($"Nome Esteso: {prodotto2.NomeEsteso()}");
    
