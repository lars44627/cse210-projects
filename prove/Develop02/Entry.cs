//First Class: Entry info stored
public class Entry
{
    public string _Content;
    public string _Date;
    public string _Prompt;
    public string FormatEntry()
    {
         return ($"Date:{_Date}, Prompt:{_Prompt}, Entry:{_Content}");
    }
}