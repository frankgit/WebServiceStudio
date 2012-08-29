using System.ComponentModel;
using System.Xml.Serialization;

namespace IBS.Utilities.ASMWSTester
{
    [TypeConverter(typeof (ExpandableObjectConverter))]
    public class AuthenticationHeaderProperties
    {
        public string[] GetProxyBaseTypeList()
        {
            return Configuration.MasterConfig.GetProxyBaseTypes();
        }

        public override string ToString()
        {
            return "";
        }


        [XmlAttribute]
        public string Dsn
        {
            get { return dsn; }
            set { dsn = value; }
        }

        [XmlAttribute]
        public string Proof
        {
            get { return proof; }
            set { proof = value; }
        }

        [XmlAttribute]
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string dsn;
        private string proof;
        private string userName;
    }
}