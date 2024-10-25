public class MyList<T>
{
    private T[] array;
    private int count;

    // Задание начального размера
    public MyList(int initialSize)
    {
        array = new T[initialSize];
        count = 0;
    }

    // Задание начальных элементов
    public MyList(T[] initialElements)
    {
        array = new T[initialElements.Length];
        for (int i = 0; i < initialElements.Length; i++)
        {
            array[i] = initialElements[i];
        }
        count = initialElements.Length;
    }

    // Добавление элемента
    public void Add(T item)
    {
        if (count == array.Length)
        {
            ResizeArray();
        }
        array[count] = item;
        count++;
    }

    // Удаление первого вхождения элемента
    public void Delete(T item)
    {
        int index = IndexOf(item);  // индекс элемента
        if (index != -1)
        {
            DeleteAt(index);
        }
    }

    // Вставка элемента по индексу
    public void Insert(int index, T item)
    {
        if (index < 0 || index > count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Индекс вне диапазона.");
        }

        if (count == array.Length)
        {
            ResizeArray(); 
        }

        // Сдвигаем элементы вправо
        for (int i = count; i > index; i--)
        {
            array[i] = array[i - 1];
        }
        array[index] = item;
        count++;
    }

    // Очистка списка
    public void Clear()
    {
        array = new T[array.Length];
        count = 0;
    }

    // Удаление элемента по индексу
    public void DeleteAt(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Индекс вне диапазона.");
        }

        // Сдвигаем элементы влево
        for (int i = index; i < count - 1; i++)
        {
            array[i] = array[i + 1];
        }
        count--;
        array[count] = default;  // Освобождаем последний элемент
    }

    // Удаление всех вхождений элемента
    public void DeleteAll(T item)
    {
        int index;
        while ((index = IndexOf(item)) != -1)
        {
            DeleteAt(index);
        }
    }

    // Изменение размера массива
    private void ResizeArray()
    {
        int newSize = array.Length * 2;
        T[] newArray = new T[newSize];
        CopyArray(array, newArray);
        array = newArray;
    }

    // Копирование элементов
    private void CopyArray(T[] source, T[] destination)
    {
        for (int i = 0; i < source.Length; i++)
        {
            destination[i] = source[i];
        }
    }

    // Нахождение индекса элемента
    public int IndexOf(T item)
    {
        for (int i = 0; i < count; i++)
        {
            if (EqualityComparer<T>.Default.Equals(array[i], item))
            {
                return i;
            }
        }
        return -1;  // Возвращаем -1, если элемент не найден
    }

    // Каждый элемент
    public void ForEach(Action<T> action)
    {
        for (int i = 0; i < count; i++)
        {
            action(array[i]);  // Выполняем действие для каждого элемента
        }
    }

    // Поиск элемента по условию
    public T Find(Func<T, bool> predicate)
    {
        for (int i = 0; i < count; i++)
        {
            if (predicate(array[i]))
            {
                return array[i];
            }
        }
        return default;  // Возвращаем значение по умолчанию, если элемент не найден
    }

    // Сортировка массива
    public void Sort(Comparison<T> comparison)
    {
        Array.Sort(array, 0, count, Comparer<T>.Create(comparison));
    }


    // Получение строки, представляющей список
    public override string ToString()
    {
        string result = "[";
        for (int i = 0; i < count; i++)
        {
            result += array[i];
            if (i < count - 1) result += ", ";
        }
        result += "]";
        return result;
    }
}