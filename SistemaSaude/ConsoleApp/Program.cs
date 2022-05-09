
using Domain.Models;
string? tipo = "";
Console.WriteLine("Tipo de cadastro a ser realizado: (p = Paciente; m = Medico)");
tipo = Console.ReadLine();

if (tipo == "p")
{
    PacienteModel paciente =
    new (
            email: "dronecraftbr10@gmail.com",
            senha: "12345",
            nome: "Bruno",
            dataDeNascimento: new DateTime(2003, 07, 19),
            telefone: "(45) 99979-2278",
            cpf: "13.094.567-8",
            rg: "094.476.579-31"
        );

    Console.WriteLine($"O usuário {paciente.Nome} foi cadastrado com os seguintes dados:");
    Console.WriteLine($"Email: {paciente.Email}");
    Console.WriteLine($"Senha: {paciente.Senha}");
    Console.WriteLine($"Data de Nascimento: {paciente.DataDeNascimentoTratada} (Idade: {paciente.Idade})");
    Console.WriteLine($"Telefone: {paciente.Telefone}");
    Console.WriteLine($"RG: {paciente.Rg}");
    Console.WriteLine($"CPF: {paciente.Cpf}");
}
if (tipo == "m")
{
    MedicoModel medico =
    new (
            email: "medico@medicina.com",
            senha: "medico123",
            nome: "Carlos",
            dataDeNascimento: new DateTime(1997, 03, 21),
            telefone: "(45) 99878-6543",
            especialidade: "Cardiologista",
            crm: "12345",
            cpf: "024.893.813-04",
            rg: "24.841.834-04"
        );

    Console.WriteLine($"O médico {medico.Nome} foi cadastrado com os seguintes dados:");
    Console.WriteLine($"Email: {medico.Email}");
    Console.WriteLine($"Senha: {medico.Senha}");
    Console.WriteLine($"Senha: {medico.DataDeNascimentoTratada} (Idade: {medico.Idade})");
    Console.WriteLine($"Telefone: {medico.Telefone}");
    Console.WriteLine($"Especialidade: {medico.Especialidade}");
    Console.WriteLine($"CRM: {medico.Crm}");
    Console.WriteLine($"RG: {medico.Rg}");
    Console.WriteLine($"CPF: {medico.Cpf}");
}

Console.ReadKey();