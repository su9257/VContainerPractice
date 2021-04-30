using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Resolving
{
    public class ServiceB : IServiceB
    {
        private string flag;
        public static ServiceB GoodLocalDefault
        {
            get
            {
                return new ServiceB("global_B");
            }
        }

        public ServiceB(string flag)
        {
            this.flag = flag;
        }

        public void Print()
        {
            Debug.Log($"flag:{flag}");
        }
    }
}
