using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    [Table("TB_Consultas")]
    public class Consulta
    {
        #region Properties

        public Guid? ConsultaID { get; private set; }
        public DateTime? Data { get; private set; }
        public string? Especialidade { get; private set; }
        public string? Medico { get; private set; }
        #endregion

        #region Constructor
        public Consulta(DateTime? data, string? especialidade, string? medico, Guid? consultaID = null)
        {
            ConsultaID = (consultaID == null) ? Guid.NewGuid() : consultaID;
            Data = data;
            Especialidade = especialidade;
            Medico = medico;
            ValidateData();
        }
        #endregion

        #region Validations
        void ValidateData()
        {
            if (Data == null)
                throw new Exception("Data e hora não podem ser nulas");

            if (Especialidade == null || Especialidade.Trim().Length == 0)
                throw new Exception("Especialidade não pode ser nula ou vazia");

            if (Medico == null || Medico.Trim().Length == 0)
                throw new Exception("Nome do médico não pode ser nulo ou vazio");
        }
        #endregion

        #region Overrides
        public override bool Equals(object? obj)
        {
            if (obj is not Consulta) return false;

            if (((Consulta)obj).ConsultaID.Equals(ConsultaID)) return true;

            return false;
        }

        public override int GetHashCode()
        {
            return 11 * (ConsultaID == null ? 1 : ConsultaID.GetHashCode());
        }
        #endregion
    }
}
