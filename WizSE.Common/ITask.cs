
using System.Threading.Tasks;

public abstract class ITask
{
    private Task mTask;

    public string Name { get; set; }

    public void Start()
    {
        mTask = new Task(Run);
        mTask.Start();

    }

    public abstract void Run();


    public bool IsCanceled()
    {
        return mTask.IsCanceled;
    
    }


    public void Stop()
    {
        mTask.Dispose();
    }

    


}