class Ch11Q4
{
	    static void ans()
        {
	        Console.Write("The time has passed since the computer started is ");
            Console.WriteLine(Environment.TickCount/1000/60/60/24 + " days " + 
            Environment.TickCount/1000/60/60%24 + " hours " + 
            (Environment.TickCount/1000/60%60) + " minutes. ");
        }
}