//Написать программу, которая из имеющего массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

Console.Clear();

int Prompt(string message) // ввод числа с клавиатуры
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

string[] CreateArray(int len) // создание нового массива
{
    string[] array = new string[len];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"Введите {i+1}-й элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}