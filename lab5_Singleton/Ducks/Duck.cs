namespace lab5_Singleton.Ducks
{
    abstract class Duck
    {
        public string Name { get; }

        public Duck(string name)
        {
            Name = name;
        }
    }
}
