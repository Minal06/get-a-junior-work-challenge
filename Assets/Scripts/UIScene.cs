using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScene : MonoBehaviour
{
    public static UIScene Instance { get; private set; }

    public interface InfoContent
    {
        string GetName();

        string GetData();
    }

   
}
