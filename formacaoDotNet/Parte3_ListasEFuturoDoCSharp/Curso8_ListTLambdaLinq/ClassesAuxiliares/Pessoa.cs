using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAuxiliares
{
    public class Pessoa
    {
        public string Nome { get; }
        public int Idade { get; }
        public double Altura { get; }

        public Pessoa(string nome, int idade, double altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }

        public static List<Pessoa> GerarLista()
        {
            return new List<Pessoa>()
            {
                new Pessoa(idade: 35, altura: 1.81, nome: "Bianca"),
                new Pessoa(idade: 24, altura: 1.77, nome: "Katia"),
                new Pessoa(idade: 18, altura: 1.76, nome: "Wilson"),
                new Pessoa(idade: 17, altura: 1.78, nome: "Pedro"),
                new Pessoa(idade: 23, altura: 1.75, nome: "Zélio"),
                new Pessoa(idade: 40, altura: 1.61, nome: "Selma"),
                new Pessoa(idade: 41, altura: 1.68, nome: "Helena"),
                new Pessoa(idade: 43, altura: 1.65, nome: "Maria"),
                new Pessoa(idade: 45, altura: 1.71, nome: "Auguto"),
                new Pessoa(idade: 42, altura: 1.91, nome: "José")
            };
        }
    }
}
