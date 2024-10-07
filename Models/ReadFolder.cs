namespace PMC;

public class ReadFolder
{
    public (bool Sucesse, string[] Lines, int AmountLines) ReadingFile(string path)
    {

        try
        {
            string[] lines = File.ReadAllLines(path);
            return(true, lines, lines.Count());
        }
        catch(Exception ex)
        {
            return (false, new string[0], 0);
        }

    }
}
