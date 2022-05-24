namespace Domain.Models
{
    public class ReservaModel
    {
        #region Properties
        public Guid? ReservaID { get; private set; }
        public DateTime? DataReserva { get; private set; }
        private HashSet<Remedio>? _remedios;
        #endregion

        #region Constructor
        public ReservaModel(Guid? reservaID = null, HashSet<Remedio>? remedios = null)
        {
            ReservaID = (reservaID == null) ? Guid.NewGuid() : reservaID;
            DataReserva = DateTime.Now;
            _remedios = (remedios == null) ? new HashSet<Remedio>() : remedios;
        }
        #endregion

        #region Methods
        public void adicionarRemedio(Remedio remedio)
        {
            _remedios?.Add(remedio);
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
