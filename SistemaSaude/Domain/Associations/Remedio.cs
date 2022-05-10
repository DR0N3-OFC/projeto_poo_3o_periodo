﻿using Domain.Enumerators;

namespace Domain.Models
{
    public class Remedio
    {
        #region Properties
        public Guid? RemedioID { get; private set; }
        public string? Nome { get; private set; }
        public TipoRemedio? Tipo { get; private set; }
        public DateTime? Validade { get; private set; }
        #endregion

        #region Constructor
        public Remedio(string? nome, TipoRemedio? tipo, DateTime? validade, Guid? remedioID = null)
        {
            RemedioID = (remedioID == null) ? Guid.NewGuid() : remedioID;
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

            if (Tipo == null)
                throw new Exception("Tipo não pode ser nulo ou vazio");

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