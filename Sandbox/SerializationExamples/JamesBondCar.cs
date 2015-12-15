using System;
using System.Xml.Serialization;

namespace Sandbox.SerializationExamples
{ 
    [Serializable]
    public class JamesBondCar : Car
    { 
        [XmlAttribute]
        public bool canFly; 
        [XmlAttribute] 
        public bool canSubmerge; 
    }
}