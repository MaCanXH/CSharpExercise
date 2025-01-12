using System.Collections.Generic;
using System.Diagnostics.Tracing;

class Q6
{
    static void ans()
    {
        timeTable table = new timeTable();
        table.AddEvent("Gundam", 20240920, 20241002);
        table.AddEvent("Gundam2", 20241004, 20241010);
        table.AddEvent("Gundam3", 20241020, 20241101);
        table.AddEvent("Gundam4", 20241015, 20241102);
    }
}

class timeTable
{
    private SortedList<int, string> startTimeList;
    private SortedList<int, string> endTimeList;
    public timeTable()
    {
        this.startTimeList = new SortedList<int, string>();
        this.endTimeList = new SortedList<int, string>();
    }
    public void AddEvent(string eventName, int startTime, int endTime)
    {
        if(checkVacant(startTime, endTime))
        {
            this.startTimeList.Add(startTime, eventName);
            this.endTimeList.Add(endTime, eventName);
        }
        else
        {
            Console.WriteLine("The conference hall is not available.");
        }
    }
    private bool checkVacant(int startTime, int endTime)
    {
        List<string> fromStart =  new List<string>();
        List<string> tillEnd = new List<string>();
        foreach (KeyValuePair<int, string> i in this.startTimeList)
        {
            if(i.Key >= startTime)
            {
                fromStart.Add(i.Value);
            }
        }
        foreach (KeyValuePair<int, string> i in this.endTimeList)
        {
            if(i.Key <= endTime)
            {
                tillEnd.Add(i.Value);
            }
        }
        foreach(string e in fromStart)
        {
            if(tillEnd.Contains(e))
            {
                return false;
            }
        }
        return true;
    }
}