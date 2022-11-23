//написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либа равна 3 символа.
//Первоначальный масив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Console.Clear();
void FillArray(string[] inputsArr){
    for(int i = 0; i<inputsArr.Length; i++){
        Console.Write($"Введите {i+1} элемент массива -> ");
        inputsArr[i]=Console.ReadLine() ?? "";
    }
}
//Метод формирования нового массива
string[] GetOnlyThreeSymbolsArray(string[] inputsArr)
{
    string[] new_array = new string[] {};
    int index=0;
    for (int i = 0; i < inputsArr.Length; i++)
    {
        if(inputsArr[i].Length<=3){
            Array.Resize(ref new_array, new_array.Length + 1);
            new_array[index]=inputsArr[i];
            index++;
        }
    }
    return new_array;
}


Console.Write("Введите размер массива: ");
int size;
try
{
    size=int.Parse(Console.ReadLine() ?? "");
}catch(Exception exc){
    Console.WriteLine($"Ошибка ввода данных!!!! {exc.Message}");
    return;
}
string[] array = new string[size];
FillArray(array);

Console.WriteLine();
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", GetOnlyThreeSymbolsArray(array))}]");
