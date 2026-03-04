namespace Classe;
class Colaborador: IDesconto, IBonus
{
    public decimal Salario {get; private set;}
    public decimal ValeTransporte(decimal salarioBruto)
    {
        Salario += salarioBruto * 0.6m;
        return Salario;
    }

    public decimal PremioFaltas(int faltas)
    {
        if(faltas <= 0)
            Salario += 300;
        
        return Salario;
    }
}