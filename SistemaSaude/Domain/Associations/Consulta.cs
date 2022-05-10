namespace Domain.Models
{
    public class Consulta
    {
        #region Properties
        public DateTime? Data { get; private set; }
        public string? Especialidade { get; private set; }
        public string? Medico { get; private set; }
        #endregion

        #region Constructor
        public Consulta(DateTime? data, string? especialidade, string? medico)
        {
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
    }
}
