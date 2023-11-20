internal class Program
{
    private static void Main(object[] args)
    {
        {
        Console.WriteLine("Идет загрузка...");
        Console.WriteLine("Здравствуйте!");
        Console.WriteLine("Я бот Альфред. Давай познакомимся");
        }
        Console.Write("Введите свое имя: ");
        var name = Console.ReadLine();       // вводим имя
        Console.WriteLine($"Очень приятно {name}");

        Console.Write("Укажите номер телефона ? ");
        long telef = Console.ReadLine();       // вводим номер
        if (telef > 80000000000 && telef < 89999999999)
        { 
        Console.WriteLine($"Номер указан не верно!");
        }
        else
        {
        Console.WriteLine($"Мы отправили вам смс с кодом на номер {telef}");
        }

            Console.Write("Сколько вам лет? ");        // нужно установить ограничения
        int age = Convert.ToInt32(Console.ReadLine());
        if (age < 100 && age > 0)
        { 
        Console.WriteLine($"{age}");
        }
        else
        {
        Console.WriteLine($"пиздишь сука!");
        }
        
        Console.Write("Сколько твой рост? ");             // нужно установить ограничения
        double height = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Сколько твой вес? ");               // нужно установить ограничения
        double mass = Convert.ToDouble(Console.ReadLine());
        
        if (mass < 500 && mass > 5)
        {
        Console.WriteLine($"{mass}");
        }
        else
        {
        Console.WriteLine($"Не пытайся меня обмануть!!");
        }
        
        Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}cм Вес: {mass}кг  $");

        Console.Write("Какую музыку предпочитаете ?: ");
        var musica = Console.ReadLine();       // музыка
        Console.WriteLine($"Мне тоже нравится {musica}");

        Console.Write("Ваши интересы: ");
        string hobby = Console.ReadLine();         //  интересы
        Console.WriteLine($"Замечательное занятие {hobby}");
    }
}