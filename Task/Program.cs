    Console.WriteLine("Введите элементы массива через запятую:"); 
        string[] originalArray = Console.ReadLine().Split(',');
 
        int count = 0;
        for (int i = 0; i < originalArray.Length; i++) // Определяем размер нового массива
        {
            if (originalArray[i].Length <= 3)
            {
                count++;
            }
        }
 
        string[] newArray = new string[count]; // Создаем новый массив

        
        int index = 0; // Заполняем новый массив
        for (int i = 0; i < originalArray.Length; i++)
        {
            if (originalArray[i].Length <= 3)
            {
                newArray[index] = originalArray[i];
                index++;
            }
        }

        Console.WriteLine("Новый массив:");
        for (int i = 0; i < newArray.Length; i++)
        {
            Console.Write(newArray[i] + "; ");
        }


