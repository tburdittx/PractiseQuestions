using System;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Entities
{
    [Serializable]
    [XmlType]
    [DataContract]
    public class EntityBase
    {
        [DataMember]
        [XmlElement]
        public long Id { get; set; }
    }
}

