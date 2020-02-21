namespace LoanStreet.LoanServicing.Model
{

    /// <summary>
    /// Facility
    /// </summary>
    /// 
    /// <remarks>
    /// A Facility can have one or more Tranches. Lender and Co-Lender Ownership
    /// is recorded at the Tranche level. Invoices are created at the Tranche
    /// level by summing the Borrowing payments due for each Borrowing.
    /// </remarks>
    public partial class Facility
    {
        
    }

    /// <summary>
    /// Tranche
    /// </summary>
    /// 
    /// <remarks>
    /// A Tranche can have one or more Borrowings. Interest elections are managed at this
    /// level. Interest is calculated at this level.
    /// </remarks>
    public partial class Tranche
    {
        
    }

    /// <summary>
    /// Invoice
    /// </summary>
    /// 
    /// <remarks>
    /// A list of the principal, interest, fees and expenses charged against the
    /// tranche to the Borrower for a date period.
    /// </remarks>
    public partial class Invoice
    {
        
    }

    /// <summary>
    /// Payment
    /// </summary>
    /// 
    /// <remarks>
    /// An amount that is credited to the tranche balance owed by the Borrower.
    /// </remarks>
    public partial class Payment
    {
        
    }
    
}