using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;

namespace Bioverse.Models
{
    public class Species
    {
        [SwaggerSchema("The species identifier", ReadOnly = true)]
        public int Id { get; set; }

        [Required]
        [SwaggerSchema("The name of the species")]
        public string Name { get; set; }

        [SwaggerSchema("The species description")]
        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public int FamilyId { get; set; }
        public Family Family { get; set; }
    }
}
