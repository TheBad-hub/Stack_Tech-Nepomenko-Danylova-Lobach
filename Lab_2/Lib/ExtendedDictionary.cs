using System.Collections;

namespace Lib;
public class ExtendedDictionaryElement<T, U, V>
{
    public T Key { get; }
    public U Value1 { get; }
    public V Value2 { get; }

    public ExtendedDictionaryElement(T key, U value1, V value2)
    {
        Key = key;
        Value1 = value1;
        Value2 = value2;
    }
}
public class ExtendedDictionary<T, U, V> : IEnumerable<ExtendedDictionaryElement<T, U, V>>
{
    private List<ExtendedDictionaryElement<T, U, V>> _elements = new List<ExtendedDictionaryElement<T, U, V>>();

    // Додавання елемента в словник
    public void Add(T key, U value1, V value2)
    {
        if (ContainsKey(key))
        {
            // Якщо ключ вже є, оновлюємо значення
            var element = _elements.First(e => e.Key.Equals(key));
            element = new ExtendedDictionaryElement<T, U, V>(key, value1, value2);
        }
        else
        {
            _elements.Add(new ExtendedDictionaryElement<T, U, V>(key, value1, value2));
        }
    }

    // Видалення елемента за ключем
    public void Remove(T key)
    {
        var element = _elements.FirstOrDefault(e => e.Key.Equals(key));
        if (element != null)
        {
            _elements.Remove(element);
        }
    }

    // Перевірка, чи міститься ключ у словнику
    public bool ContainsKey(T key)
    {
        foreach (var element in _elements)
        {
            if (element.Key.Equals(key))
            {
                return true;
            }
        }
        return false;
    }

    // Перевірка, чи міститься значення (value1, value2) у словнику
    public bool ContainsValue(U value1, V value2)
    {
        foreach (var element in _elements)
        {
            if (element.Value1.Equals(value1) && element.Value2.Equals(value2))
            {
                return true;
            }
        }
        return false;
    }

    // Індексатор для доступу до значень за ключем
    public (U, V) this[T key]
    {
        get
        {
            var element = _elements.FirstOrDefault(e => e.Key.Equals(key));
            if (element != null)
            {
                return (element.Value1, element.Value2);
            }
            throw new KeyNotFoundException($"Key '{key}' not found.");
        }
    }

    public int Count => _elements.Count;

    public IEnumerator<ExtendedDictionaryElement<T, U, V>> GetEnumerator()
    {
        return _elements.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
