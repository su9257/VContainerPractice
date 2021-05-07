using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VContainer.Unity;

namespace Resolving
{
    public class ServiceB : IServiceB, IStartable
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

        public void Start()
        {
            Print();
        }
    }
}
