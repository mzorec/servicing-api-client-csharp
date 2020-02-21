using System;
using LoanStreet.LoanServicing.Model;

namespace LoanStreet.LoanServicing
{

    public static class Extensions
    {

        public static Decimal ToDecimal(this Money o)
        {
            Decimal.TryParse(o.Amount, out Decimal res);
            return res;
        }

    }
}