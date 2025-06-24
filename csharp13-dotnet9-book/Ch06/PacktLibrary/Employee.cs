namespace Packt.Shared;

public class Employee : Person
{
    public string? EmployeeCode { get; set; }
    public DateOnly HireDate { get; set; }
    
    public new void WriteToConsole()
    {
        WriteLine(format:
            "{0} was born on {1:dd/MM/yy} and hired on {2:dd/MM/yy}.",
            arg0: Name, arg1: Born, arg2: HireDate);
    }
    
    #region Overridden methods
    public override string ToString()
    {
        return $"{Name} is a {base.ToString()}.";
    }
    #endregion
}