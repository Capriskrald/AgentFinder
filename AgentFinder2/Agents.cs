﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgentAssignment;

namespace AgentFinder2
{
    class Agents : ObservableCollection<Agent>
    {
        public Agents()
        {
            Add(new Agent("007", "James Bond", "Murder", "Assinate the pope"));
            Add(new Agent("021", "Morten Hansen", "Hacking", "Hack the Pentagon"));
        }
    }
}
