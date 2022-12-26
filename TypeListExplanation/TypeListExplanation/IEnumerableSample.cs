namespace TypeListExplanation;

public class IEnumerableSample
{
    public static IEnumerable<string> GetStudents()
    {
        yield return "Carlos";
        yield return "Natasha";
        yield return "Maria";
    }
}