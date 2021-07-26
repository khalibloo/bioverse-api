using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;

namespace Bioverse.Models
{
    public class FirewallRule
    {
        public int Id { get; set; }

        [Required]
        public string Action { get; set; }

        [Required]
        public int Port { get; set; }

        [Required]
        public List<IPRange> IPRange { get; set; }

        public string Description { get; set; }
    }
}
