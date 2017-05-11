namespace TestAutoMocker
{
    public interface ISomeRepository
    {
        string GetSomeString();
    }

    public class SomeRepository : ISomeRepository
    {
        public string GetSomeString()
        {
            return "SOME STRING";
        }
    }
}