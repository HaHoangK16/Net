namespace LinqAndArrayList
{
    public class Staff
    {
        public int ID {get;set;}
        public string Name {get;set;}
        public int Age {get;set;}

        public Staff(int _ID , string _Name,int _Age)
        {
            ID = _ID;
            Name = _Name;
            Age = _Age;
        }
    }
}