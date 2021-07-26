using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;

namespace Bioverse.Models
{
    public class IPRange
    {
        public int Id { get; set; }

        [Required]
        public string Range { get; set; }

        public int FirewallRuleId { get; set; }
        public FirewallRule FirewallRule {get; set; }
    }
}
