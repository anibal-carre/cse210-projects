using System;
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job
        {
            _jobTitle = "Telemarketing Agent",
            _company = "Atento Brazil",
            _startYear = 2023,
            _endYear = 2024
        };

        Job job2 = new Job
        {
            _jobTitle = "Content Moderator",
            _company = "Facebook",
            _startYear = 2024,
            _endYear = 2025
        };

        Resume myResume = new Resume
        {
            _name = "Anibal David",
            _jobs = []
        };

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}