namespace Classe;

class Aluno
{
    public string Nome {get; private set;}
    public int Nota1 {get; private set;}
    public int Nota2 {get; private set;}
    
    public double Media => (Nota1 + Nota2) / 2;
    public bool EstaAprovado => Media >= 7;
    
    public Aluno(string nome, int nota1, int nota2)
    {
        Nome = nome;
        Nota1 = nota1;
        Nota2 = nota2;
    }
}