
using Domain.Models;
using Persistence.DataContext;

var context = new EFDataContext();
IList<PacienteModel> pacientes = context.Pacientes.ToList();

foreach (var e in pacientes)
{
    Console.WriteLine($"Paciente:{e.Nome}");
}
Console.WriteLine("Recuperação finalizada");

Console.ReadKey();