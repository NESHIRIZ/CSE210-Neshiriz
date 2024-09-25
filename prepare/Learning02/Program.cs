using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Mining Survayor";
        job1._company = "Mimosa";
        job1._startYear = 2026;
        job1._endYear = 2029;

        Job job2 = new Job();
        job2._jobTitle = "SoLar Panels field land planer";
        job2._company = "ZimPLANTS";
        job2._startYear = 2026;
        job2._endYear = 2030;

        Resume myResume = new Resume();
        myResume._name = "Tafadzwa Sibanda";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}