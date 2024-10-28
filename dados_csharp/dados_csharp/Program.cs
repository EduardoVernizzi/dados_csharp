using dados_csharp.Models;
using System.Globalization;
using System.Security.Cryptography;



//If ternário

//int numero = 15;
//bool ehPar = false;

//ehPar = numero % 2 == 0;
//Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar")) ;


//int numero = 15;

//if (numero % 2 == 0)
//{
//    Console.WriteLine($"O número {numero} é par");
//}
//else
//{
//    Console.WriteLine($"O número {numero} é impar");
//}








//Desconstrutor

//Pessoa p1 = new Pessoa("Carlos Eduardo", "Vernizzi");

//(string nome, string sobrenome) = p1;

//Console.WriteLine($"Nome: {nome} {sobrenome}");




//Invocando método que retorna 3 informações através de tuplas

//LeituraArquivo arquivo = new LeituraArquivo();
//var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("C://git/dados_csharp/dados_csharp/dados_csharp/Arquivos/ArquivoLeitura.txt");

//if (sucesso)
//{
//    Console.WriteLine($"Quantidade de linhas do arquivo: " + quantidadeLinhas);
//    foreach (string linha in linhasArquivo)
//    {
//        Console.WriteLine(linha);
//    }
//}
//else
//{
//    Console.WriteLine("Não foi possível ler o arquivo!");
//}


////Tuplas

//(int, string, string,decimal) tupla = (1, "Eduardo", "Vernizzi", 1.85m);


//Console.WriteLine($" Id: {tupla.Item1}");
//Console.WriteLine($" Nome: {tupla.Item2}");
//Console.WriteLine($" Sobrenome: {tupla.Item3}");
//Console.WriteLine($" Altura: {tupla.Item4}");



//Usando a coleção Dictionary
//Dictionary<string,string> estados = new Dictionary<string,string>();

//estados.Add("SP", "São Paulo");
//estados.Add("BA", "Bahia");
//estados.Add("MG", "Minas Gerais");

//foreach (var item in estados)
//{
//    Console.WriteLine($"Chave: {item.Key}. Valor: {item.Value}\n");
//}
//Console.WriteLine("---------------");
//estados.Remove("BA");

//estados["SP"] = "São Paulo - valor alterado";

//foreach (var item in estados)
//{
//    Console.WriteLine($"Chave: {item.Key}. Valor: {item.Value}\n");
//}


//string chave = "BA";
//Console.WriteLine($"Verificando o elemento {chave}");

//if (estados.ContainsKey(chave))
//{
//    Console.WriteLine($"Valor Existente: {chave}");
//}
//else
//{
//    Console.WriteLine($"Valor não existente. É seguro adicionar a chave {chave}");
//}


//Exemplo de PILHAS
//Stack<int> pilha = new Stack<int>();

//pilha.Push(4);
//pilha.Push(6);
//pilha.Push(8);
//pilha.Push(10);

//foreach (int item in pilha)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine($"\nRemovendo o elemento {pilha.Pop()} do topo\n");

//pilha.Push(20);

//foreach (int item in pilha)
//{
//    Console.WriteLine(item);
//}



//Exemplo de Fila
//Queue <int> fila = new Queue <int> ();

//fila.Enqueue (2);
//fila.Enqueue(4);
//fila.Enqueue(6);
//fila.Enqueue(8);

//foreach (int item in fila)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine($"\nRemovendo o elemento: {fila.Dequeue()} \n ");

//fila.Enqueue(10);

//foreach (int item in fila)
//{
//    Console.WriteLine(item);
//}




//Utilizando o THROW
//ExemploExcecao ex1 = new ExemploExcecao();
//ex1.Metodo1();


//Tratamento de exceções com o TRY/CATCH/FINALLY
//try
//{
//    string[] linhas = File.ReadAllLines("C://git/dados_csharp/dados_csharp/dados_csharp/Arquivos/ArquivoLeitura.txt");

//    foreach (string linha in linhas)
//    {
//        Console.WriteLine(linha);
//    }

//}

//catch (FileNotFoundException ex)
//{

//    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
//}

//catch (DirectoryNotFoundException  ex)
//{

//    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
//}


//catch (Exception ex)
//{

//    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
//}

//finally
//{
//    Console.WriteLine("Chegou até aqui!! Independente da Exceção");
//}






//DateTime com TryParse

//string dataString = "2022-04-17 21:27 ";

//bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

//if (sucesso)
//{
//    Console.WriteLine(data);
//}
//else
//{
//    Console.WriteLine($"{dataString} Não é uma data válida");
//}



//DateTime

//DateTime data = DateTime.Now;

//Console.WriteLine(data.ToString("dd/MM/yyyy  HH:mm"));



//Representação monetária, porcentagem e formatação de valores

//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

//decimal valorMonetario = 1582.40m;

//Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

//double porcentagem = .3421;

//Console.WriteLine(porcentagem.ToString("P"));

//int numero = 123456;

//Console.WriteLine(numero.ToString("##-##-##"));







//Concatenação de valores

//string numero1 = "10";
//int numero2 = 20;
//string resultado = numero1 + numero2;

//Console.WriteLine(resultado);



//Instanciando classes

//Pessoa p1 = new Pessoa(nome: "Eduardo", sobrenome: "Vernizzi");
//Pessoa p2 = new Pessoa(nome: "Thiago", sobrenome: "Vernizzi");


//Curso ingles = new Curso();

//ingles.Nome = "Inglês";
//ingles.Alunos = new List<Pessoa>();
//ingles.AdicionarAluno(p1);
//ingles.AdicionarAluno(p2);
//ingles.ObterQuantidadeDeAlunosMatriculados();
//ingles.ListarAlunos();










//Implementação e teste de Métodos

//Pessoa p1 = new Pessoa();
//p1.Nome = "Eduardo";
//p1.Sobrenome= "Vernizzi";
//p1.Idade = 25;
//p1.Apresentar();
