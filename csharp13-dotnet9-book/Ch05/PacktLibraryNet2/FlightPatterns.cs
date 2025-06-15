namespace Packt.Shared;

public class Passanger
{
    public string? Name { get; set; }
}

public class BusinessClassPassenger : Passanger
{
    public override string ToString() => $"Business class: {Name}";
}

public class FirstClassPassenger : Passanger
{
    public int AirMiles { get; set; }
    public override string ToString() => $"Business class: {Name} with air miles: {AirMiles}";
}

public class CoachClassPassenger : Passanger
{
    public double CarryOnKg { get; set; }
    public override string ToString() => $"class {Name} with {CarryOnKg} kg";
}