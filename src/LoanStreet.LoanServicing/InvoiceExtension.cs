using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections;
using LoanStreet.LoanServicing.Api;

namespace LoanStreet.LoanServicing.Model
{
    public partial class Invoice
    {

        public Money Total
        {
            get
            {
                if (!this.Charges.Any())
                {
                    return new Money(0, currency: "USD");
                }
                
                var currency = this.Charges.First().Amount.Currency;
                var sum = this.Charges.Select(x => x.Amount.Amount).Sum();
                return new Money(sum, currency);
            }
        }
        
    }
}