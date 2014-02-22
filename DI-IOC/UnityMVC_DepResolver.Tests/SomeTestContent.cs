using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityMVC_DepResolver.Tests
{
    class SomeTestContent : ISomeContent
    {
        public string theContent
        {
            get
            {
                return "Test Content";
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public string helpAboutContent
        {
            get
            {
                return "Test Help-About Content";
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
