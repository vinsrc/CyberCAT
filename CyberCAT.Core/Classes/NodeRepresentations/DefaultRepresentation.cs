﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    [JsonObject]
    public class DefaultRepresentation
    {
        public byte[] HeaderBlob { get; set; }
        public byte[] TrailingBlob { get; set; }
    }
}
