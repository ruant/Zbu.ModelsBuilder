using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Umbraco.ModelsBuilder.AspNet.Api
{
    [DataContract]
    public class GetModelsData : ValidateClientVersionData
    {
        [DataMember]
        public string Namespace { get; set; }

        [DataMember]
        public IDictionary<string, string> Files { get; set; }

        public override bool IsValid => base.IsValid && !string.IsNullOrWhiteSpace(Namespace) && Files != null;
    }
}