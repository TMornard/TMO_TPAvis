using System.ComponentModel.DataAnnotations;


namespace TPLOCAL1.Models
{
    public class Formulaire
    {
        [Required]
        [Display(Name = "Nom")]
        [RegularExpression(@".+", ErrorMessage = "Paramètre \"Nom\" requis")]
        public string? Nom        { get; set; }

        [Required]
        [Display(Name = "Prenom")]
        [RegularExpression(@".+", ErrorMessage = "Paramètre \"Prénom\" requis")]
        public string? Prenom     { get; set; }

        [Required]
        [Display(Name = "Sexe")]
        [RegularExpression(@"^Homme$|^Femme$|^Autre$", ErrorMessage = "Paramètre \"Sexe\" requis")]
        public string? Sexe       { get; set; }

        [Required]
        [Display(Name = "Adresse")]
        [RegularExpression(@".+", ErrorMessage = "Paramètre \"Adresse\" requis")]
        public string? Adresse    { get; set; }

        [Required]
        [Display(Name = "Code")]
        [RegularExpression(@"[0-9]{5}", ErrorMessage = "Code postal erroné. Format attendu : 5 chiffres consécutifs")]
        public string? Code       { get; set; }

        [Required]
        [Display(Name = "Ville")]
        [RegularExpression(@".+", ErrorMessage = "Paramètre \"Ville\" requis")]
        public string? Ville      { get; set; }

        [Required]
        [Display(Name = "Mail")]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Format adresse mail non-conforme. Exemple de format attendu : boitemail@entrprise.dom")]
        public string? Mail       { get; set; }

        [Required]
        [Display(Name = "DateDebut")]
        [RegularExpression(@".+", ErrorMessage = "Paramètre \"Date de début de formation\" requis")]
        public string? DateDebut  { get; set; }

        [Required]
        [Display(Name = "Formation")]
        [RegularExpression(@"^COBOL$|^CSharp$|^Autre$", ErrorMessage = "Paramètre \"Formation\" requis")]
        public string? Formation  { get; set; }

        
        [Display(Name = "AvisCOBOL")]
        [RegularExpression(@".+", ErrorMessage = "Paramètre \"Avis COBOL\" requis")]
        public string? AvisCOBOL  { get; set; }

        
        [Display(Name = "AvisC#")]
        [RegularExpression(@".+", ErrorMessage = "Paramètre \"Avis C#\" requis")]
        public string? AvisCSharp { get; set; }

    }
}
