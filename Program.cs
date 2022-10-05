// Задача 41

/*int[] array = GetArray(5, -100, 100);
Console.WriteLine(string.Join(" ", array));

int count = 0;
for (int i = 0; i < array.Length; i++){

if (array[i] > 0) {
count += 1;
}
}
Console.WriteLine($"Колличество чисел больше нуля = {count}");


int[] GetArray(int size, int minValue, int maxVolue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxVolue);
    }
    return res;
}*/

// Задача 43

Console.WriteLine("Введи число k1 ");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введи число b1 ");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введи число k2 ");
int k2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введи число b2 ");
int b2 = int.Parse(Console.ReadLine());

double x1 = 0;
double y1 = 0;

    int x = (b2 - b1)/(k1 - k2);

    x1 = x;
    int y = k2*x + b2; 
    y1 = y;
 

Console.WriteLine($"координаты точки пересечения равны {x1},{y1})");