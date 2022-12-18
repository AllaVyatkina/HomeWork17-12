  Console.WriteLine("Введите первое число: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());

    if (firstNumber > secondNumber) {
      Console.WriteLine($"max = {firstNumber}, min = {secondNumber}");
    } else {
      Console.WriteLine($"max = {secondNumber}, min = {firstNumber}");
    }