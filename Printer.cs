using System.Text;

namespace knightmoves;

public class Printer{
    
    public string Print(string dateString){
        DateTime now = DateTime.Now;
        Display($"Now: {now}");

        string DataString = "2024-06-01T12:00:00";
        DateTime date = DateTime.Parse(dateString);
        Display($"Parsed Date: {date}");

        int year = date.Year;
        Display($"Parsed Year: {year}");

        return "";
    }
}