using Domain.Enumerators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class Consulta
    {
        #region Properties

        [Key]
        public Guid? ConsultaID { get; private set; }
        [ForeignKey("FK_TB_Pacientes_TB_Consultas_ConsultaID")]
        public Guid? PacienteModelID { get; private set; }
        [ForeignKey("FK_TB_Medicos_TB_Consultas_ConsultaID")]
        public Guid? MedicoModelID { get; private set; }
        public virtual PacienteModel? Paciente { get; private set; }
        public virtual MedicoModel? Medico { get; private set; }
        public DateTime? Data { get; private set; }
        #endregion

        #region Constructors
        public Consulta(DateTime? data, Guid? pacienteModelID, Guid? medicoModelID)
        {
            Data = data;
            PacienteModelID = pacienteModelID;
            MedicoModelID = medicoModelID;
            ValidateData();
        }
        #endregion

        #region Methods
        public void GerarID()
        {
            ConsultaID = Guid.NewGuid();
        }
        #endregion

        #region Validations
        void ValidateData()
        {
            if (Data == null)
                throw new Exception("Data e hora não podem ser nulas");
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
