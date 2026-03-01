namespace Classes;

class Veiculo
{
    public string Placa {get; private set;}
    public string Modelo {get; private set;}
    public DateTime HoraDeEntrada {get; private set;}
    public Veiculo(string placa, string modelo, DateTime dateTime)
    {
        if (string.IsNullOrWhiteSpace(placa))
        {
            throw new ArgumentException("Placa Inválida.");
        }

        if (string.IsNullOrWhiteSpace(modelo))
        {
            throw new ArgumentException("Modelo Inválido.");
        }

        Placa = placa;
        Modelo = modelo;
        HoraDeEntrada = DateTime.Now;
    }
}