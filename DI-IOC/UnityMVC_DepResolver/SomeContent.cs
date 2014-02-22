using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnityMVC_DepResolver
{
    public class SomeContent : ISomeContent
    {

        public string theContent
        {
            get
            {
                return "Hello from an injected class!!!";
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
                return "Help Content via Injection!!";
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}