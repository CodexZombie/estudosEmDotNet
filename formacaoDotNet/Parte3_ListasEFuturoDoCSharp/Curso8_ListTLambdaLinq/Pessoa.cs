using System;

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
}
