using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ufasforms.Data
{
    public class Specialite
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(300)]
        public string NomSpecialite { get; set; } = string.Empty;

        [ForeignKey("Filiere")]
        public int FiliereId { get; set; }
        public Filiere? Filiere { get; set; }
    }
}