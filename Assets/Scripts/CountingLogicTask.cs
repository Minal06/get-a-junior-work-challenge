using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountingLogicTask : MonoBehaviour
{
    int i = 101;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CountDownFrom100", 0, 0.5f);
    }
    private void Update()
    {
        
    }

    void CountDownFrom100()
    {
        if (i > 0)
        {
            i--;
        }
        Debug.Log(i);

        if (i % 3 == 0 && i % 5 == 0)
        {
            Debug.LogWarning("Marco Polo");
        }        
        else if (i % 3 == 0)
        {
            Debug.LogWarning("Marco");
        }
        else if (i % 5 == 0)
        {
            Debug.LogWarning("Polo");
        }
    }
}
