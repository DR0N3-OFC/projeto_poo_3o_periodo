namespace Matricula.Domain.Models
{
    public class UsuarioModel
    {
        #region Properties
        public string? Nome { get; private set; }
        public string? Email { get; private set; }
        public string? Login { get; private set; }
        public string? Senha { get; private set; }
        public string? DataCadastro { get 
            {
                string dataCadastro = DateTime.Now.ToShortDateString();
                return dataCadastro;
            } 
        }
        #endregion

        #region Constructors
        public UsuarioModel(string? nome, string? email, string? login, string? senha)
        {
            Nome = nome;
            Email = email;
            Login = login;
            Senha = senha;
            ApplyValidations();
        }
        #endregion

        #region Accessors Methods
        public void ChangeName(string? nome)
        {
            Nome = nome;
            ApplyValidations();
        }
        #endregion

        #region Apply Validations Methods
        public void ApplyValidations()
        {
            if (Nome == null || Nome.Trim().Length == 0)
                throw new Exception("O nome não pode ser nulo");
            if (Email == null || Email.Trim().Length == 0)
                throw new Exception("O email não pode ser nulo");
            if (Login == null || Login.Trim().Length == 0)
                throw new Exception("O login não pode ser nulo");
            if (Senha == null || Senha.Trim().Length == 0)
                throw new Exception("A senha não pode ser nula");
        }
        #endregion
    }
}
