
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class PacienteModel : PessoaModel
    {
        #region Properties
        [Key]
        public Guid? PacienteModelID { get; private set; }
        public Endereco? Endereco { get; private set; }
        public virtual IList<Consulta>? Consultas { get; private set; }
        #endregion

        #region Constructor
        public PacienteModel (string? email, string? senha, string? nome, DateTime? dataDeNascimento, string? telefone, string? cpf, string? rg) : base()
        {
            Email = email;
            Senha = senha;
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Telefone = telefone;
            Cpf = cpf;
            Rg = rg;
            ValidateData();
        }
        #endregion

        #region Methods
        public void GerarID()
        {
            PacienteModelID = Guid.NewGuid();
        }
        #endregion

        #region Overrides
        public override bool Equals(object? obj)
        {
            if (obj is not PacienteModel) return false;

            if (((PacienteModel)obj).PacienteModelID.Equals(PacienteModelID)) return true;

            return false;
        }

        public override int GetHashCode()
        {
            return 11 * (PacienteModelID == null ? 1 : PacienteModelID.GetHashCode());
        }

        public override string ToString()
        {
            return $"{Nome}, {Idade} anos";
        }
        #endregion
    }
}
