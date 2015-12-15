using System;

namespace Sandbox.SerializationExamples
{ 
    [Serializable]
    public class Radio
    {
        public bool hasTweeters;
        public bool hasSubWoofers;
        public double[] stationPresets;

        [NonSerialized] 
        public string radioID = "XF-55RR6"; 
    }
}
