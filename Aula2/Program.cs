//Tipo de variaveis
//int x = 10;
//double pi = 3.14;
//char letra = 'A';
//bool isTrue = true;
//string texto = "5";

//double outroValor;
//Converção implicita
//outroValor = x;
//Converção explicita 
//int valorInteiro = (int) pi;

//Conveção explicita com a classe Convert
//int y =Convert.ToInt32(texto);

//Operadores
//+, -, /, *, =, ==
//int numero;
//Console.WriteLine("Digite um numero: ");
//numero = Convert.ToInt32(Console.ReadLine());
//Concatenação de strings
//Console.WriteLine("O usuario digitou: " + numero);
//Interpolarização de strings
//Console.WriteLine($"O dobro do que o usuario digitou é: {numero * 2}");

//---Exercicio aula 02---

double num1;
double num2;


Console.WriteLine("Digite o primeiro numero: ");
num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o segundo numero: ");
num2 = Convert.ToDouble(Console.ReadLine());

double soma = num1 + num2;
double sub = num1 - num2;
double mult = num1 * num2;
double div = num1 / num2;


Console.WriteLine(num1 + "+" + num2 + "=" + soma);
Console.WriteLine($"{num1}-{num2}={sub}");
Console.WriteLine("{0}x{1}={2}", num1, num2, mult);
Console.WriteLine("{0}/{1}={2}", num1, num2, div);



