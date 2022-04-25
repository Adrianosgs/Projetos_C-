
static void Soma()
{
  Console.Clear();

  Console.Write("Digite o Primeiro valor: ");
  var som1 = int.Parse(Console.ReadLine());
  Console.Write("Digite o Segundo valor: ");
  var som2 = int.Parse(Console.ReadLine());

  Console.Write("");
  var soma = som1 + som2;

  Console.WriteLine($"O valor da soma é: {soma}");
  Console.ReadKey();
}

// Soma();


static void Subtracao()
{
  Console.Clear();

  Console.Write("Digite o Primeiro valor: ");
  var sub1 = int.Parse(Console.ReadLine());

  Console.Write("Digite o Segundo Valor: ");
  var sub2 = int.Parse(Console.ReadLine());

  Console.Write("");

  var subFinal = sub1 - sub2;
  Console.Write($"O resultado da subtracao é: {subFinal}");

  Console.ReadKey();
}

// Subtracao();

static void Divisao()
{
  Console.Clear();

  Console.Write("Digite o Primeiro Valor: ");
  var div1 = int.Parse(Console.ReadLine());
  Console.Write("Digite o Segundo Valor: ");
  var div2 = int.Parse(Console.ReadLine());
  Console.Write("");

  var divFinal = div1 / div2;



}


