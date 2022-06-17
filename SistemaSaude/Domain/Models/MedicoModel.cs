using Domain.Enumerators;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class MedicoModel : PessoaModel
    {
        #region Properties
        [Key]
        public Guid? MedicoModelID { get; private set; }
        public EnumEspecialidade? Especialidade { get; private set; }
        public string? Crm { get; private set; }
        public virtual IList<Consulta>? Consultas { get; private set; }
        #endregion

        #region Constructor
        public MedicoModel
            (string? email, string? senha, string? nome, DateTime? dataDeNascimento, string? telefone, EnumEspecialidade? especialidade, string? crm, string? cpf, string? rg) : base()
        {
            Email = email;
            Senha = senha;
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Telefone = telefone;
            Especialidade = especialidade;
            Crm = crm;
            Cpf = cpf;
            Rg = rg;
            ValidateData();
            ValidateDataMedico();
        }
        #endregion

        #region Methods
        public void GerarID()
        {
            MedicoModelID = Guid.NewGuid();
        }
        #endregion

        #region Validations
        void ValidateDataMedico()
        {
            if (Especialidade == null)
                throw new Exception("A especialidade não pode ser nula ou vazia");

            if (Crm == null || Crm.Trim().Length == 0)
                throw new Exception("O CRM não pode ser nulo ou vazio");
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return $"{Nome}, {Especialidade.GetDescription()}";
        }

        #endregion
    }
}
