using System;
using System.Collections.Generic;
using System.Text;

namespace Seams
{
    public class SomeClass
    {
        /// <summary>
        /// Let's say you would have this class under test. Would it be easy to change the behavior of the function, without changing any other code than your test?
        /// </summary>
        public void NonSeamExample()
        {
            Helper.Instance.DoSomething();
        }



























        /// <summary>
        /// And in this case?
        /// </summary>
        /// <param name="helper"></param>
        public void SeamExample(Helper helper)
        {
            helper.DoSomething();
        }
    }
}
