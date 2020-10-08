using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace salesforceCodexStore.Models
{

    public class EventBase
    {
        public EventBase()
        {
            OccuredOn = DateTime.Now;
        }

        protected DateTime OccuredOn
        {
            get;
            set;
        }
    }
}
