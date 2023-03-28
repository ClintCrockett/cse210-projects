class Program
{
    static void Main(string[] args)
    {
        Lectures lecture = new Lectures();
        lecture.getStandardDetails();
        lecture.getFullDetails();
        lecture.getShortDescription();

        Console.WriteLine("");

        Receptions reception = new Receptions();
        reception.getStandardDetails();
        reception.getFullDetails();
        reception.getShortDescription();

        Console.WriteLine("");

        OutdoorGatherings outdoorGathering = new OutdoorGatherings();
        outdoorGathering.getStandardDetails();
        outdoorGathering.getFullDetails();
        outdoorGathering.getShortDescription();
    }

}

