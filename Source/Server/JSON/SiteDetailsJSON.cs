﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer
{
    [Serializable]
    public class SiteDetailsJSON
    {
        public string siteStep;

        public string tile;

        public string type;

        public string owner;

        public string workerData;

        public string likelihood;

        public bool isFromFaction;

        public List<string> sitesWithRewards = new List<string>();
    }
}
