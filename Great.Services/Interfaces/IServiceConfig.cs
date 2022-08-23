using Config.Net;

public interface IServiceConfig
{
    [Option(DefaultValue = true)]
    bool IsGreat { get; }

    [Option(DefaultValue = "Myself")]
    string ShoutOutsTo { get; }

}