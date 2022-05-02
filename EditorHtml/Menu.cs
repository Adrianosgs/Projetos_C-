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
  }
}