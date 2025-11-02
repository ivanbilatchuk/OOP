using System.Collections;

namespace Task3;

public class JobList : IEnumerable<Job>
{
    private List<Job> jobs = new List<Job>();

    public void Add(Job job)
    {
        jobs.Add(job);
        job.JobDone += OnJobDone;
    }

    private void OnJobDone(object sender, EventArgs e)
    {
        jobs.Remove((Job)sender);
    }

    public IEnumerator<Job> GetEnumerator()
    {
        return jobs.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}