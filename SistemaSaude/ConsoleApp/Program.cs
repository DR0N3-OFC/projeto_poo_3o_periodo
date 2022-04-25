
using Domain.Models;
string? tipo = "";
tipo = Console.ReadLine();

if (tipo == "p")
{
    PessoaModel pessoa =
    new PessoaModel
    (
        "dronecraftbr10@gmail.com", "negao19072003", "Bruno", new DateTime(2003, 07, 19), null, "(45) 99979-2278", "13.094.567-8", "094.476.579-31"
    );

    Console.WriteLine($"O usuário {pessoa.Nome} foi cadastrado com os seguintes dados:");
    Console.WriteLine($"Email: {pessoa.EmailPub}");
    Console.WriteLine($"Senha: {pessoa.SenhaPub}");
    Console.WriteLine($"Data de Nascimento: {pessoa.DataDeNascimentoTratada} (Idade: {pessoa.Idade}");
    Console.WriteLine($"Sexo: {pessoa.Sexo}");
    Console.WriteLine($"Telefone: {pessoa.Telefone}");
    Console.WriteLine($"RG: {pessoa.Rg}");
    Console.WriteLine($"CPF: {pessoa.Cpf}");
}
if (tipo == "m")
{
    MedicoModel medico =
    new MedicoModel
    (
        "medico@medicina.com", "medico123", "Carlos", "(45) 99878-6543", "Cardiologista", "12345", "24.841.834-04", "024.893.813-04"
    );

    Console.WriteLine($"O médico {medico.Nome} foi cadastrado com os seguintes dados:");
    Console.WriteLine($"Email: {medico.EmailPub}");
    Console.WriteLine($"Senha: {medico.SenhaPub}");
    Console.WriteLine($"Telefone: {medico.Telefone}");
    Console.WriteLine($"Especialidade: {medico.Especialidade}");
    Console.WriteLine($"CRM: {medico.Crm}");
    Console.WriteLine($"RG: {medico.Rg}");
    Console.WriteLine($"CPF: {medico.Cpf}");
}

Console.ReadKey();