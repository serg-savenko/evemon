﻿using System.Xml.Serialization;
using EVEMon.XmlGenerator.Interfaces;

namespace EVEMon.XmlGenerator.StaticData
{
    public sealed class InvFlags : IHasID
    {
        [XmlElement("flagID")]
        public int ID { get; set; }

        [XmlElement("flagName")]
        public string Name { get; set; }

        [XmlElement("flagText")]
        public string Text { get; set; }

        [XmlElement("orderID")]
        public short OrderID { get; set; }

    }
}
