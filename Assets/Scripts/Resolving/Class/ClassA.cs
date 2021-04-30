using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VContainer;
using VContainer.Unity;
using VContainer.Internal;
namespace Resolving
{
    class ClassA : IStartable
    {
        readonly IServiceA serviceA;
        readonly IServiceB serviceB;
        readonly SomeUnityComponent component;

        IServiceA serviceAProperty { get; set; } // Will be overwritten if something is registered.

        [Inject]
        public ClassA(IServiceA serviceA, IServiceB serviceB, SomeUnityComponent component)
        {
            this.serviceA = serviceA;
            this.serviceB = serviceB;
            this.component = component;

            this.serviceAProperty = ServiceA.GoodLocalDefault;
        }

        public void Start()
        {
            Debug.Log($"serviceA:{serviceA}");
            Debug.Log($"serviceB:{serviceB}");
            Debug.Log($"component:{component}");

            Debug.Log($"serviceAProperty:{serviceAProperty}");
            serviceAProperty.Print();
        }
    }
}
