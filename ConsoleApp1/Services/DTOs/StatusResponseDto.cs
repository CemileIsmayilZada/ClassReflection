namespace Services.DTOs;

public class StatusResponseDto
{
    public string Title { get; set; }
    public string Content { get; set; }

    public override string ToString()
    {
        return $"Title: {Title} Content : {Content}";
    }

}
