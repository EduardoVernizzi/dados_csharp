using dados_csharp.Models;
using System.Globalization;


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
