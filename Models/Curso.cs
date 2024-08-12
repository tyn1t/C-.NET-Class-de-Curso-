using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propro.Models
{
    public class Curso
    {
        public string? Nome { get; set; }
        public  List<Pessoa>? Alunos { get; set; }

        public void AdicionaAluno(Pessoa Aluno)
        {
            Alunos.Add(Aluno);
        }
        public int ObderQuantidadeAlunos()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public bool RemoveAluno(Pessoa Aluno)
        {
            return Alunos.Remove(Aluno);
        }
        public void ListaAluno()
        {
            Console.WriteLine($"Alonos do Curso de {Nome}");
            foreach(Pessoa Aluno in Alunos)
            {   
                Console.WriteLine($"Aluno: {Aluno.NomeCompleto} {Aluno.Idade}");
            }
        }
    }
}