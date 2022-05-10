namespace Domain.Models
{
    public abstract class PessoaModel
    {
        #region Properties
        public string? Email { get; protected set; }
        public string? Senha { get; protected set; }
        public string? Nome { get; protected set; }
        public DateTime? DataDeNascimento { get; protected set; }
        public string? DataDeNascimentoTratada
        {
            get
            {
                return DataDeNascimento?.ToShortDateString();
            }
        }
        public int? Idade { get 
            {
                TimeSpan? timeSpan = (DateTime.Now - DataDeNascimento);
                return timeSpan?.Days / 365; 
            } 
        }
        public Endereco? Endereco { get; protected set; }
        public string? Telefone { get; protected set; }
        public string? Rg { get; protected set; }
        public string? Cpf { get; protected set; }
        #endregion

        #region Validations
        protected void ValidateData()
        {
            if (Email == null || Email.Trim().Length == 0)
                throw new Exception("O e-mail não pode ser nulo ou vazio");

            if (Senha == null || Senha.Trim().Length == 0)
                throw new Exception("A senha não pode ser nula ou vazia");

            if (Nome == null || Nome.Trim().Length == 0)
                throw new Exception("O nome não pode ser nulo ou vazio");

            if (DataDeNascimento == null)
                throw new Exception("A data de nascimento não pode ser nula ou vazia");

            if (Endereco == null)
                throw new Exception("O endereco não pode ser nulo");

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
