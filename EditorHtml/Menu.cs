namespace EditorHtml
{
  public static class Menu
  {
    public static void Show()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.Blue;
      Console.ForegroundColor = ConsoleColor.Black;

      Screen();
      Write();

      var option = short.Parse(Console.ReadLine());
    }

    public static void Screen()



    {
      Console.Write("+");
      for (int i = 0; i <= 30; i += 1)
        Console.Write("-");

      Console.Write("+");
      Console.Write("\n");

      for (int line = 0; line <= 10; line += 1)
      {
        Console.Write("|");
        for (int i = 0; i <= 30; i += 1)
          Console.Write(" ");

        Console.Write("|");
        Console.Write("\n");

      }

      Console.Write("+");
      for (int i = 0; i <= 30; i += 1)
        Console.Write("-");


      Console.Write("+");
      Console.Write("\n");

    }

    public static void Write()
    {
      Console.SetCursorPosition(3, 2);
      Console.WriteLine("Editor Html");
      Console.SetCursorPosition(3, 3);
      Console.WriteLine("-----------------------");
      Console.SetCursorPosition(3, 4);
      Console.WriteLine("Selecione das opções");
      Console.SetCursorPosition(3, 6);
      Console.WriteLine("1 - Novo Arquivo");
      Console.SetCursorPosition(3, 7);
      Console.WriteLine("2 - Abrir");
      Console.SetCursorPosition(3, 9);
      Console.WriteLine("0 - Sair");
      Console.SetCursorPosition(3, 11);
      Console.Write("Opção: ");

    }

  }
}