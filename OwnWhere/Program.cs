var list = new List<int> { 1, 2, 3, 4 };

var oddQuery = list.MyWhere(i => i % 2 != 0); // MyWhere - ваш метод

list.Add(5);
var filterredList = oddQuery.ToList(); // 1, 3, 5

foreach (int item in filterredList)
{
    Console.WriteLine(item);
}

public static class LinqExtensionMethod
{
    public static IEnumerable<TSource> MyWhere<TSource>(this IEnumerable<TSource> list, Func<TSource, bool> filterEvenNumbers)
    {
        foreach (TSource item in list)
        {
            if (filterEvenNumbers(item))
            {
                yield return item;
            }
        }
    }
}

