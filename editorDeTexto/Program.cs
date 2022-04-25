static void Menu()
{
  Console.Clear();
  Console.WriteLine("Qual a ação a ser feita: ");
  Console.WriteLine(" ");
  Console.WriteLine("1 - Abrir o Arquivo");
  Console.WriteLine(" ");
  Console.WriteLine("2 - Criar um novo arquivo");
  Console.WriteLine(" ");
  Console.WriteLine("3 - Sair");
  Console.WriteLine("------------------------------------");
  short option = short.Parse(Console.ReadLine());

  switch (option)
  {
    case 1: Abrir(); break;
    case 2: Editar(); break;
    case 3: System.Environment.Exit(0); break;
    default: Menu(); break;

  }
}


static void Abrir()
{

}

static void Editar()
{
  Console.Clear();
  Console.WriteLine("Digite seu texto Abaixo | Pressione ESC para sair");
  Console.WriteLine("------------------------------------");
  string text = "";

  do
  {
    text += Console.ReadLine();
    text += Environment.NewLine;
  }
  while (Console.ReadKey().Key != ConsoleKey.Escape);
  Console.Write(text);

}

Menu();