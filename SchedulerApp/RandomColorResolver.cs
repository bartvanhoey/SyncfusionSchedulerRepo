namespace SchedulerApp;

public static class RandomColorResolver
{

    private static readonly Random Random = new();

    public static Color GetRandomColor()
    {
        var rgb = new byte[3];
        Random.NextBytes(rgb);
        return Color.FromRgb(rgb[0], rgb[1], rgb[2]);
    }
    
    
}