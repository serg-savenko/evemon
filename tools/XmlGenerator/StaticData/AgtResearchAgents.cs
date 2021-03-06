using System.Xml.Serialization;
using EVEMon.XmlGenerator.Interfaces;

namespace EVEMon.XmlGenerator.StaticData
{
    public sealed class AgtResearchAgents : IHasID
    {
        [XmlElement("agentID")]
        public int ID { get; set; }

        [XmlElement("typeID")]
        public int ResearchSkillID { get; set; }
    }
}