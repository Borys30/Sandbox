using System;

namespace Sandbox
{
    public class License
    {
        private readonly DateTime _expiry;  
        public License(DateTime dateTime)
        {
            _expiry = dateTime;
        }

        public bool HasExpired
        {
            get { return DateTime.Now > _expiry; }
        }
    }
}
