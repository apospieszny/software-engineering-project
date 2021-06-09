﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using RPG.models;

namespace RPG.logic_layer
{
    public class LocationsAdapter
    {
        readonly string PATH = @"";
        readonly EventBuilder eventBuilder;

        public LocationsAdapter(EventBuilder eventBuilder)
        {
            this.eventBuilder = eventBuilder;
        }
        
        public void readData()
        {
            StreamReader file = File.OpenText(PATH);
            Location[] locations = JsonSerializer.Deserialize<Location[]>(file.ReadToEnd());
            eventBuilder.setLocations(locations);
        }
    }
}
