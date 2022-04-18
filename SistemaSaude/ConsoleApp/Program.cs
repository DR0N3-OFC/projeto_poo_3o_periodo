using Matricula.Domain.Models;


//UsuarioModel usuario = new UsuarioModel("Bruno", "brunoraphaelfacundo@gmail.com", "bruninho123", "123");
UsuarioModel usuario = new UsuarioModel(null, null, null, null);

if (usuario.IsValid)
{
    Console.WriteLine($"O usuário {usuario.Nome} foi cadastrado com sucesso. Confira os dados a seguir:");
    Console.WriteLine($"Email: {usuario.Email}");
    Console.WriteLine($"Login: {usuario.Login}");
    Console.WriteLine($"Senha: {usuario.Senha}");
    Console.WriteLine($"Data de cadastro: {usuario.DataCadastro}");
}
else
{   
    if (usuario.NotificationsCount == 1)
        Console.WriteLine("Erro durante o cadastro de conta:");
    else
        Console.WriteLine("Erros durante o cadastro de conta:");

    for (int i = 0; i < usuario.NotificationsCount; i++)
    {
        Console.WriteLine($"{usuario.Notifications[i]}");
    }
}

Console.ReadKey();


