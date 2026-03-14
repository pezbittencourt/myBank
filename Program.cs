Console.WriteLine("Bem vindo ao MiniBank!");

var novoCliente = new Cliente ();
novoCliente.Nome = "Ana Luisa Miguel Paterno Lima";
novoCliente.CPF = "123.456.902-34";
novoCliente.Email = "pedro.zeferinob@gmail.com";


var newBankAccount = new ContaBancaria("12345-6", 1000m, novoCliente);

newBankAccount.Depositar(1500m);
newBankAccount.Sacar (0m);

Console.WriteLine($"{novoCliente.Nome} - Saldo: {newBankAccount.Saldo}");   
