using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VContainer;

namespace Resolving
{
    public class SomeBehaviour : MonoBehaviour
    {
        float speed;

        [Inject]
        public void Construct(GameSettings settings)
        {
            speed = settings.speed;
        }
    }
}
