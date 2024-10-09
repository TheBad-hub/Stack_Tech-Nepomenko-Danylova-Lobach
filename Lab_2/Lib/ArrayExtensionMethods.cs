namespace Lib;

public static class ArrayExtensionMethods
{
    // Метод-розширення для підрахунку кількості входжень елемента в масиві
    public static int CountOccurrences<T>(this T[] array, T value) where T : IEquatable<T>
    {
        // Якщо масив порожній, повертаємо 0
        if (array == null || array.Length == 0)
        {
            return 0;
        }

        return array.Count(item => item.Equals(value));
    }

    // Метод-розширення для отримання масиву унікальних елементів
    public static T[] GetUniqueElements<T>(this T[] array) where T : IEquatable<T>
    {
        if (array == null || array.Length == 0)
        {
            return Array.Empty<T>();
        }

        return array.Distinct().ToArray();
    }
}
