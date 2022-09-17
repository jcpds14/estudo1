using ESTUDO1.Models;

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Jean";
pessoa1.Idade = 25;
pessoa1.Apresentar();

string apresentacao = "Olá";
int quantidade = 2;
double altura = 1.90;
decimal preco = 3.80M;
bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da int: " + quantidade);
Console.WriteLine("Valor do double: " + altura);
Console.WriteLine("Valor do decimal : " + preco);
Console.WriteLine("Valor do bool: " + condicao);

//date
DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);
//date hourless
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
//date milisecondsless
Console.WriteLine(dataAtual.ToString("dd/MM/yy HH:mm"));
//add future date
DateTime data5Days = DateTime.Now.AddDays(5);
Console.WriteLine(data5Days);

//Cast or Casting - É o ato de converter

//Converter para Inteiro
//int.Parse() or
int a = Convert.ToInt32("5");
//É preferível utilizar Convert pois no caso do valor ser null(O que pode ser muito comum) o retorno é zero e a aplicação continua rodando, no Parse o retorno é um erro e a aplicação é encerrada.
Console.WriteLine(a);

//Converter para String
//ToString() está em tudo que fazemos no C#, e é a forma ideal de se converter qualquer coisa para String. Se Usar Convert para converter para String seu código será redundante.
int inteiro = 6;
string b = inteiro.ToString();

Console.WriteLine(b);

//Cast implícito - É uma conversão de diferentes tipos, onde não é necessário definir a conversão pois ele faz isso automaticamente para você.
//Ocorre quando um valor está no outro
int c = 7;//Valor máximo de int é cerca de 2 bilhões
long d = c;//Valor máximo de long é trilhões
//ocódigo acima é permitido pois o valor de int (bilhões) cabe em long (trilhões), sendo assim o C# faz a conversão de forma implícita pois o valor do primeiro cabe no segundo.

//Ordem dos Operadores - Segue a mesma ordem matemática
//()
//EXPOENTES
//* /
//+ -

//Conversão segura
string e = "15e";

int f = 0;

int.TryParse(e, out f);//tryParse espera que realmente dê erro, se der erro ele mostrará a saída (out), se não der erro ele mostra o primeiro valor, mas de qualquer forma o programa não é encerrado.

Console.WriteLine(f);
Console.WriteLine("Conversão realizada com sucesso!");

//Operador Condicional
int quantidadeNoEstoque = 10;

int quantidadeDeCompra = 6;

if(quantidadeNoEstoque >= quantidadeDeCompra)
{
    Console.WriteLine("Compra realizada com sucesso!");
}else
{
    Console.WriteLine("Desculpe, não temos essa quantidade em estoque.");
}

//Outro jeito
int quantidadeNoEstoque2 = 10;
int quantidadeDeCompra2 = 6;
bool possivelVenda = quantidadeNoEstoque2 >= quantidadeDeCompra2;

Console.WriteLine($"Quantidade em estoque: {quantidadeNoEstoque2}");
Console.WriteLine($"Quantidade selecionada: {quantidadeDeCompra2}");
Console.WriteLine($"É possível realizar a compra? {possivelVenda}");

if(possivelVenda)
{
    Console.WriteLine("Compra realizada!");
}else
{
    Console.WriteLine("Não temos essa quantidade em estoque.");
}
//if aninhado
int quantidadeNoEstoque3 = 10;
Console.WriteLine($"Quantidade em estoque: {quantidadeNoEstoque3}");
Console.WriteLine("Quantos deseja comprar?");
int quantidadeDeCompra3 = Convert.ToInt32(Console.ReadLine());
bool possivelVenda2 = quantidadeDeCompra > 0 && quantidadeNoEstoque3 >= quantidadeDeCompra3;


Console.WriteLine($"Quantidade selecionada: {quantidadeDeCompra3}");
Console.WriteLine($"É possível realizar a compra? {possivelVenda2}");

if (quantidadeDeCompra3 == 0)
{
    Console.WriteLine("Escolha a quantidade antes de comprar.");
}
else if(possivelVenda2)
{
    Console.WriteLine("Compra realizada!");
}else
{
    Console.WriteLine("Não temos essa quantidade em estoque.");
}
//switch case
Console.WriteLine("Digite uma vogal");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal válida");
        break;
    default:
    Console.WriteLine("Não é uma vogal");
    break;
}

//Operadores Lógicos
//Operador OR ||
int idadeOr = 17;
bool autorizacaoDoResponsavel = false;

if (idadeOr >= 18 || autorizacaoDoResponsavel == true)
{
    Console.WriteLine("Pode Entrar!");
}else
{
    Console.WriteLine("Entrada Proibida!");
}
//Operador AND &&
int presencaMinima = 20;
double mediaMinima = 7;

int presenca1 = 23;
double media1 = 8;

if (presenca1 >= presencaMinima && media1 >= mediaMinima)
{
    Console.WriteLine($"O aluno 1 teve presença de {presenca1} e média de {media1} Aprovado!");
}
else
{
    Console.WriteLine("Reprovado!");
}
//Operador NOT !
bool choveu = false;
bool estaTarde = false;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar!");
}
else
{
    Console.WriteLine("Vou pedalar outro dia");
}

//ARRAY
//É uma variável de um tipo que contém vários valores do mesmo tipo, com um tamanho fixo
//obrigatoriamente terá []
//ex:
//1. int[] array = new int[4]; Declara o tamanho fixo que o array terá
//2. int[] array = new int[] {42, 75, 74, 61}; Delclara o array detalhando diretamente os seus valores, não sendo necessário dizer o tamanho dele, pois já está explicito.
//3. string[] nomes = {"Jan", "Fev"}; Array do tipo string

//Índice é a posição de um determinado valor de um array
//ex:
//int elemento = Array[0] Índice 0, ou seja o índice vai buscar o valor que está na posição 0 do array
//array[0] = 42; significa que o valor que está na posição 0 do array será alterado para 42

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;

Console.WriteLine("Percorrendo o Array com FOR");
for (int contadorArray = 0; contadorArray < arrayInteiros.Length; contadorArray++)
{
    Console.WriteLine($"Posição número {contadorArray} - {arrayInteiros[contadorArray]}");
}
//redimensionando array
//um array nasce e morre com uma capacidade fixa, porém podemos utilizar o Array.Resize para criar uma cópia do Array e redimencionar o valor. No entanto é apenas uma cópia, o Array original permanece com o mesmo valor pois não pode ser diretamente alterado.
Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); //Estou gerando uma cópia do array e duplicando o seu tamanho

Console.WriteLine("Percorrendo o Array com FOREACH (para cada)");
foreach(int valorForeach in arrayInteiros)
{
    Console.WriteLine(valorForeach);
}
//foreach serve para listas e array e não possui contardor, porém é mais simples de ser implementado pois possui menos código.
