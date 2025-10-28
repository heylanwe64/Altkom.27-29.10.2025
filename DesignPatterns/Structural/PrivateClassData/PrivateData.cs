namespace DesignPatterns.Structural.PrivateClassData
{
    internal class PrivateData
    {
        private string _someString;
        private int _someInt;

        public PrivateData(string someString, int someInt)
        {
            _someString = someString;
            _someInt = someInt;
        }

        public string GetSomeString()
        {
            return _someString;
        }

        public int GetSomeInt()
        {
            return _someInt;
        }
    }
}
