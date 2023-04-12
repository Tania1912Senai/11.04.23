//Aula 11/04
//criar um array de strings para armaenar 3 carros
//string[] carros = new string[3];
//for (var i = 0; i < 3; i++)
//{
//    Console.WriteLine($"Informe o nome do carro:");
//    carros[i] = Console.ReadLine();
//}
//Console.WriteLine($"carros cadastrados com sucesso!");
//Console.WriteLine($"Primeiro carro: {carros[0]}");
//Console.WriteLine($"Segundo carro: {carros[1]}");
//Console.WriteLine($"Terceiro carro: {carros[2]}");

//Console.WriteLine($"lista dos carros cadastrados:");
//for(var i = 0; i < 3; i++)
//{
//  Console.WriteLine($"Nome do carro: {carros[i]}");
//}
// foreach (var item in collection)
// Console.WriteLine(item);




//Atividade aula 11.04

//criar um programa em C# que receba 5 numeros inteiros e ao final exiba o seu dobro
//voce deve utilizar array com tamanho 5 para o armazenamento dos numeros,
// a estrutura for para a leitura dos numeros e a estrutura foreach para exibi-los
//entrada
//criar o array tamanho 5
//int[] numero = new int[5];
//[5] = A /0 B/1 C/2 D/3 E/4
// sao 5 gavetas mas iniciando com zero]
//processamento
//receber os numeros com (for)
//for (int indice = 0; indice < 5; indice++)
//{
//    Console.WriteLine($"Digite o {indice + 1}º numero");
//    numero [indice] = int.Parse(Console.ReadLine());
//}
//saida
//exibir os numeros com (foreach)
//foreach(var item in numero){
// Exemplo se uma pessoa digitou
//5
//10
//15
//30
//100
//Console.WriteLine($"Digite o dobro de {item} e {item*2}");
//}




//Exercicio de fixacao
//Escreva um programa que receba e imprima o nome e a idade de 5 pessoas
//personalizar cores: a resposta do nome em azul e a resposta da idade em verde

//Exemplo de exibicao
//1) nome: Carlos
//idade: 36 anos
//2) nome: Eduardo
//idade: 40 anos
//3) nome: Allan
//idade: 30 anos
//4) nome: Julia
//idade: 18 anos
//5) nome: Gustavo
//idade: 16 anos

 //Exercício de fixação com Resolucao em aula
 
 //escreva um programa que receba e imprima o nome e idade de 5 pessoas

 //personalizar cores: a resposta do nome em azul e a resposta da idade em verde (cor da fonte)

//declarando as variáveis
//string[] nomes = new string[5];//collection
//int[] idades = new int[5];//collection

//recebe e armazena os nomes e idades nos arrays
//for (var i = 0; i < 5; i++)

//{
//    Console.WriteLine($"Informe o {i + 1}º nome: ");
//    nomes[i] = Console.ReadLine();
//    Console.WriteLine($"Informe a {i + 1}º idade: ");
//    idades[i] = int.Parse(Console.ReadLine());         
//}

//exibe o nome e a idade correspondente
//for (var posicao = 0; posicao < 5; posicao++)
//{
//    Console.ForegroundColor = ConsoleColor.Blue;
//    Console.WriteLine($"{posicao + 1}) nome: {nomes[posicao]}  ");
//    Console.ResetColor();
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine($"  idade: {idades[posicao]} anos");
//    Console.ResetColor();
//    Console.WriteLine($"");   
//}

//Aula 12.04.23
//Funcoes
// A funcao usa varios metodos de procedimentos logicos que agilizam o processo
// O metodo e um bloco de codigos e esta entre parenteses e com ponto e virgula so executado quando chamado
// Os dados sao parametros para o metodo
// Nao podemos ter repeticao de codigo para ter performace
// Importancia de usar metodos? para reutilizar o codigo defina e use varias vezes
// O metodo e definido com o nome do metodo entre parenteses C# fez alguns como main 
// Explicando
// MyMethod = nome do metodo 
// static void myMethod
// static pertence a classe Program
// void  quando nao tem valor de retorno
// estatic = pq o metodo esta dentro da classe Program.cs
// void = tipo de retorno nesse caso sem retorno, apenas mostra a mensagem
//Exemplo
// MyMethod = nome do metodo (usar PascalCase)
//static void MyMetrod()
//{
    //bloco de codigo
