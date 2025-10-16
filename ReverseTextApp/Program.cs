Console.Write("### Tersten Metin Uygulamasına Hoşgeldiniz ###");
Console.Write("Bir metin girin: ");
string input = Console.ReadLine();

// Metni tersten çevir
char[] charArray = input.ToCharArray();
Array.Reverse(charArray);
string reversed = new string(charArray);

Console.WriteLine($"Metnin tersten yazılışı: {reversed}");

Console.WriteLine("\nÇıkmak için bir tuşa basın...");
Console.ReadKey();
