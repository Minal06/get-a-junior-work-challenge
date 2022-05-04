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

    public GameObject InfoPopUp;

    protected InfoContent m_CurrentContent;

    private void Awake()
    {
        Instance = this;
        InfoPopUp.SetActive(false);

    }

    /*private void OnDestroy()
    {
        Instance = null;
    }*/

    private void Update()
    {
        if (m_CurrentContent == null)
            return;
    }

    public void ShowPopUpInfo()
    {
  //      InfoPopUp.name.text = m_CurrentContent
    }

}
