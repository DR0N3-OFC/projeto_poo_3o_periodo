﻿namespace Domain.Models
{
    public class PessoaModel : UsuarioModel
    {
        #region Properties
        public string? Nome { get; private set; }
        public DateTime? DataDeNascimento { get; private set; }
        public string? DataDeNascimentoTratada { get
            {
                return DataDeNascimento?.ToShortDateString();
            } 
        }
        public int? Idade { get 
            {
                TimeSpan? timeSpan = (DateTime.Now - DataDeNascimento);
                return timeSpan?.Days / 365; 
            } 
        }
        public string? Sexo { get; private set; }
        public string? Telefone { get; private set; }
        public string? Rg { get; private set; }
        public string? Cpf { get; private set; }
        public string? EmailPub { get { return Email; } }
        public string? SenhaPub { get { return Senha; } }
        #endregion

        #region Constructor
        public PessoaModel
            (string? email, string? senha, string? nome, DateTime? dataDeNascimento, 
             string? sexo, string? telefone, string? rg, string? cpf)
        {
            Email = email;
            Senha = senha;
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Telefone = telefone;
            Rg = rg;
            Cpf = cpf;
            validateData();
        }
        #endregion

        #region Accessors Methods
        public void ChangePhone(string? telefone)
        {
            Telefone = telefone;
            validateData();
        }
        public void ChangeSex(string? sexo)
        {
            Sexo = sexo;
            validateData();
        }
        #endregion

        #region Validations
        void validateData()
        {
            if (Email == null || Email.Trim().Length == 0)
                throw new Exception("O e-mail não pode ser nulo ou vazio");

            if (Senha == null || Senha.Trim().Length == 0)
                throw new Exception("A senha não pode ser nula ou vazia");

            if (Nome == null || Nome.Trim().Length == 0)
                throw new Exception("O nome não pode ser nulo ou vazio");

            if (DataDeNascimento == null)
                throw new Exception("A data de nascimento não pode ser nula ou vazia");

            if (Sexo == null || Sexo.Trim().Length == 0)
                Sexo = "Não informado";

            if (Telefone == null || Telefone.Trim().Length == 0)
                Telefone = "Não informado";

            if (Rg == null || Rg.Trim().Length == 0)
                throw new Exception("O RG não pode ser nulo ou vazio");

            if (Cpf == null || Cpf.Trim().Length == 0)
                throw new Exception("O CPF não pode ser nulo ou vazio");
        }
        #endregion
    }
}
