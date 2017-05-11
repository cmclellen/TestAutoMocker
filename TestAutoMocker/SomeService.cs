namespace TestAutoMocker
{
    public class SomeService
    {
        public SomeService(ISomeRepository someRepository, IDependency1 dependency1, IDependency2 dependency2)
        {
            SomeRepository = someRepository;
            Dependency1 = dependency1;
            Dependency2 = dependency2;
        }

        private ISomeRepository SomeRepository { get; set; }
        private IDependency1 Dependency1 { get; set; }
        private IDependency2 Dependency2 { get; set; }

        public string GetSomeString()
        {
            Dependency1.Execute();
            Dependency2.GetAge();
            return SomeRepository.GetSomeString();
        }
    }
}