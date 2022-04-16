namespace Matricula.Domain.Models
{
    public class UsuarioModel
    {
        #region Constants
        const int MAX_NOTIFICATIONS = 10;
        #endregion

        #region Private Fields
        private string[] _notifications = new string[MAX_NOTIFICATIONS];
        private int _notificationsCount = 0;
        #endregion

        #region Properties
        public string? Nome { get; private set; }
        public string? Email { get; private set; }
        public string? Login { get; private set; }
        public string? Senha { get; private set; }
        public string? DataCadastro { get 
            {
                string dataCadastro = DateTime.Now.ToShortDateString();
                return dataCadastro;
            } 
        }
        public int  NotificationsCount { get { return _notificationsCount; } }
        public string[] Notifications { get { return _notifications; } }
        public bool IsValid { get { return _notificationsCount == 0; } }
        #endregion

        #region Constructors
        public UsuarioModel(string? nome, string? email, string? login, string? senha)
        {
            Nome = nome;
            Email = email;
            Login = login;
            Senha = senha;
            applyValidations();
        }
        #endregion

        #region Accessors Methods
        public void ChangeName(string? nome)
        {
            Nome = nome;
            applyValidations();
        }
        #endregion

        #region Apply Validations Methods
        private void applyValidations()
        {
            if (Nome == null || Nome.Trim().Length == 0)
                addNotification("O nome não pode ser nulo");
            if (Email == null || Email.Trim().Length == 0)
                addNotification("O email não pode ser nulo");
            if (Login == null || Login.Trim().Length == 0)
                addNotification("O login não pode ser nulo");
            if (Senha == null || Senha.Trim().Length == 0)
                addNotification("A senha não pode ser nula");
        }

        private void addNotification(string notification)
        {
            if (_notificationsCount == MAX_NOTIFICATIONS) throw new Exception("Limite excedido de notificações");
            _notifications[_notificationsCount++] = notification;
        }
        #endregion
    }
}
