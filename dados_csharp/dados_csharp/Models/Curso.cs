using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dados_csharp.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno (Pessoa aluno)
        {
            Alunos.Add (aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            Console.WriteLine($"Estão inscritos nesse curso {quantidade} alunos: ");
            return quantidade;
        }

        public bool RemoverAluno (Pessoa aluno)
        {
            return Alunos.Remove (aluno); 
        }

        public void ListarAlunos()
        {

            Console.WriteLine($"Alunos do curso de {Nome}");
            for(int count = 0; count < Alunos.Count; count++)
            {
                /// Concatenação -> string texto = "Nº " + (count+1) + " - " + Alunos[count].NomeCompleto;
                /// Interpolação:
                string texto = $"Nº{count+1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }


           
        }
    }
}
