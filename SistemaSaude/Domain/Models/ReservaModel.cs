using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class ReservaModel
    {
        #region Properties
        [Key]
        public Guid? ReservaID { get; private set; }
        [ForeignKey("FK_TB_Remedios_TB_Reservas_ReservaID")]
        public Guid? RemedioID { get; private set; }
        [ForeignKey("FK_TB_Pacientes_TB_Reservas_ReservaID")]
        public Guid? PacienteID { get; private set; }
        public DateTime? DataReserva { get; private set; }
        public virtual Remedio? Remedio { get; private set; }
        public virtual PacienteModel? Paciente { get; private set; }
        #endregion

        #region Constructor
        public ReservaModel(DateTime? dataReserva, Guid? remedioID, Guid? pacienteID)
        {
            DataReserva = dataReserva?.Date;
            RemedioID = remedioID;
            PacienteID = pacienteID;
        }
        #endregion

        #region Methods
        public void GerarID()
        {
            ReservaID = Guid.NewGuid();
        }
        #endregion

        #region Overrides
        public override bool Equals(object? obj)
        {
            if (obj is not ReservaModel)
                return false;

            if (((ReservaModel)obj).ReservaID.Equals(ReservaID))
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return 11 * (ReservaID == null ? 1 : ReservaID.GetHashCode());
        }
        #endregion
    }
}
