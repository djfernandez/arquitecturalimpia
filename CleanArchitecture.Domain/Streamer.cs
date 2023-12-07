using CleanArchitecture.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Domain
{
    public class Streamer : BaseDomainModel
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }

        public string? Url { get; set; }

        public ICollection<Video>? Videos { get; set; }

    }
}
