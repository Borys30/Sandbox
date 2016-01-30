namespace Sandbox.KeyedCollectionExample
{
    public class Player
    { 
        string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (Team != null) Team.Roster.NotifyNameChange(this, value); 
                name = value;
            }
        }

        public int Number;
        public Team Team { get; internal set; }

        public Player(string name, int number)
        {
            Name = name;
            Number = number; 
        }
    }
}
