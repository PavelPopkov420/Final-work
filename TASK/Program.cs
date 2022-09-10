/*Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами
*/
string[] array = { ":)", "(^-^)", "*_*", "hello", "world", "QQ" };
int NewLength = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    NewLength++;
}

string[] NewArray = new string [NewLength];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        NewArray[count] = array[i];
        count++;
    }
}

for (int i = 0; i < NewArray.Length; i++)
{
    Console.Write(NewArray[i] + " ");
}