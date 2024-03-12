var fruits = new List<string>();

fruits.Add(item: "cereja");
fruits.Add(item: "cereja");
fruits.Add(item: "abacaxi");
fruits.Add(item: "maçã");
fruits.Add(item: "pêssego");
fruits.Add(item: "mirtilo");
fruits.Add(item: "coco");
fruits.Add(item: "banana");

//1 - Primeiro elemento
Console.WriteLine(fruits.First());
Console.WriteLine(fruits.FirstOrDefault("Não encontrei"));

//2 - Verificar se um elemento existe
Console.WriteLine(fruits.Any(x => x == "cereja"));

//3 - Verificar se todos os elementos são de um tipo
Console.WriteLine(fruits.All(x => x == "cereja"));

//4 - Contar
Console.WriteLine(fruits.Count); //conta todos
Console.WriteLine(fruits.Count(x => x == "cereja")); //conta as cerejas

//5 - ElementAt - índice
Console.WriteLine(fruits.ElementAt(5));

//6 - Take
//fruits.Take(3); //3 primeiros
//fruits.Take(..3); //3 últimos = .. é o range operator
//fruits.Take(1..3); //range 1 ao 3

foreach (var fruit in fruits.Take(3))
    Console.WriteLine(fruit);

//7 - Where
foreach (var fruit in fruits.Where(x => x == "cereja" || x == "banana"))
    Console.WriteLine(fruit);

//8 - Single
//expressão só pode retornar um item
Console.WriteLine(fruits.Single(x => x == "banana"));

//9 - Último
Console.WriteLine(fruits.Last());
Console.WriteLine(fruits.Last(x => x == "cereja"));

//10 - Skip
foreach (var fruit in fruits.Skip(3)) 
    Console.WriteLine(fruit);

//skip e take são muito usados para paginação, porém pode-se usar take informando range

