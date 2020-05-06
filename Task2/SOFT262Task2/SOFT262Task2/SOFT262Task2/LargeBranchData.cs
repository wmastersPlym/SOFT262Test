using System;
using System.Collections.Generic;
using System.Text;

namespace SOFT262Task2
{
    class LargeBranchData
    {
        private float length;

        
        public float Length
        {
            get { return length; }
            set { length = value; }
        }

        public LargeBranchData(float length)
        {
            this.length = length;
        }
    }
}
