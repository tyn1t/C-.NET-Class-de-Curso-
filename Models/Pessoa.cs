using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propro.Models
{
    public class Pessoa
    {   
        public Pessoa() {}
        
        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }
        private string? _nome;
        private int _idade;

        public string? Nome 
        { 
            get => _nome?.ToUpper();
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Nome não poder ser vazio ");
                }
                
                _nome = value;
            }
        }
        public string? Sobrenome { get; set; }
        public string? NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade 
        { 
            get => _idade;
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idade não poder ser meno que zero");
                }
                _idade = value;
            }
        }

        public void Aprensetar()
        {
            Console.WriteLine($"Olá meu {NomeCompleto} {Idade}");
        }
    }
}