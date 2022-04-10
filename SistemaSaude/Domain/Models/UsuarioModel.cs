namespace Matricula.Domain.Models
{
    public class UsuarioModel
    {
        #region Properties
        private string? _nome;
        private string? _email;
        private string? _login;
        private string? _senha;
        private DateTime _dataCadastro;
       
        public string? Nome { get; private set; }
        public string? Email { get; private set; }
        public string? Login { get; private set; }
        public string? Senha { get; private set; }
        public string DataCadastro { get 
            {
                return DateTime.Now.ToShortDateString();
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
            if (Nome == null)
                throw new Exception("O nome não pode ser nulo");
            if (Email == null)
                throw new Exception("O email não pode ser nulo");
            if (Login == null)
                throw new Exception("O login não pode ser nulo");
            if (Senha == null)
                throw new Exception("A senha não pode ser nula");
        }
        #endregion
    }
}
