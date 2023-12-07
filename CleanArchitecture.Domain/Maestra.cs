using CleanArchitecture.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Domain
{
    public class Maestra : BaseDomainModel
    {
        [Key]
        public int IdMaestra { get; set; }
        public int IdUsuario { get; set; }
        public int IdEmpresa { get; set; }
        public string? DsMaestra { get; set; }
    }
}
