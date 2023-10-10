using System;

public class Journal
{
    public List<Entry> _listEntries = new List<Entry>();
    
    public void AddEntry()  
    {
        List<string> promptList = new List<string>(){
            "What am I thankful for today?", "What new thing did I learn today?", "Did I compliment someone today?",
            "What is something I am proud of today?", "id I help my work members?","Do I need to apologize to someone?",
            "Did I contact my family members?", "Is there something new I want to learn?", "How many times did I drink water today?",
            "Did I eat healthy today?", "Did I take time to read today?"
        };
        
        Random  randomGenerator = new Random();
        int i = randomGenerator.Next(promptList.Count);
        string question = promptList[i];
        Console.WriteLine(question);

        DateTime theCurrentTime = DateTime.Now;
        string saveDate = theCurrentTime.ToShortDateString();

        Entry answeredQuestion = new Entry(); 
        answeredQuestion._insertDate = saveDate;
        answeredQuestion._promptGenertn = question;
        answeredQuestion._entry = Console.ReadLine();
        
        _listEntries.Add(answeredQuestion);
    }
    public void Display()
    {

        foreach (Entry entry in _listEntries)
        {
            entry.ViewEntry();
        }
    }
    public void LoadFile() 
    {

    }
    public void SaveFile() 
    {

    }
}