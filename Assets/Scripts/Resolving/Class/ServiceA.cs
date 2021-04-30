using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Resolving
{
    public class ServiceA : IServiceA
    {
        private string flag;
        public static ServiceA GoodLocalDefault
        {
            get
            {
                return new ServiceA("global_A");
            }
        }

        public ServiceA(string flag)
        {
            this.flag = flag;
        }

        public void Print()
        {
            Debug.Log($"flag:{flag}");
        }
    }

    public class ServiceAExtension : IServiceA
    {
        private string flag;
        public static ServiceAExtension GoodLocalDefault
        {
            get
            {
                return new ServiceAExtension("global_ServiceAExtension");
            }
        }

        public ServiceAExtension(string flag)
        {
            this.flag = flag;
        }

        public void Print()
        {
            Debug.Log($"flag:{flag}");
        }
    }
}
