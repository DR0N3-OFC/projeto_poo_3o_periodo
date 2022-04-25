namespace Domain.Models
{
    public class PessoaModel : UsuarioModel
    {
        #region Propriedades
        public DateTime? DataDeNascimento { get; private set; }
        public int? Idade { get 
            {
                TimeSpan? timeSpan = (DateTime.Now - DataDeNascimento);
                return timeSpan?.Days / 365; 
            } 
        }
        public string? Sexo { get; private set; }
        public string? Telefone { get; private set; }
        public string? Rg { get; private set; }
        public string? Cpf { get; private set; }
        #endregion

        #region Construtor
        public PessoaModel
            (
            string? email, string? senha, DateTime? dataDeNascimento, 
            string? sexo, string? telefone, string? rg, string? cpf
            ) : base(email, senha)
        {
            Email = email;
            Senha = senha;
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Telefone = telefone;
            Rg = rg;
            Cpf = cpf;
            validarDados();
        }
        #endregion

        #region Validações
        void validarDados()
        {
            if (DataDeNascimento == null)
                throw new Exception("A data de nascimento não pode ser nula ou vazia");

            if (Sexo == null || Sexo.Trim().Length == 0)
                Sexo = "Não informado";

            if (Telefone == null || Telefone.Trim().Length == 0)
                Telefone = "Não informado";

            if (Rg == null || Rg.Trim().Length == 0)
                throw new Exception("O RG não pode ser nulo ou vazio");

            if (Cpf == null || Cpf.Trim().Length == 0)
                throw new Exception("O CPF não pode ser nulo ou vazio");
        }
        #endregion
    }
}
