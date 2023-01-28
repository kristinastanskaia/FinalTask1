int size = ReadData1("Сколько строк вы хотите ввести?");
string[] arr = GenArray(size);
int symbols = 3;
Console.Write("Новый массив: ");
PrintArray(arr, symbols);

//Метод считывает данные, введенные пользователем (int) 
int ReadData1(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод считывает данные, введенные пользователем (string) 
string ReadData2(string msg)
{
    Console.WriteLine(msg);
    return (Console.ReadLine() ?? "0");
}

// Метод генерирует одномерный массив из введенных пользователем строк 
string[] GenArray(int num)
{
    string[] arr = new string[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = ReadData2("Введите данные и нажмите Enter: ");
    }
    return arr;
}

// Метод печатает новый массив, проверяя элементы исходного массива на условие задачи
void PrintArray(string[] arr, int s)
{
    bool p = false;
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i].Length <= s) && (p))
        {
            Console.Write(", " + arr[i]);
        }
        if ((arr[i].Length <= s) && (p == false))
        {
            p = true;
            Console.Write(arr[i]);
        }
    }
    Console.Write("]");
}
