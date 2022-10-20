/* Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

Console.Clear();
Console.Write("Укажите, из скольки элементов будет сформирован первоначальный строковый массив? >>> ");
int elements = int.Parse(Console.ReadLine()!);
string[] array = new string[elements];
string[] arrayResult = new string[elements];

for (int i = 0; i < elements; i++)
{
    Console.WriteLine("Введите элемент массива: ");
    array[i] = Console.ReadLine()!;
}

Console.WriteLine($"Получили массив, состоящий из {elements} строковых элементов и имеющий вид: ");
PrintStringArray(array);
Console.WriteLine();
Console.WriteLine("Новый массив созданный на основе введённого и состоящий из строк, длина которых меньше либо равна 3 символам: ");

for (int j = 0; j < array.Length;j++)
{
    if (array[j].Length <= 3)
    {
        arrayResult[j] = array[j];
    }
    
}

PrintStringArray(arrayResult);






// Метод печати строкового массива.
void PrintStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"[\"{array[i]}\"] ");
    }

}