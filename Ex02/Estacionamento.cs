namespace Classes;

class Estacionamento
{
    public int Capacidade;
    private List<Veiculo> _veiculos = new List<Veiculo>();

    public Estacionamento(int capacidade)
    {
        Capacidade = capacidade;
    }
    public void RegistrarVeiculo(string placa, string modelo)
    {
        Veiculo novoVeiculo = new Veiculo(placa, modelo, DateTime.Now);
        _veiculos.Add(novoVeiculo);
    }

    public void ListarVeiculos()
    {
        foreach(var v in _veiculos)
        {
            Console.WriteLine($"Placa: {v.Placa} Modelo: {v.Modelo} Hora de Entrada: {v.HoraDeEntrada}");
        }
    }

    public void ExcluirVeiculo(string placaConsultada)
    {
        int removido = _veiculos.RemoveAll(v => v.Placa == placaConsultada);
    }
}