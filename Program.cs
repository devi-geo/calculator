Console.WriteLine("Введите первое число:");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
double num2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите операцию \n(+, -, *, /, cos, sin, tan, sqrt, log,\n pow, abs, atan, asin, acos, sinh, cosh, tanh, exp, log10, \n PI, E) \n:");
string operation = Console.ReadLine();

if (string.IsNullOrEmpty(operation))
{
    Console.WriteLine("Операция не может быть пустой");
    return;
}

else if (operation == "+")
{
    Console.WriteLine(num1 + num2);
}
else if (operation == "-")
{
    Console.WriteLine(num1 - num2);
}
else if (operation == "*")
{
    Console.WriteLine(num1 * num2);
}
else if (operation == "/" && num2 != 0)
{
    Console.WriteLine(num1 / num2);
}

else if (operation == "cos")
{
    Console.WriteLine("Введите угол");
    double angle = double.Parse(Console.ReadLine());

    Console.WriteLine("Градусы или радианы: (g / r): ");
    string format = Console.ReadLine();

    if (format == "g")
    {
        angle = angle * Math.PI / 180;
        Console.WriteLine(Math.Cos(angle));
    }
    else
    {
        Console.WriteLine(Math.Cos(angle));
    }
}

else if (operation == "sin")
{
    Console.WriteLine("Введите угол");
    double angle = double.Parse(Console.ReadLine());

    Console.WriteLine("Градусы или радианы: (g / r): ");
    string format = Console.ReadLine();

    if (format == "g")
    {
        angle = angle * Math.PI / 180;
        Console.WriteLine(Math.Sin(angle));
    }
    else
    {
        Console.WriteLine(Math.Sin(angle));
    }
}
else if (operation == "tan")
{
    Console.WriteLine("Введите угол");
    double angle = double.Parse(Console.ReadLine());

    Console.WriteLine("Градусы или радианы: (g / r): ");
    string format = Console.ReadLine();

    if (format == "g")
    {
        angle = angle * Math.PI / 180;
        Console.WriteLine(Math.Tan(angle));
    }
    else
    {
        Console.WriteLine(Math.Tan(angle));
    }
}

else if (operation == "sqrt")
{
    Console.WriteLine(Math.Sqrt(num1));
    Console.WriteLine(Math.Sqrt(num2));
}

else if (operation == "log")
{
    Console.WriteLine(Math.Log(num1));
    Console.WriteLine(Math.Log(num2));
}

else if (operation == "pow")
{
    Console.WriteLine(Math.Pow(num1, num2));
}

else if (operation == "abs")
{
    Console.WriteLine(Math.Abs(num1));
    Console.WriteLine(Math.Abs(num2));
}

else if (operation == "atan")
{
    Console.WriteLine(Math.Atan(num1));
    Console.WriteLine(Math.Atan(num2));
}

else if (operation == "asin")
{
    Console.WriteLine(Math.Asin(num1));
    Console.WriteLine(Math.Asin(num2));
}

else if (operation == "acos")
{
    Console.WriteLine(Math.Acos(num1));
    Console.WriteLine(Math.Acos(num2));
}

else if (operation == "cosh")
{
    Console.WriteLine("Введите угол");
    double angle = double.Parse(Console.ReadLine());

    Console.WriteLine("Градусы или радианы: (g / r): ");
    string format = Console.ReadLine();

    if (format == "g")
    {
        angle = angle * Math.PI / 180;
        Console.WriteLine(Math.Cosh(angle));
    }
    else
    {
        Console.WriteLine(Math.Cosh(angle));
    }
}

else if (operation == "sinh")
{
    Console.WriteLine("Введите угол");
    double angle = double.Parse(Console.ReadLine());

    Console.WriteLine("Градусы или радианы: (g / r): ");
    string format = Console.ReadLine();

    if (format == "g")
    {
        angle = angle * Math.PI / 180;
        Console.WriteLine(Math.Sinh(angle));
    }
    else
    {
        Console.WriteLine(Math.Sinh(angle));
    }
}

else if (operation == "tanh")
{
    Console.WriteLine("Введите угол");
    double angle = double.Parse(Console.ReadLine());

    Console.WriteLine("Градусы или радианы: (g / r): ");
    string format = Console.ReadLine();

    if (format == "g")
    {
        angle = angle * Math.PI / 180;
        Console.WriteLine(Math.Tanh(angle));
    }
    else
    {
        Console.WriteLine(Math.Tanh(angle));
    }
}

else if (operation == "exp")
{
    Console.WriteLine(Math.Exp(num1));
    Console.WriteLine(Math.Exp(num2));
}

else if (operation == "log10")
{
    Console.WriteLine(Math.Log10(num1));
    Console.WriteLine(Math.Log10(num1));
}

else if (operation == "pi")
{
    Console.WriteLine(Math.PI);
}

else if (operation == "e")
{
    Console.WriteLine(Math.E);
}

else
{
    Console.WriteLine("Неизвестный символ\n ('_')");
}
