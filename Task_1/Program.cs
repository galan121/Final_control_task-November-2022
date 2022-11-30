//Написать программу которая из имеющегося массива строк ,
// формирует массив из строк , длина которых меньше, или равна 3 символам . 
//Первоначальный массив можно ввести с клавиатуры.  Либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,  
//лучше обойтись исключительно массивами

string[] arrayOne = {"1" ,"hello", "12", "world", ":)", "789","56", "9"};
string[] arrayTwo = new string[arrayOne.Length];
void FillArray(string[] arrayOne, string[] arrayTwo)
{
    int count = 0;
    for (int i = 0; i < arrayOne.Length; i++)
    {
    if(arrayOne[i].Length <= 3)
        {
        arrayTwo[count] = arrayOne[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
FillArray(arrayOne, arrayTwo);
PrintArray(arrayTwo);
