//contains the text of the scripture and makes it look nice     ID 5 is the ID
public class Scripture
{
    private string _scripture = "And God called the light Day, and the darkness he called Night. And the evening and the morning were the first day.";

    public void Display(Reference reference)
    {
        string output = reference.getReference() + "\n" + _scripture;
        Console.WriteLine(output);
    }

    public string scriptureString()
    {
        return _scripture;
    }
}



// The scripture is Genesis 1:5 for reference. That is the reference we want to return.