interface IAccount
{
    void Deposit();
    void Withdraw();

}
class Saving : IAccount
{
    public void Deposit()
    {
        throw new NotImplementedException();
    }

    public void Withdraw()
    {
        throw new NotImplementedException();
    }
}
class Current : IAccount
{
    public void Deposit()
    {
        throw new NotImplementedException();
    }

    public void Withdraw()
    {
        throw new NotImplementedException();
    }
}
