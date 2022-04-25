namespace Domain.Models
{
    public class UsuarioModel
    {
        #region Propriedades
        public string? Email { get; set; }
        public string? Senha { get; set; }
        #endregion

        #region Construtor
        public UsuarioModel(string? email, string? senha)
        {
            Email = email;
            Senha = senha;
            validarDados();
        }
        #endregion

        #region Método Validador
        void validarDados()
        {
            if (Email == null || Email.Trim().Length == 0) 
                throw new Exception("O e-mail não pode ser nulo ou vazio");

            if (Senha == null || Senha.Trim().Length == 0) 
                throw new Exception("A senha não pode ser nula ou vazia");
        }
        #endregion
    }
}
