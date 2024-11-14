namespace ConsoleApp3;

class Program
{
    /// <summary>
    /// Пользователь.
    /// </summary>
    struct User
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name;
        /// <summary>
        /// Возраст
        /// </summary>
        public int Age;
        /// <summary>
        /// Адрес
        /// </summary>
        public string Address;
        /// <summary>
        /// Пинкод
        /// </summary>
        public int Pin;
        
        /// <summary>
        /// Вводит информацию о пользователе
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"Имя: {Name}\nВозраст: {Age}\nАдрес: {Address}\nПин: {Pin}");
        }
    }

    enum AlcType
    {
        a,
        b,
        c,
        d
    }

    struct Drink
    {
        public string TypeDrink;
        public double ProcentDrink;
    }
        
    struct Student
    {
        public string Surname;
        public string Name;
        public DateOnly DateOfBirth;
        public int ID;
        public AlcType AlcType;
        public (double, Drink) Volume;
        public Student(string surname, string name, DateOnly dateOfBirth, int id, AlcType alcType,
            (double, Drink) volume)
        {
            Surname = surname;
            Name = name;
            DateOfBirth = dateOfBirth;
            ID = id;
            AlcType = alcType;
            Volume = volume;
        }
    }
    static void Main(string[] args)
    {
        // Упражнение 1. Выведите на экран информацию о каждом типе данных в виде:
        // Тип данных – максимальное значение – минимальное значение
        Console.WriteLine("Упражнение 1");
        Console.WriteLine($"byte - {byte.MaxValue} - {byte.MinValue}");
        Console.WriteLine($"sbyte - {sbyte.MaxValue} - {sbyte.MinValue}");
        Console.WriteLine($"short - {short.MaxValue} - {short.MinValue}");
        Console.WriteLine($"ushort - {ushort.MaxValue} - {ushort.MinValue}");
        Console.WriteLine($"int - {int.MaxValue} - {int.MinValue}");
        Console.WriteLine($"uint - {uint.MaxValue} - {uint.MinValue}");
        Console.WriteLine($"long - {long.MaxValue} - {long.MinValue}");
        Console.WriteLine($"ulong - {ulong.MaxValue} - {ulong.MinValue}");
        Console.WriteLine($"float - {float.MaxValue} - {float.MinValue}");
        Console.WriteLine($"double - {double.MaxValue} - {double.MinValue}");
        Console.WriteLine($"decimal - {decimal.MaxValue} - {decimal.MinValue}");
        Console.WriteLine();
        
        // Упражнение 2. Напишите программу, в которой принимаются данные пользователя в виде имени,
        // города, возраста и PIN-кода. Далее сохраните все значение в соответствующей
        // переменной, а затем распечатайте всю информацию в правильном формате.
        Console.WriteLine("Упражнение 2");
        User user = new User();
        user.Name = "Гомзик";
        user.Age = 18;
        user.Address = "Калининград";
        user.Pin = 8642;
        user.Print();
        Console.WriteLine();
        
        // Упражнение 3. Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на
        // строчные.
        Console.WriteLine("Упражнение 3");
        string input = Console.ReadLine();
        string result = "";
        foreach (char c in input)
        {
            if (char.IsUpper(c))
            {
                result += char.ToLower(c);
            }
            else if (char.IsLower(c))
            {
                result += char.ToUpper(c);
            }
            else
            {
                result += c;
            }
        }
        Console.WriteLine(result);
        Console.WriteLine();
        
        // Упражнение 4. Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести
        // на экран.
        
        Console.WriteLine("Упражнение 4");
        Console.Write("Введите строку: ");
        string stroka = Console.ReadLine();

        Console.Write("Введите подстроку: ");
        string podstroka = Console.ReadLine();
        
        int count = 0;
        int index = 0;

        while ((index = stroka.IndexOf(podstroka, index)) != -1)
        {
            count++;
            index += podstroka.Length; 
        }
        
        Console.WriteLine("Количество вхождений подстроки: " + count);
        Console.WriteLine();
        
        // Упражнение 5. Цель этой задачи - определить, сколько бутылок виски беспошлинной торговли вам
        // нужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически
        // покрыла расходы на ваш отпуск. Вам будет предоставлена стандартная цена (normPrice),
        // скидка в Duty Free (salePrice) и стоимость отпуска (holidayPrice). Например, если бутылка
        // обычно стоит 10 фунтов стерлингов, а скидка в дьюти фри составляет 10%, вы
        // сэкономите 1 фунт стерлингов на каждой бутылке. Если ваш отпуск стоит 500 фунтов
        // стерлингов, ответ, который вы должны вернуть, будет 500. Все входные данные будут
        // целыми числами. Пожалуйста, верните целое число. Округлить в меньшую сторону.
        
        Console.WriteLine("Упражнение 5");
        double normPrice = 1000;
        double salePrice = 10;
        double holidayPrice = 10000;
        Console.WriteLine(Math.Floor(holidayPrice / (normPrice * (salePrice / 100))));
        Console.WriteLine();
        
        
    }
}