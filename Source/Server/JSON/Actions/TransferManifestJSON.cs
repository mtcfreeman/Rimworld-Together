﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer
{
    [Serializable]
    public class TransferManifestJSON
    {
        public string transferStepMode;

        public string transferMode;

        public string fromTile;

        public string toTile;

        public List<string> humanDetailsJSONS = new List<string>();

        public List<string> animalDetailsJSON = new List<string>();

        public List<string> itemDetailsJSONS = new List<string>();
    }
}
