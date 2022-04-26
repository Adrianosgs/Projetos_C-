﻿static void Menu()
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
  Salvar(text);

}

static void Salvar(string text)
{
  Console.Clear();
  Console.WriteLine("Qual o caminho para salvar? ");
  var path = Console.ReadLine();

  using (var file = new StreamWriter(path))
  {
    file.Write(text);
  }
  Console.WriteLine($"Arquivo {path} salvo com sucesso");
  Console.ReadLine();
  Menu();
}

Menu();