//}
//criar um metodo para exibir o com nome de uma pessoa, sobrenome exibindo mensagem " Bom dia Fulano de tal"

//static void Saudacao()
//{
//  Console.WriteLine($"Informe o nome da pessoa:");
//    string nome = Console.ReadLine();
//    Console.WriteLine($"Informe o sobrenome da pessoa:;");
//   string sobrenome = Console.ReadLine();
//    Console.WriteLine($"Bom dia {nome} {sobrenome}");
//}

//criar um metodo para somar 2 numeros
//static float Somar()
//somar (n1, n2)
//somar (n1+n2)
//as informacoes podem ser passadas para metodo como parametro
//os parametros atuam como variaveis dentro do metodo
//pode adicionar quantos paramentros quiser entre virgulas

// static float Somar (float n1, float n2)
// {
//     return (n1+n2);
// }
// console.WriteLine($"informe o primeiro numero:");
// float primeiroNumero= float.Parse(Console.ReadLine());

// console.WriteLine($"informe o segundo numero:");
// float segundoNumero= float.Parse(Console.ReadLine());

// Console.WriteLine($"A soma de {primeiro numero} + {segundo numero} e {Somar (primeiroNumero, segundoNumero)}");

// //Somar(primeiroNumero, segundoNumero)
// como quero retorno nao e void mas float
// //criar os metodos para as demais operacoes matematicas (-,*,/)
// //receber os numeros e exibir os resultados

// static float Subtrair (float n1, float n2)
// {
//     return (n1-n2);
// }
// Console.WriteLine($"informe o primeiro numero");
// float primeiroNumero= float.Parse(Console.ReadLine());
// Console.WriteLine($"informe o segundo numero:");
// float segundoNumero= float.Parse(Console.ReadLine());
// Console.WriteLine($"A subtracao de {primeiro numero} - {segundo numero} e { Subtrair (primeiroNumero, segundoNumero)}");
// //Subtrair(primeiroNumero, segundoNumero)

// static float multiplicar (float n1,float n2)
// {
//     return (n1*n2);
// }
// Console.Writeline($"informe o primeiro numero");
// float primeiroNumero= float.Parse(Console.ReadLine());
// Console.WriteLine($"informe o segundo numero:");
// float segundoNumero= float.Parse(Console.ReadLine());
// Console.WriteLine($"A multiplicacao de {primeiro numero} * {segundo numero} e { Multiplicar (primeiroNumero, segundoNumero)}");
// //Multiplicar(primeiroNumero, segundoNumero)

// static float divisao (float n1,float n2)
// {
//      return (n1/n2);
// }
// Console.WriteLine($ "informe o primeiro numero");
// float primeiroNumero= float.Parse(Console.ReadLine());
// Console.WriteLine($"informe o segundo numero");
// float segundoNumero= float.Parse(Console.ReadLine());
// Console,Writeline($" A divisao de {primeiro numero} / {segundo numero} e { dividir (primeiroNumero, segundoNumero)}");
// //Divisao(primeiroNumero, segundoNumero)


// //Metodo para trazer hora para o sistema
// //static int MostrarHora()
// {
//     return DateTime.Now.Hour;

// }
// Console.WriteLine(MostrarHora());
// //Console.WriteLine ($Carregando................");

// static void BarraCarregamento(string texto, int quantidadePontinhos, int tempo)
// {
//     Console BackgroundColor = ConsoleColor.Red
//     Console.Write(texto)
//     //definir laco de continuidade
//     for (var i = 0; i< quantidadePontinhos; i++)
//     {
//         Console.WriteLine($".");
//         //console.WriteLine escreve linha por linha
//         //thread.sleep (2000) (sleep milisegundos de intervalo de impressao)
//         Thread.sleep(tempo);
//     }
//     Console.ResetColor();
// }   
//     BarraCarregamento("carregando,10,1000")
//     //chamar a funcao envocar ela e definir os parametros
//     BarraCarregamento("testando",15,700);
//     BarraCarregamento("finalizando",20,400);
//     BarraCarregamento("Aguarde",3,2000);
//     BarraCarregamento(Cadastrando",20,100);
//     BarraCarregamento("logando",25,200);



