﻿using Newtonsoft.Json;

namespace UKFast.API.Client.DDoSX.Models.Request
{
    /// <summary>
    /// Represents a DDoSX IP ACL rule request
    /// </summary>
    public class CreateACLIPRuleRequest
    {
        [JsonProperty("ip", Required = Required.Always)]
        public string IP { get; set; }

        [JsonProperty("uri")]
        public string URI { get; set; }

        [JsonProperty("mode", Required = Required.Always)]
        public string Mode { get; set; }
    }
}