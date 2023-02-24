//contains the text of the scripture and makes it look nice  
// Austin Reeves
public class Scripture
{
    private string _scripture;

    public Scripture(string reference)
    {
        // Open the CSV file
        using (StreamReader sr = new StreamReader("lds-scripture-2020.12.08/csv"))
        {
            string line;
            // Read each line of the file
            while ((line = sr.ReadLine()) != null)
            {
                // Split the line into fields
                string[] fields = line.Split(',');

                // Check if the reference matches
                if (fields[0] == reference)
                {
                    // Set the scripture text
                    _scripture = fields[1];
                    break;
                }
            }
        }
    }

    public void Display()
    {
    
    }

    public string scriptureString()
    {
        return _scripture;
    }
}




// The scripture is Genesis 1:5 for reference. That is the reference we want to return.