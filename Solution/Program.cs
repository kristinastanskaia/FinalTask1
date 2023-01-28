// Решение задачи 

string size = ReadData("Сколько строк вы хотите ввести?");
int intSize = int.Parse(size);
string[] arr = GenArray(intSize);
PrintData("Исходный массив: ", arr);
int symbols = 3;
int count = ElementCount(arr, symbols);
string[] arrNew = SearchOfElements(arr, count, symbols);
PrintData("Новый массив: ", arrNew);

//Метод считывает данные, введенные пользователем
string ReadData(string msg)
{
    Console.WriteLine(msg);
    return (Console.ReadLine() ?? "0");
}

// Метод генерирует массив из введенных пользователем строк
string[] GenArray(int num)
{
    string[] arr = new string[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = ReadData("Введите данные и нажмите Enter: ");
    }
    return arr;
}

// Метод печатает одномерный массив
void Print1DArr(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Метод подсчитывает количество элементов, удовлетворяющих условию в заданном массиве
int ElementCount(string[] arr, int s)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= s)
        {
            count++;
        }
    }
    return count;
}

// Метод создает новый массив из заданного, перебирая и проверяя элементы на условие
string[] SearchOfElements(string[] arr, int c, int s)
{
    string[] newArr = new string[c];

    for (int i = 0, j = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= s)
        {
            newArr[j] = arr[i];
            j++;
        }
    }
    return newArr;
}

// Метод выводит данные пользователю 
void PrintData(string res, string[] arr)
{
    Console.Write(res);
    Print1DArr(arr);
}



// int size = ReadData1("Сколько строк вы хотите ввести?");
// string[] arr = GenArray(size);
// int symbols = 3;
// Console.Write("Новый массив: ");
// PrintArray(arr, symbols);

// //Метод считывает данные, введенные пользователем (int) 
// int ReadData1(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// //Метод считывает данные, введенные пользователем (string) 
// string ReadData2(string msg)
// {
//     Console.WriteLine(msg);
//     return (Console.ReadLine() ?? "0");
// }

// // Метод генерирует одномерный массив из введенных пользователем строк 
// string[] GenArray(int num)
// {
//     string[] arr = new string[num];
//     for (int i = 0; i < num; i++)
//     {
//         arr[i] = ReadData2("Введите данные и нажмите Enter: ");
//     }
//     return arr;
// }

// // Метод печатает новый массив, проверяя элементы исходного массива на условие задачи
// void PrintArray(string[] arr, int s)
// {
//     bool p = false;
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if ((arr[i].Length <= s) && (p))
//         {
//             Console.Write(", " + arr[i]);
//         }
//         if ((arr[i].Length <= s) && (p == false))
//         {
//             p = true;
//             Console.Write(arr[i]);
//         }
//     }
//     Console.Write("]");
// }
