using System;

namespace Sandbox.SerializationExamples
{ 
    [Serializable]
    public class Car
    {
        public Radio theRadio = new Radio();
        public bool isHatchBack; 
    }
}