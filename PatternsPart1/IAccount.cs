namespace PatternsPart1
{
    public interface IAccount
    {
        double Balance { get; set; }
        double Interest { get; set; }
        string Type { get; set; }
    }
}