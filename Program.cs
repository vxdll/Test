/* Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный масссив можно ввести с клавиатуры, либо задать на старте выполнение алгоритма.
При решении не рекомендуется пользоваnься коллекциями, лучше обойтись исключетительно массивами.
["hello", "2", "world", ";-)"] -> ["2",";-)"}
*/

Console.Clear();
Console.WriteLine("Введите длину вашего массива:");
int lenArr = Convert.ToInt32(Console.ReadLine());
string[] firstArr = new string[lenArr];
string[] newArr = new string[firstArr.Length];

FillArray(firstArr);
FillMainArr(firstArr, newArr);
Console.Write("Ваш массив: ");
PrintArray(newArr);


// Пишем метод на заполнение первичного массива
void FillArray(string[] arr)
{
    Console.WriteLine("Введите элементы массива:");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Console.ReadLine();
    }
}

// Пишем метод на заполнение второго массива
void FillMainArr(string[] arr1, string[] arr2)
{
    int j = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[j] = arr1[i];
            j++;
        }
    }
}

// Метод вывода массива
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != "")
        {
            Console.Write($"{arr[i]} ");
        }
    }
}



