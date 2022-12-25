Test test = new();

class Test
{
    public Test()
    {
        test(5);
    }
    void test()
    {

    }

    void test(int num)
    {

    }
}

interface ICalculate
{
    void Sum();
    virtual void Sum2()
    {

    }
}

class B : ICalculate
{
    public void Sum()
    {
        throw new NotImplementedException();
    }

    public void Sum2()
    {
        throw new NotImplementedException();
    }
}

class A : ICalculate
{
    public void Sum()
    {
        throw new NotImplementedException();
    }

    public void Sum2()
    {
        throw new NotImplementedException();
    }
}