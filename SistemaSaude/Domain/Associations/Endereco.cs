using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    [Table("TB_Enderecos")]
    public class Endereco
    {
        #region Properties
        public Guid? EnderecoID { get; private set; }
        public string? Rua { get; private set; }
        public string? Numero { get; private set; }
        public string? Bairro { get; private set; }
        public string? Cidade { get; private set; }
        public string? Estado { get; private set; }
        public string? Cep { get; private set; }
        #endregion

        #region Constructor
        public Endereco(string? rua, string? numero, string? bairro, string? cidade, string? estado, string? cep, Guid? enderecoID = null)
        {
            EnderecoID = (enderecoID == null) ? Guid.NewGuid() : enderecoID;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
            ValidateData();
        }
        #endregion

        #region Validations
        void ValidateData()
        {
            if (Rua == null || Rua.Trim().Length == 0)
                throw new Exception("A rua não pode ser nula ou vazia");

            if (Numero == null || Numero.Trim().Length == 0)
                Numero = "Sem número";

            if (Bairro == null || Bairro.Trim().Length == 0)
                throw new Exception("O bairro não pode ser nulo ou vazio");

            if (Cidade == null || Cidade.Trim().Length == 0)
                throw new Exception("A cidade não pode ser nula ou vazia");

            if (Estado == null || Estado.Trim().Length == 0)
                throw new Exception("O estado não pode ser nulo ou vazio");

            if (Cep == null || Cep.Trim().Length == 0)
                throw new Exception("O CEP não pode ser nulo ou vazio");
        }
        #endregion

        #region Overrides
        public override bool Equals(object? obj)
        {
            if (obj is not Endereco) return false;

            if (((Endereco)obj).EnderecoID.Equals(EnderecoID)) return true;

            return false;
        }

        public override int GetHashCode()
        {
            return 11 * (EnderecoID == null ? 1 : EnderecoID.GetHashCode());
        }
        #endregion
    }
}
