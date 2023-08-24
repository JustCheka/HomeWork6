void PrintArr(int[] arr){
    foreach(var item in arr){
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Сколько будет чисел");
int m = int.Parse(Console.ReadLine());

int[] arr = new int[m];

int sum = 0;
for (int i = 0; i < arr.Length; i++){
    Console.Write($"{i + 1} число = ");
    arr[i] = int.Parse(Console.ReadLine());
    if (arr[i] > 0) sum++;
}
Console.WriteLine();
PrintArr(arr);
Console.WriteLine($"количество чисел больше 0 = {sum}");