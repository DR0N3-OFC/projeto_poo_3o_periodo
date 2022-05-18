using System.ComponentModel;

namespace Domain.Enumerators
{
    public enum EnumRemedio
    {
        [Description("Antibiótico")]
        Antibiotico,
        [Description("Analgésico")]
        Analgesico,
        [Description("Antiácido")]
        Antiacido,
        [Description("Antidepressivo")]
        Antidepressivo,
        [Description("Antialérgico")]
        Antialergico,
        [Description("Anti-Inflamatório")]
        Antiinflamatorio,
    }

    public enum EnumEspecialidade
    {
        [Description("Neurologia")]
        Neurologia,
        [Description("Cardiologia")]
        Cardiologia,
        [Description("Clínica Geral")]
        Clinicageral,
        [Description("Reumatologia")]
        Reumatologia,
        [Description("Dermatologia")]
        Dermatologia,
        [Description("Ginecologia")]
        Ginecologia,
        [Description("Urologia")]
        Urologia,
        [Description("Geriatria")]
        Geriatria,
        [Description("Oftalmologia")]
        Oftalmologia,
        [Description("Psiquiatria")]
        Psiquiatria,
    }
}
