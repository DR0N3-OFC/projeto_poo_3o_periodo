using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Remedio
    {
        #region Properties
        [Key]
        public Guid? RemedioID { get; private set; }
        public string? Nome { get; private set; }
        public string? Tipo { get; private set; }
        public DateTime? Validade { get; private set; }
        #endregion

        #region Constructor
        public Remedio(string? nome, string? tipo, DateTime? validade)
        {
            Nome = nome;
            Tipo = tipo;
            Validade = validade?.Date;
            ValidateData();
        }
        #endregion

        #region Methods
        public void GerarID()
        {
            RemedioID = Guid.NewGuid();
        }
        #endregion

        #region Validations
        void ValidateData()
        {
            if (Nome == null || Nome.Trim().Length == 0)
                throw new Exception("Nome não pode ser nulo ou vazio");

            if (Tipo == null)
                throw new Exception("Tipo não pode ser nulo");

            if (Validade == null)
                throw new Exception("Data de validade não pode ser nula");
        }
        #endregion

        #region Override
        public override bool Equals(object? obj)
        {
            if (obj is not Remedio) 
                return false;

            if (((Remedio)obj).RemedioID.Equals(RemedioID))
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return 11 * (RemedioID == null ? 1 : RemedioID.GetHashCode());
        }
        #endregion
    }
}
