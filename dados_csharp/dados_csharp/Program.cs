using dados_csharp.Models;

Pessoa p1 = new Pessoa(nome: "Eduardo", sobrenome: "Vernizzi");
Pessoa p2 = new Pessoa(nome: "Thiago", sobrenome: "Vernizzi");


Curso ingles = new Curso();

ingles.Nome = "Inglês";
ingles.Alunos = new List<Pessoa>();
ingles.AdicionarAluno(p1);
ingles.AdicionarAluno(p2);
ingles.ObterQuantidadeDeAlunosMatriculados();
ingles.ListarAlunos();










//Implementação e teste de Métodos

//Pessoa p1 = new Pessoa();
//p1.Nome = "Eduardo";
//p1.Sobrenome= "Vernizzi";
//p1.Idade = 25;
//p1.Apresentar();
