using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ufasforms.Data
{
    public class Filiere
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(300)]
        public string NomFiliere { get; set; } = string.Empty;

        [ForeignKey("Domaine")]
        public int DomaineId { get; set; }
        public Domaine? Domaine { get; set; }
    }
}