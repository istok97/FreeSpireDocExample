using Spire.Doc;

public class Program
{
    public static void Main()
    {
        var document = new Document();

        string docPath = @"C:\example";
        document.LoadFromFile(Path.Combine(docPath, "example.docx"));
        document.SaveToFile(Path.Combine(docPath, "example.pdf"), FileFormat.PDF);
    }
}