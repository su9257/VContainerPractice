using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace HelloWorld
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [Inject]
        private GamePresenter gamePresenter;
        void Start()
        {
            if (gamePresenter!=null)
            {
                var tickable = gamePresenter as ITickable;
                tickable.Tick();
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    } 
}
