//Questão 1
var arr = new List<int> { 7, 5, 3, 9, 6, 4, 1 };

var arr2 = arr.ToList();

arr2.Remove(4);  
for (int i = 0; i < arr2.Count; i++)
{
	if (arr2[i] == 9)
	{
        arr2[i] = 5;
    }
}

foreach (int i in arr)
{
    Console.WriteLine(i);
}

foreach (int i in arr2)
{
    Console.WriteLine(i);
}

Console.WriteLine(arr2.Sum());

//Questão 2 
//O resultado é 85, o total é 100, o total apenas do código 123 é 15, o total sem o código 123 é 100 - 15 = 85

//Questão 3
//Sinceramente não entendi muito bem o que o enunciado pedia kkk

var entrada = Console.ReadLine().Split(' ').Select(int.Parse);

var sum = entrada.ElementAt(0) + entrada.ElementAt(1);
try
{
    Console.WriteLine(entrada.ElementAt(sum));
}
catch
{
    Console.WriteLine($"A coleção não possui o indice {sum}");
}
