string nome;
string sobrenome;

Console.Write("Insira seu Nome:");
nome = Console.ReadLine()!;

Console.Write("Digite seu Sobrenome:");
sobrenome= Console.ReadLine()!.ToUpper();

Console.WriteLine($"Nome completo: {nome} {sobrenome}");
Console.WriteLine($"Nome do catálogo: {sobrenome} {nome}");
