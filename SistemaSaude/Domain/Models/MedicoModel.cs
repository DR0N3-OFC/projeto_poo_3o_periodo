namespace Domain.Models
{
    public class MedicoModel : PessoaModel
    {
        #region Properties
        public string? Especialidade { get; private set; }
        public string? Crm { get; private set; }
        #endregion

        #region Constructor
        public MedicoModel
            (string? email, string? senha, string? nome, DateTime? dataDeNascimento, Endereco? endereco, string? telefone, string? especialidade, string? crm, string? cpf, string? rg) : base()
        {
            Email = email;
            Senha = senha;
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Endereco = endereco;
            Telefone = telefone;
            Especialidade = especialidade;
            Crm = crm;
            Cpf = cpf;
            Rg = rg;
            ValidateData();
            ValidateDataMedico();
        }
        #endregion

        #region Validations
        void ValidateDataMedico()
        {
            if (Especialidade == null || Especialidade.Trim().Length == 0)
                throw new Exception("A especialidade não pode ser nula ou vazia");

            if (Crm == null || Crm.Trim().Length == 0)
                throw new Exception("O CRM não pode ser nulo ou vazio");
        }
        #endregion
    }
}
