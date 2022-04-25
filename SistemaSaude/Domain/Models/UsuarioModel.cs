namespace Domain.Models
{
    public abstract class UsuarioModel
    {
        #region Propriedades
        protected string? Email { get; set; }
        protected string? Senha { get; set; }
        #endregion
    }
}
