using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TestApiJWT.Models;

namespace Wallet.Models
{
    public class ClientBalance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double Value { get; set; }
        public string Currency { get; set; }

        //Relationships
        public string ClientId { get; set; }

        [ForeignKey("ClientId")]
        public ApplicationUser Client { get; set; }
    }
}
