
using CleanArchitecture.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Domain
{
    public class Director : BaseDomainModel
    {
        public Director()
        {
        }

        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }

        public string? Apellido { get; set; }

        public int VideoId { get; set; }

        public virtual Video? Video { get; set; }

    }
}
