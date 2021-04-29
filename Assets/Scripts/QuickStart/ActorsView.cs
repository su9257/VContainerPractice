using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuickStart
{
    public class ActorsView : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        }

        public void Print()
        {
            Debug.Log(nameof(ActorsView) + ":" + gameObject.name);
        }


    } 
}
