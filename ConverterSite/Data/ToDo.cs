namespace ConverterSite.Data;

public class Todo
{
    public int Id;
    public string? Title { get; set; }
    public bool IsDone { get; set; } //property
}

//check date and return day schedule, the current timeblock needs to be highlighted