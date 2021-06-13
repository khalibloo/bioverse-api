using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;

namespace Bioverse.Models
{
    public class Family
    {
        [SwaggerSchema("The family identifier", ReadOnly = true)]
        public int Id { get; set; }

        [Required]
        [SwaggerSchema("The name of the family")]
        public string Name { get; set; }

        [SwaggerSchema("The family description")]
        public string Description { get; set; }

        [SwaggerSchema("The species in this family", ReadOnly = true)]
        public List<Species> Species { get; set; }
    }
}
