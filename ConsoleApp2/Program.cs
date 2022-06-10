int[] numer = { 9, 3, 4, 5, 6, 7, -8, -6, -7, -3, -5, 0, 3, 0, 0 };
Console.WriteLine("отрицательные: " + numer.Count(a => a > 0));
Console.WriteLine("Произведение:" + numer.Where(i => i > 0).Aggregate((x, y) => x * y));
Console.WriteLine("нулевые:" + numer.Count(a => a == 0));