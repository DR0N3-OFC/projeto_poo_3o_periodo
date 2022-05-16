
using Domain.Models;
using Persistence.DataContext;
using Persistence.Repository;

var pacienteModelRepository = new PacienteModelRepository(new EFDataContext());
IReadOnlyCollection<PacienteModel>? pacientes = pacienteModelRepository.ObterTodos();

foreach (var e in pacientes)
{
    Console.WriteLine($"Paciente:{e.Nome}");
}
Console.WriteLine("Recuperação finalizada");

Console.ReadKey();