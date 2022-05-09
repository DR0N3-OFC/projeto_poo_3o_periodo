namespace Domain.Models
{
    public class PacienteModel : PessoaModel
    {
        #region Full Properties
        private IList<Consulta> _consultas;

        public IReadOnlyCollection<Consulta> Consultas
        {
            get { return (IReadOnlyCollection<Consulta>)_consultas; }
        }
        #endregion

        #region Constructor
        public PacienteModel
            (string? email, string? senha, string? nome, DateTime? dataDeNascimento, Endereco? endereco, string? telefone, string? cpf, string? rg) : base()
        {
            Email = email;
            Senha = senha;
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Endereco = endereco;
            Telefone = telefone;
            Cpf = cpf;
            Rg = rg;
            _consultas = new List<Consulta>();
            ValidateData();
        }
        #endregion
    }
}
