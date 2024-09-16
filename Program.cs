Random random = new Random();
int n = 1000;

// Генерация массива случайных неотрицательных целых чисел не превышающих 10000 без явного цикла
int[] nums = Enumerable.Range(0, n).Select(int_ => random.Next(0, 10001)).ToArray();
// Константы для последующего поиска числа
long maxR = 0; 
long maxR_14 = 0;
long maxR_7 = 0;
long maxR_2 = 0;
// Цикл поиска числа R
for (int i = 0; i < n; i++)
{
    if (nums[i] > maxR)
    {
        maxR = nums[i];
    }
    if (nums[i] > maxR_14 && nums[i] % 14 == 0)
    {
        maxR_14 = nums[i];
    }
    if (nums[i] > maxR_7 && nums[i] % 7 == 0)
    {
        maxR_7 = nums[i];
    }
    if (nums[i] > maxR_2 && nums[i] % 2 == 0)
    {
        maxR_2 = nums[i];
    }
}
//Вывод нужного числа на консоль, если такого числа нет, выведет "-1"
if (maxR * maxR_14 >= maxR_2 * maxR_7)
{
    Console.WriteLine("Наше число: " + maxR * maxR_14);
}
else if (maxR * maxR_14 <= maxR_2 * maxR_7)
{
    Console.WriteLine("Наше число: " + maxR_2 * maxR_7);
}
else
{
    Console.WriteLine(-1);
}

