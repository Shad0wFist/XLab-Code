public class MyList
{
    private int[] array;
    private int size;

    // Задание начального размера
    public MyList(int initialSize) 
    {
        array = new int[initialSize];
        size = 0;
    }

    // Задание начальных элементов
    public MyList(int[] initialElements)
    {
        array = new int[initialElements.Length];
        for (int i = 0; i < initialElements.Length; i++)
        {
            array[i] = initialElements[i];
        }
        size = initialElements.Length;
    }

    // Добавление элемента в конец списка
    public void Add(int item)
    {
        if (size == array.Length)
        {
            int[] newArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

        array[size] = item;
        size++;
    }

    // Удаление первого вхождения элемента
    public void Delete(int item)
    {
        int index = -1;

        for (int i = 0; i < size; i++)
        {
            if (array[i] == item)
            {
                index = i;
                break;
            }
        }

        if (index != -1)
        {
            for (int i = index; i < size - 1; i++)
            {
                array[i] = array[i + 1];
            }

            size--;

            int[] newArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }
    }

    // Вставка элемента по индексу
    public void Insert(int index, int item)
    {
        if (index < 0 || index > size)
        {
            throw new ArgumentOutOfRangeException("Индекс вне диапазона");
        }

        if (size == array.Length)
        {
            int[] newArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

        for (int i = size; i > index; i--)
        {
            array[i] = array[i - 1];
        }

        array[index] = item;
        size++;
    }

    // Очистка списка
    public void Clear()
    {
        array = new int[1];
        size = 0;
    }

    // Получение строки, представляющей список
    public override string ToString()
    {
        string result = "[";

        for (int i = 0; i < size; i++)
        {
            result += array[i];
            if (i < size - 1)
                result += ", ";
        }

        result += "]";
        return result;
    }

    // Удаление элемента по индексу
    public void DeleteAt(int index)
    {
        if (index < 0 || index >= size)
        {
            throw new ArgumentOutOfRangeException("Индекс вне диапазона");
        }

        for (int i = index; i < size - 1; i++)
        {
            array[i] = array[i + 1];
        }

        size--;

        int[] newArray = new int[size];
        for (int i = 0; i < size; i++)
        {
            newArray[i] = array[i];
        }
        array = newArray;
    }

    // Удаление всех вхождений элемента
    public void DeleteAll(int item)
    {
        int newSize = 0;

        for (int i = 0; i < size; i++)
        {
            if (array[i] != item)
            {
                array[newSize] = array[i];
                newSize++;
            }
        }

        size = newSize;

        int[] newArray = new int[size];
        for (int i = 0; i < size; i++)
        {
            newArray[i] = array[i];
        }
        array = newArray;
    }
}
