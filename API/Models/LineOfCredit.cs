namespace API.Models;

public class LineOfCredit
{
    private decimal _Balance;

    public string Provider { get; set; }

    public decimal Balance { get { return _Balance; } set { if (value < 0) { _Balance = 0; } else { _Balance = value; } } }
}