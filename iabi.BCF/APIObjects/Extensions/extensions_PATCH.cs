﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace iabi.BCF.APIObjects.Extensions
{
    [JsonObject(Title = "extensions")]
    public class extensions_PATCH : extensions_Base
    {
        private List<string> _priority;

        private List<string> _snippet_type;

        private List<string> _topic_label;

        private List<string> _topic_status;
        private List<string> _topic_type;

        private List<string> _user_id_type;

        [JsonProperty(Required = Required.Default, DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "topic_type")]
        public override List<string> topic_type
        {
            get { return _topic_type ?? (_topic_type = new List<string>()); }
            set { _topic_type = value; }
        }

        [JsonProperty(Required = Required.Default, DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "topic_status")]
        public override List<string> topic_status
        {
            get { return _topic_status ?? (_topic_status = new List<string>()); }
            set { _topic_status = value; }
        }

        [JsonProperty(Required = Required.Default, DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "topic_label")]
        public override List<string> topic_label
        {
            get { return _topic_label ?? (_topic_label = new List<string>()); }
            set { _topic_label = value; }
        }

        [JsonProperty(Required = Required.Default, DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "snippet_type")]
        public override List<string> snippet_type
        {
            get { return _snippet_type ?? (_snippet_type = new List<string>()); }
            set { _snippet_type = value; }
        }

        [JsonProperty(Required = Required.Default, DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "priority")]
        public override List<string> priority
        {
            get { return _priority ?? (_priority = new List<string>()); }
            set { _priority = value; }
        }

        [JsonProperty(Required = Required.Default, DefaultValueHandling = DefaultValueHandling.Ignore, PropertyName = "user_id_type")]
        public override List<string> user_id_type
        {
            get { return _user_id_type ?? (_user_id_type = new List<string>()); }
            set { _user_id_type = value; }
        }

        public static extensions_PATCH CreateFromJSON(string JSON)
        {
            return (extensions_PATCH) JsonConvert.DeserializeObject(JSON, typeof (extensions_PATCH));
        }
    }
}