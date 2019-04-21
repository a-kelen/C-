using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef5
{
    class PaymentMethod
    {
        [Key]
        public int Id { get; set; }
        public int BankAccountId { get; set; }
        public BankAccount BankAccount { get; set; }
        public int CreditCardId { get; set; }
        public CreditCard CreditCard { get; set; }

    }
    enum Type
    {
        BankAccount
    }
}
