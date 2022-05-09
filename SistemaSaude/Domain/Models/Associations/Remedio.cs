namespace Domain.Models
{
    public class Remedio
    {
        #region Properties
        public string? Nome { get; private set; }
        public string? Tipo { get; private set; }
        public DateTime? Validade { get; private set; }
        #endregion

        #region Constructor
        public Remedio(string? nome, string? tipo, DateTime? validade)
        {
            Nome = nome;
            Tipo = tipo;
            Validade = validade;
            ValidateData();
        }
        #endregion

        #region Validations
        void ValidateData()
        {
            if (Nome == null || Nome.Trim().Length == 0)
                throw new Exception("Nome não pode ser nulo ou vazio");

            if (Tipo == null || Tipo.Trim().Length == 0)
                throw new Exception("Tipo não pode ser nulo ou vazio");

            if (Validade == null)
                throw new Exception("Data de validade não pode ser nula");
        }
        #endregion
    }
}
