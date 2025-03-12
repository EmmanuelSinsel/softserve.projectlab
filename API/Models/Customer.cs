namespace API.Models;

public class Customer
{
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public DateOnly BirthDate { get; set; }
    
    public string Email { get; set; }
    
    public LineOfCredit? LineOfCredit { get; set; }
    
}

public class VIPCustomer : Customer
{

    public string Address { get; set; }

    public string RFC { get; set; }

    public string Phone { get; set; }

    public LineOfCredit? AdditionalLineOfCredit { get; set; } // Because we offer to our VIP customers an extra credit line as a benefit for its loyalty!

}