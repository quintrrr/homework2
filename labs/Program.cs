namespace ConsoleApp2;

/// <summary>
///     Виды банковского счета
/// </summary>
internal enum BankAccountType
{
    /// <summary>
    ///     Текущий счет
    /// </summary>
    Current,

    /// <summary>
    ///     Сберегательный счет
    /// </summary>
    Savings
}

/// <summary>
///     Информауия о банковском счете.
/// </summary>
internal struct BankAccount
{
    /// <summary>
    ///     Номер счета.
    /// </summary>
    public long Number;

    /// <summary>
    ///     Тип счета.
    /// </summary>
    public BankAccountType Type;

    /// <summary>
    ///     Баланс счета.
    /// </summary>
    public double Balance;
    
    /// <summary>
    ///     Вводит информацию о банковском счете.
    /// </summary>
    public void Print()
    {
        Console.WriteLine("Информация о банковском счете:");
        Console.WriteLine("Номер счета: " + Number);
        Console.WriteLine("Тип счета: " + Type);
        Console.WriteLine("Баланс: " + Balance);
    }
}

/// <summary>
///     Перечисление для представления списка вузов.
/// </summary>
internal enum ВУЗ
{
    КГУ,
    КАИ,
    КХТИ
}

/// <summary>
///     Информация о работнике.
/// </summary>
internal struct Worker
{
    /// <summary>
    ///     Имя работника.
    /// </summary>
    public string Name;

    /// <summary>
    ///     ВУЗ, с которым связан работник.
    /// </summary>
    public ВУЗ University_Name;
    /// <summary>
    ///     Вводит информацию о работнике.
    /// </summary>
    public void Print()
    {
        Console.WriteLine("Информация о работнике:");
        Console.WriteLine("Имя: " + Name);
        Console.WriteLine("ВУЗ: " + University_Name);
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        // Упражнение 3.1 Создать структуру данных, которая хранит информацию о банковском
        // счете – его номер, тип и баланс. Создать переменную такого типа, заполнить структуру
        // значениями и напечатать результат.
        Console.WriteLine("Упражнение 3.1");
        BankAccountType accountType = BankAccountType.Savings;
        Console.WriteLine("Тип банковского счета: " + accountType);
        Console.WriteLine();

        // Упражнение 3.2 Создать структуру данных, которая хранит информацию о банковском
        // счете – его номер, тип и баланс. Создать переменную такого типа, заполнить структуру
        // значениями и напечатать результат.
        Console.WriteLine("Упражнение 3.2");
        BankAccount myBankAccount = new BankAccount();
        myBankAccount.Balance = 88664422;
        myBankAccount.Type = BankAccountType.Current;
        myBankAccount.Number = 11043402;
        myBankAccount.Print();
        Console.WriteLine();

        // Упражнение 3.3 Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать
        // структуру работник с двумя полями: имя, ВУЗ. Заполнить структуру данными и
        // распечатать.
        Console.WriteLine("Упражнение 3.3");
        Worker firstWorker = new Worker();
        firstWorker.Name = "Gomzik";
        firstWorker.University_Name = ВУЗ.КАИ;
        firstWorker.Print();
        Console.WriteLine();

    }
}