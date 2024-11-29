namespace Domain.Data.Config;

public class DbConnection
{
    public const string Position = "DbConnection";
    
    public required string ConnectionString { get; set; }
}