
using Domain.Models;

PessoaModel usuario = new PessoaModel("brunofacundo@gmail.com", "1232003", null, null, null, null, null);

Console.WriteLine($"O usuário com e-mail {usuario.Email}, foi cadastrado com a senha {usuario.Senha}");