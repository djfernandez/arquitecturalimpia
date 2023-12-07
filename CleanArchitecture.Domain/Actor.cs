
using CleanArchitecture.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Domain
{
    public class Actor : BaseDomainModel
    {
        public Actor() { 
            Videos = new HashSet<Video>();
        }

        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }

        public string? Apellido { get; set; }

        public virtual ICollection<Video> Videos { get; set; }

    }
}
