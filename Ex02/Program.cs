using Classes;

Estacionamento estacionamento = new Estacionamento(20);
estacionamento.RegistrarVeiculo("123", "Corolla");
estacionamento.RegistrarVeiculo("345", "Clio");
estacionamento.RegistrarVeiculo("456", "Hrv");
estacionamento.RegistrarVeiculo("678", "Fit");
estacionamento.RegistrarVeiculo("890", "Nivus");
estacionamento.RegistrarVeiculo("255", "Polo");
estacionamento.ListarVeiculos();
estacionamento.ExcluirVeiculo("999");
estacionamento.ListarVeiculos();