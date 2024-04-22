int size = 10;
char[] palavra = new char[size];

Console.WriteLine("\nCharactere input");

for (int i = 0; i < size; i++)
{
    Console.Write($"\nType the {i + 1}° charactere: ");
    palavra[i] = char.Parse(Console.ReadLine());
}

for (int i = 0; i < size; i++)
{
    switch (palavra[i])
    {
        case 'a':
            palavra[i] = 'A';
            break;

        case 'e':
            palavra[i] = 'E';
            break;

        case 'i':
            palavra[i] = 'I';
            break;

        case 'o':
            palavra[i] = 'O';
            break;

        case 'u':
            palavra[i] = 'U';
            break;
    }
}

Console.WriteLine("\nTo Upper Case");

for (int i = 0; i < size; i++)
{
    Console.Write($"{palavra[i]} ");
}

Console.WriteLine("\n\nPress any key to continue...");
Console.ReadKey();