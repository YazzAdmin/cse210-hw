using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Programmer";
        job1._company = "Google";
        job1._startYear =2020;
        job1._endYear =2022;

        Job job2 = new Job();
        job2._jobTitle = "Analyst";
        job2._company = "Intel";
        job2._startYear =2022;
        job2._endYear =2023;

        Resume myResume = new Resume();
        myResume._name = "Yazmin Cuevas";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}