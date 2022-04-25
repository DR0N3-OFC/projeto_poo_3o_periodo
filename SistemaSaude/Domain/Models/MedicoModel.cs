namespace Domain.Models
{
    public class MedicoModel : UsuarioModel
    {
        #region Properties
        public string? Nome { get; private set; }
        public string? Telefone { get; private set; }
        public string? Especialidade { get; private set; }
        public string? Crm { get; private set; }
        public string? Cpf { get; private set; }
        public string? Rg { get; private set; }
        public string? EmailPub { get { return Email; } }
        public string? SenhaPub { get { return Senha; } }
        #endregion

        #region Constructor
        public MedicoModel
            (string? email, string? senha, string? nome, string? telefone, string? especialidade, string? crm, string? cpf, string? rg)
        {
            Email = email;
            Senha = senha;
            Nome = nome;
            Telefone = telefone;
            Especialidade = especialidade;
            Crm = crm;
            Cpf = cpf;
            Rg = rg;
            validateData();
        }
        #endregion

        #region Validations
        void validateData()
        {
            if (Email == null || Email.Trim().Length == 0)
                throw new Exception("O e-mail não pode ser nulo ou vazio");

            if (Senha == null || Senha.Trim().Length == 0)
                throw new Exception("A senha não pode ser nula ou vazia");

            if (Nome == null || Nome.Trim().Length == 0)
                throw new Exception("O nome não pode ser nulo ou vazio");

            if (Telefone == null || Telefone.Trim().Length == 0)
                Telefone = "Não informado";

            if (Especialidade == null || Especialidade.Trim().Length == 0)
                throw new Exception("A especialidade não pode ser nula ou vazia");

            if (Crm == null || Crm.Trim().Length == 0)
                throw new Exception("O CRM não pode ser nulo ou vazio");

            if (Rg == null || Rg.Trim().Length == 0)
                throw new Exception("O RG não pode ser nulo ou vazio");

            if (Cpf == null || Cpf.Trim().Length == 0)
                throw new Exception("O CPF não pode ser nulo ou vazio");
        }
        #endregion
    }
}
