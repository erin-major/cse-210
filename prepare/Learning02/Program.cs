using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();

        job1._company = "Filevine";
        job1._jobTitle = "QA Analyst 1";
        job1._startYear = 2021;
        job1._endYear = 2024;

        // job1.DisplayJobDetails();

        job2._company = "Amazon";
        job2._jobTitle = "Associate";
        job2._startYear = 2020;
        job2._endYear = 2021;

        // job2.DisplayJobDetails();

        Resume resume = new Resume();
    
        resume._name = "Erin Major";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResumeDetails();
        

    }
}