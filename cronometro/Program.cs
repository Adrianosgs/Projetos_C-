static void Menu()
{
  Console.Clear();
  Console.WriteLine("S = Segundos | Ex: 10s");
  Console.WriteLine("M = Minutos | Ex: 10m");
  Console.WriteLine("0 = Sair");
  Console.WriteLine(" ");
  Console.Write("Quanto tempo deseja contar: ");

  string data = Console.ReadLine().ToLower();
  char type = char.Parse(data.Substring(data.Length - 1, 1));
  int time = int.Parse(data.Substring(0, data.Length - 1));
  int multMinuto = 1;

  if (type == 'm')
  {
    multMinuto = 60;

    if (time == 0)
    {
      System.Environment.Exit(0);
    }
  }

  Start(time * multMinuto);

}

static void Start(int time)
{
  int minutoAtual = 0;

  while (minutoAtual != time)
  {
    Console.Clear();
    minutoAtual++;
    Console.WriteLine(minutoAtual);
    Thread.Sleep(1000);
  }
  Console.Clear();
  Console.WriteLine("Cronometro Finalizado");
  Thread.Sleep(2500);
  Menu();
}

// Start(10);



Menu();
