static void Menu()
{
  Console.Clear();

  Console.WriteLine("Qual a sua opção matematica? ");
  Console.WriteLine("1 - Soma");
  Console.WriteLine("2 - Subtração");
  Console.WriteLine("3 - Divisão");
  Console.WriteLine("4 - Multiplicação");
  Console.WriteLine("5 - Sair");


  Console.WriteLine("--------------------------------------------------");
  Console.WriteLine("Selecione uma das Opçãoes");
  var res = int.Parse(Console.ReadLine());


  switch (res)
  {
    case 1: Soma(); break;
    case 2: Subtracao(); break;
    case 3: Divisao(); break;
    case 4: multiplicacao(); break;
    case 5: System.Environment.Exit(0); break;
    default: Menu(); break;
  }
}

Menu();


static void Soma()
{
  Console.Clear();

  Console.Write("Digite o Primeiro valor: ");
  var som1 = int.Parse(Console.ReadLine());
  Console.Write("Digite o Segundo valor: ");
  var som2 = int.Parse(Console.ReadLine());
  Console.WriteLine("");
  var soma = som1 + som2;

  Console.WriteLine($"O valor da soma é: {soma}");
  Console.WriteLine("");

  Console.WriteLine($"Precione enter para voltar ao menu");

  Console.ReadKey();

  Menu();
}

// Soma();

static void Subtracao()
{
  Console.Clear();

  Console.Write("Digite o Primeiro valor: ");
  var sub1 = int.Parse(Console.ReadLine());

  Console.Write("Digite o Segundo Valor: ");
  var sub2 = int.Parse(Console.ReadLine());
  Console.Write(" ");

  var subFinal = sub1 - sub2;

  Console.Write($"O resultado da subtracao é: {subFinal}");
  Console.WriteLine(" ");

  Console.WriteLine($"Precione enter para voltar ao menu");

  Console.ReadKey();

  Menu();
}

// Subtracao();
static void Divisao()
{
  Console.Clear();

  Console.Write("Digite o Primeiro Valor: ");
  var div1 = int.Parse(Console.ReadLine());
  Console.Write("Por quanto quer Dividir: ");
  var div2 = int.Parse(Console.ReadLine());
  Console.Write(" ");

  var divFinal = div1 / div2;

  Console.Write($"O resultado da Divisão é: {divFinal}");

  Console.WriteLine(" ");
  Console.WriteLine($"Precione enter para voltar ao menu");

  Console.ReadKey();

  Menu();

}

// Divisao();

static void multiplicacao()
{

  Console.Clear();

  Console.Write("Digite o primeiro valor: ");
  var mult1 = int.Parse(Console.ReadLine());

  Console.Write("Por quanto ira multiplicar? ");
  var mult2 = int.Parse(Console.ReadLine());
  Console.Write(" ");

  var multFinal = mult1 * mult2;
  Console.Write($"O resultado da multiplicação é: {multFinal}");
  Console.WriteLine(" ");

  Console.WriteLine($"Precione enter para voltar ao menu");

  Console.ReadKey();

  Menu();

}

// multiplicacao();



