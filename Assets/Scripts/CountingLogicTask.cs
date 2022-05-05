using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountingLogicTask : MonoBehaviour
{
    int i = 101;
      

    public void StartCounting()
    {
        InvokeRepeating("CountDownFrom100", 0, 0.5f);
    }

    void CountDownFrom100()
    {
        if (i > 0)
        {
            i--;
            Debug.Log(i);

            if (i % 15 == 0)
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
}
