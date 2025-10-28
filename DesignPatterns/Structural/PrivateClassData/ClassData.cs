namespace DesignPatterns.Structural.PrivateClassData
{
    internal class ClassData
    {
        //private readonly string _someString;
        //public int SomeInt { get; }

        private PrivateData _privateData;

        public ClassData(string someString, int someInt)
        {
            //_someString = someString;
            //SomeInt = someInt;
            _privateData = new PrivateData(someString, someInt);
        }

        public void DoSth()
        {

            //_someString = "";
            //SomeInt = 0;

            _privateData.GetSomeString();
            _privateData.GetSomeInt();
        }
    }
}
