using System.Collections.ObjectModel;

namespace Sandbox.KeyedCollectionExample
{
    public class Roster : KeyedCollection<string, Player>
    {
        Team team;

        public Roster(Team team)
        {
            this.team = team;
        }

        internal void NotifyNameChange(Player player, string newName)
        {
            ChangeItemKey(player, newName);
        }

        protected override string GetKeyForItem(Player item)
        {
            return item.Name; 
        }

        protected override void InsertItem(int index, Player item)
        {
            base.InsertItem(index, item);
            item.Team = team;
        }

        protected override void SetItem(int index, Player item)
        {
            base.SetItem(index, item);
            item.Team = team; 
        }

        protected override void RemoveItem(int index)
        {
            this[index].Team = null; 
            base.RemoveItem(index); 
        }
        protected override void ClearItems()
        {
            foreach (var player in this) player.Team = null; 
            base.ClearItems();
        }
    }
}