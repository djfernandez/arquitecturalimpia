using CleanArchitecture.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Domain
{
    public class Video : BaseDomainModel
    {
        public Video() 
        {
            Actores = new HashSet<Actor>();
        }

        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }

        public int StreamerId { get; set; }

       public virtual Streamer? Streamer { get; set; }

        public virtual ICollection<Actor> Actores { get; set; }

        public virtual Director Director { get; set; }

    }
}
