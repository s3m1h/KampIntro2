

IWorker[] workers = new IWorker[]
{
    new Manager(),
    new Robot(),
    new Worker()
};
foreach (var worker in workers)
{
    worker.Work();
}
// SOLID, interface segregation 
// çoklu implamentasyon
interface IWorker
{
    void Work();

}
interface IEat
{
    void Eat();
}
interface ISallary
{
    void GetSallary();
}
class Manager : IWorker, IEat, ISallary
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void GetSallary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}
class Worker : IWorker, ISallary, IEat
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void GetSallary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}
class Robot : IWorker
{
    public void Work()
    {
        throw new NotImplementedException();
    }
}

