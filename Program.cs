//завдання 3, приклад 1
class TempRecord
{
    // Масив значень температур
    private readonly float[] temps = new float[10] { 56.2F, 56.7F, 56.5F, 56.9F, 58.8F, 61.3F, 65.9F, 62.1F, 59.2F, 57.5F };

    // Індексатор для доступу до масиву
    public float this[int index]
    {
        get => temps[index];
        set => temps[index] = value;
    }
}

class Program
{
    static void Main()
    {
        TempRecord tempRecord = new TempRecord();

        // Зміна значення за індексом
        tempRecord[3] = 58.3F;
        tempRecord[5] = 60.1F;

        // Виведення значень
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Element #{i} = {tempRecord[i]}");
        }

        Console.ReadKey();
    }
}
//приклад 2
class DayCollection
{
    readonly string[] days = { "Понеділок", "Вівторок", "Середа", "Четвер", "П'ятниця", "Субота", "Неділя" };

    private int GetDay(string testDay)
    {
        for (int j = 0; j < days.Length; j++)
        {
            if (days[j] == testDay)
            {
                return j;
            }
        }

        throw new ArgumentOutOfRangeException(testDay, "Неправильно вказаний день тижня");
    }

    // Індексатор, що приймає рядок
    public int this[string day] => GetDay(day);
}

class Program
{
    static void Main(string[] args)
    {
        DayCollection week = new DayCollection();
        Console.WriteLine(week["Середа"]); // Виводить номер дня тижня

        try
        {
            Console.WriteLine(week["перший день"]); // Викликає виключення
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadKey();
    }
}
//прикдал 3
class PwrOfTwo
{
    public int this[int index]
    {
        get
        {
            return index switch
            {
                >= 0 and < 16 => Pwr(index),
                _ => -1
            };
        }
    }

    private static int Pwr(int p)
    {
        int result = 1;
        for (int i = 0; i < p; i++)
        {
            result *= 2;
        }
        return result;
    }
}

class Program
{
    static void Main()
    {
        PwrOfTwo pwr = new PwrOfTwo();
        Console.Write("Перші 8 ступенів числа 2: ");
        for (int i = 0; i < 8; i++)
        {
            Console.Write(pwr[i] + " ");
        }

        Console.WriteLine();
        Console.Write("Помилки: ");
        Console.WriteLine(pwr[-1] + " " + pwr[17]);
        Console.ReadKey();
    }
}
//завдання 4
class Student
{
    private readonly int[] grades = new int[10];

    // Індексатор для доступу до масиву оцінок
    public int this[int index]
    {
        get => grades[index];
        set => grades[index] = value;
    }

    // Метод для розрахунку середнього рейтингу
    public double GetAverageGrade()
    {
        int sum = 0;
        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
        }
        return (double)sum / grades.Length;
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        // Ініціалізуємо оцінки
        student[0] = 90;
        student[1] = 85;
        student[2] = 88;
        student[3] = 75;
        student[4] = 95;
        student[5] = 80;
        student[6] = 70;
        student[7] = 100;
        student[8] = 65;
        student[9] = 85;

        // Виведення середнього рейтингу
        Console.WriteLine($"Середній рейтинг студента: {student.GetAverageGrade():F2}");

        Console.ReadKey();
    }
}
