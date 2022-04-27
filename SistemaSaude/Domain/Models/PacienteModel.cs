namespace Domain.Models
{
    public class PacienteModel : PessoaModel
    {
        #region Constructor
        public PacienteModel
            (string? email, string? senha, string? nome, DateTime? dataDeNascimento, string? telefone, string? cpf, string? rg) : base()
        {
            Email = email;
            Senha = senha;
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Telefone = telefone;
            Cpf = cpf;
            Rg = rg;
            ValidateData();
        }
        #endregion
    }
}
