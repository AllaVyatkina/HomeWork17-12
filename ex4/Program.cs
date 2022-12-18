Console.WriteLine ("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int index = 1;
    
    while (index <= n) 
    {
      if (index % 2 == 0) {
        Console.WriteLine(index);
      }
      index += 1;
    }