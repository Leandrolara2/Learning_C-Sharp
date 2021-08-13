using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            bool c1 = a > 10;
            bool c2 = a < 20;
            bool c3 = a == 10;



            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine("________________________________________");


            bool c5 = a <= 10;

            Console.WriteLine(c5);










            //Console.WriteLine("Digite um numero: ");
           // double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           // Console.WriteLine("Digite outro numero: ");
            //double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

          //  double soma = a + b;

            //Console.WriteLine($"A soma dos números são: {soma.ToString("F4", CultureInfo.InvariantCulture)}");










            //  Console.WriteLine("Entre cm seu nome completo: ");
            //  string a = Console.ReadLine();
            //   Console.WriteLine("Quantos quartos tem na sua casa? ");
            //   int b = int.Parse(Console.ReadLine());
            //  Console.WriteLine("Entre com o preço de um produto: ");
            //  double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //  Console.WriteLine();
            //   Console.WriteLine("Entre seu último nome, idade e altua: ");
            //   string[] v = Console.ReadLine().Split(' ');
            //   Console.WriteLine();
            //    string nome = v[0];
            //    int idade = int.Parse(v[1]);
            //   double peso = double.Parse(v[2], CultureInfo.InvariantCulture);

            // Console.WriteLine();
            //  Console.WriteLine(a);
            //  Console.WriteLine(b);
            //Console.WriteLine(c.ToString("f2", CultureInfo.InvariantCulture));
            //Console.WriteLine($"Seu nome: {nome}, sua idade é: {idade}, seu peso é: {peso.ToString("F2", CultureInfo.InvariantCulture)}");





            // int n1 = int.Parse(Console.ReadLine());
            // char ch = char.Parse(Console.ReadLine());
            // double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //  string[] v = Console.ReadLine().Split(' ');
            //  string nome = v[0];
            //   char sexo = char.Parse(v[1]);
            //   int idade = int.Parse(v[2]);
            //   double altura = double.Parse(v[3], CultureInfo.InvariantCulture);

            //    Console.WriteLine("Voce digitou: ");
            //   Console.WriteLine(n1);
            //   Console.WriteLine(ch);
            //   Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            //   Console.WriteLine($"Seu nome ´: {nome}, Genero: {sexo}, Sua idade: {idade}, Sua altura é: {altura.ToString("f2", CultureInfo.InvariantCulture)}");















            //string frase = Console.ReadLine();
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //string z = Console.ReadLine();

            //string[] v = Console.ReadLine().Split(' ');
            //string a = v[0];
            //string b = v[1];
            //////////string c = v[2];




            //Console.WriteLine("Você digitou: ");
            //Console.WriteLine(frase);
            // Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine($"{a}, {b}, {c}");





            // int n1 = 3 + 4 * 2;
            //  int n2 = (3 + 4) * 2;
            //  int n3 = 17 % 3;
            //   double n4 = (double)10 / 8;
            //  double n5 = 10.0 / 8.0;

            //   double a = 1.0, b = -3.0, c = -4.0;

            //  double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            //   double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            //  double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            //   Console.WriteLine(n1);
            // Console.WriteLine(n2);
            //Console.WriteLine(n3);
            //  Console.WriteLine(n4);
            //Console.WriteLine(n5);
            //  Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine(delta);
            //   Console.WriteLine(x1);
            //   Console.WriteLine(x2);




            //double a;
            //float b;

            //a = 5.1;
            //b = (float)a;

            //Console.WriteLine(b);


            //   int d = 5;
            //   int f = 2;

            //   double resultado =(double) d / f;

            //   Console.WriteLine(resultado);





            //string produtos1 = "computador";
            // string produtos2 = "Mesa de escritorio";

            // byte idade = 30;
            //int codigo = 5290;
            //char genero = 'M';

            //double preco1 = 2100.0;
            //double preco2 = 650.50;
            //double medida = 53.234567;


            //Console.WriteLine("Produtos:");
            // Console.WriteLine($"{produtos1}, cujo preco e ${preco1}");
            //Console.WriteLine($"{produtos2}, cujo preco é ${preco2}");
            // Console.WriteLine($"Registro:{idade}, anos de idade, código {codigo} e gênero: {genero}");
            //  Console.WriteLine($"Medida com oito casas decimais: {medida}");
            // Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            // Console.WriteLine("Separador decimal invariant culture" + medida.ToString("f3",CultureInfo.InvariantCulture));


            //int idade = 30;
            //double saldo = 10.6589;
            //string nome = "Leandro";


            //Console.WriteLine("{0} tem {1} anos e tem o saldo igual a {2:F2} reais", nome, idade, saldo);
            //Console.WriteLine($"{nome} tem {idade} anos e tem o saldo igual a {saldo:F2} reais");




            // bool completo = false;
            //char genero = 'F';
            //byte n1= 126;
            //int n2 = 1000;
            //float n5 = 4.5f;
            //double n6 = 4.5;
            //string nome = "maria";
            //object obj1 = "Leandro";
            //int n7 = int.MinValue;
            //int n8 = int.MaxValue;
            // decimal n9 = decimal.MaxValue;

            //double saldo = 10.369878;


            // Console.WriteLine(n9);
            //Console.WriteLine(n7);
            //Console.WriteLine(n8);
            //Console.WriteLine(n1 + n2);
            //Console.WriteLine(completo);
            //.WriteLine(genero);
            //.WriteLine(n5);
            //.WriteLine(n6);
            //Console.WriteLine(nome);
            //Console.WriteLine(obj1);
            //Console.WriteLine(saldo.ToString("f2"));
            //Console.WriteLine(saldo.ToString("f4"));
            //Console.WriteLine(saldo.ToString("f4",CultureInfo.InvariantCulture));
        }
    }
}
