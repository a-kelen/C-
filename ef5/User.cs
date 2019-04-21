using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef5
{
    class User
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(80)]
        public string Email { get; set; }
        [StringLength(25)]
        public string Password { get; set; }
        public List<PaymentMethod> PaymentMethods { get; set; }
        public User()
        {
            PaymentMethods = new List<PaymentMethod>();
        }
    }
}
