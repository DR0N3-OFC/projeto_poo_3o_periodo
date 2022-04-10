using Matricula.Domain.Models;

try
{
    UsuarioModel usuario = new UsuarioModel("Bruno", "brunoraphaelfacundo@gmail.com", "bruninho123", "123");
    //UsuarioModel usuario = new UsuarioModel(null, null, null, null);
    usuario.ChangeName(null);

    //usuario.Nome = "Bruno";
    //usuario.Email = "brunoraphaelfacundo@gmail.com";
    //usuario.Login = "bruninho123";
    //usuario.Senha = "123";

    Console.WriteLine($"O usuário {usuario.Nome} foi cadastrado com sucesso. Confira os dados a seguir:");
    Console.WriteLine($"Email: {usuario.Email}");
    Console.WriteLine($"Login: {usuario.Login}");
    Console.WriteLine($"Senha: {usuario.Senha}");
    Console.WriteLine($"Data de cadastro: {usuario.DataCadastro}");
}
catch (Exception e)
{
    Console.WriteLine($"ERROR: {e.Message}");
}
finally 
{
    Console.ReadKey();
}


