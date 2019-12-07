using System;

namespace lab06
{
    public class ReflectionObserver
    {
        public ReflectionObserver() { }
        public ReflectionObserver(int i) { }
        public ReflectionObserver(string str) { }

        public int Plus(int x, int y) { return x + y; }
        public int Minus(int x, int y) { return x - y; }

        [CustomAttribute("паблик стринг проперти4 гет и сет")]
        public string property1 { get { return _property1; } set { _property1 = value; } }
        private string _property1;


        [CustomAttribute("паблик инт проперти2 гет и сет")]
        public int property2 { get; set; }


        public double property3 { get; set; }

        [CustomAttribute("паблик флоат проперти4 гет и сет")]
        public float property4 { get; set; }

        public short property5 { get; set; }

        public int field1; public float field2;
    }

}