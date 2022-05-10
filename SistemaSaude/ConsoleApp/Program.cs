
using Domain.Enumerators;
using Domain.Models;

var remedio = new Remedio("Ibuprofeno", TipoRemedio.Antiinflamatorio, new DateTime(2024, 07, 19));
var remedio2 = new Remedio("Gabapentina", TipoRemedio.Antidepressivo, new DateTime(2027, 03, 15));

var reserva1 = new ReservaModel();

reserva1.adicionarRemedio(remedio);
reserva1.adicionarRemedio(remedio2);

Console.ReadKey();