class Program
{
    static void Main(string[] args)
    {

        List<Activity> _activities = new List<Activity>(){

            new Cycling(),
            new Running(),
            new Swimming(),

        };

        foreach (Activity x in _activities)
        {

            x.getSummary();
        }

    }
}
