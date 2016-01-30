namespace Sandbox.KeyedCollectionExample
{
    public class Team
    {
        public readonly Roster Roster;

        public Team()
        { 
            Roster = new Roster(this);
        }
    }
}