using Propro.Models;


Pessoa pessoa1 = new(nome:"Giovanni", sobrenome:"Souza", 22);

Pessoa pessoa2 = new()
{
    Nome = "Anderlan",
    Sobrenome = "Souza",
    Idade = 24
}; 
Pessoa pessoa3 = new()
{
    Nome = "Lanna",
    Sobrenome = "Souza",
    Idade = 20
};

Curso cursoIngles = new()
{
    Nome = "Ingles",
    Alunos = [],
};


cursoIngles.AdicionaAluno(pessoa1);
cursoIngles.AdicionaAluno(pessoa2);
cursoIngles.AdicionaAluno(pessoa3);
cursoIngles.ListaAluno();
