using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;

public class TestDictionary : MonoBehaviour
{
    Dictionary<string, int> keyValuePairs = new Dictionary<string, int>(3);
    void Start()
    {
        //entries
        var freeCountFieldInfo = keyValuePairs.GetType().GetField("freeCount", BindingFlags.Instance | BindingFlags.NonPublic);
        var countFieldInfo = keyValuePairs.GetType().GetField("count", BindingFlags.Instance | BindingFlags.NonPublic);
        var entriesFieldInfo = keyValuePairs.GetType().GetField("entries", BindingFlags.Instance | BindingFlags.NonPublic);

        var freeCount = freeCountFieldInfo.GetValue(keyValuePairs);
        var count = countFieldInfo.GetValue(keyValuePairs);
        var entries =entriesFieldInfo.GetValue(keyValuePairs);
        
        Debug.Log($"freeCount:{freeCount} count:{count} Count:{keyValuePairs.Count}");

        for (int i = 0; i < 3; i++)
        {
            keyValuePairs.Add("0_" + i, i);
        }
         freeCount = freeCountFieldInfo.GetValue(keyValuePairs);
         count = countFieldInfo.GetValue(keyValuePairs);
        Debug.Log($"freeCount:{freeCount} count:{count} Count:{keyValuePairs.Count}");

        keyValuePairs.Add("1_" + 1, 1);
        freeCount = freeCountFieldInfo.GetValue(keyValuePairs);
        count = countFieldInfo.GetValue(keyValuePairs);
        Debug.Log($"freeCount:{freeCount} count:{count} Count:{keyValuePairs.Count}");
    }

    // Update is called once per frame
    void Update()
    {
       
    }

}
