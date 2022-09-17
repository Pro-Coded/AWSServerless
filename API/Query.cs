using static System.Runtime.InteropServices.RuntimeInformation;

public class Query {
  public SysInfo SystemInfo =>
        new()
        {
            OSDescription = OSDescription,
            OSArchitecture = OSArchitecture.ToString(),
            FrameworkDescription = FrameworkDescription,
            ProcessArchitecture = ProcessArchitecture.ToString()
        };
}

public class SysInfo
{
    public string? FrameworkDescription { get; set; }
    public string? RuntimeIdentifier { get; set; }
    public string? OSDescription { get; internal set; }
    public string? OSArchitecture { get; internal set; }
    public string? ProcessArchitecture { get; internal set; }
}