using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ufasforms.Data
{
    public class Domaine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(300)]
        public string NomDomaine { get; set; } = string.Empty;

        [ForeignKey("Faculte")]
        public int FaculteId { get; set; }
        public Faculte? Faculte { get; set; }
    }
}