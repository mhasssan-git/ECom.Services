namespace CommonService.Settings;

public class MySqlSettings
{
    public string Server { get; set; }
    public string Port { get; init; }
    public string Database { get; init; }
    public string UserName { get; init; }
    public string Password { get; init; }
    public string ConvertZeroDateTime { get; init; }
    public string ConnectionTimeout { get; init; }

    public string ConnectionString => $"server={Server}; port={Port}; database={Database}; user={UserName}; password={Password}; Persist Security Info=False;convert zero datetime={ConvertZeroDateTime}; Connect Timeout={ConnectionTimeout}";
}