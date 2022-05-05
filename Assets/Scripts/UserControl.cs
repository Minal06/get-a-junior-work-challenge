using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserControl : MonoBehaviour
{
    public Camera gameCamera;
    public GameObject Marker;

    [Header("InfoPanel")]
    public GameObject InfoPopUp;
    //[SerializeField] GameObject healthCount3;
    //[SerializeField] GameObject healthCount2;
    [SerializeField] Text lifeCount;

    private AgentScript m_selected = null;
    

    private void Start()
    {
        Marker.SetActive(false);
        InfoPopUp.SetActive(false);
    }

    public void HandleSelection()
    {
        var ray = gameCamera.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if(hit.transform != null)
            {
                PrintName(hit.transform.gameObject);

                var agentScript = hit.collider.GetComponent<AgentScript>();
                m_selected = agentScript;

                Debug.Log(m_selected.GetComponent<AgentScript>().healthAmount);
            }           
        }
    }

    void PrintName(GameObject obj)
    {
        print(obj.name);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {               
            HandleSelection();            
            MarkerHandling();
            InfoScreen();
        }
                
    }

    void MarkerHandling()
    {
        if (m_selected == null && Marker.activeInHierarchy)
        {
            Marker.SetActive(false);
            Marker.transform.SetParent(null);
        }
        else if(m_selected != null && Marker.transform.parent != m_selected.transform)
        {
            Marker.SetActive(true);
            Marker.transform.SetParent(m_selected.transform, false);
            Marker.transform.localPosition = Vector3.zero;
        }
    }

    void InfoScreen()
    {
        if (m_selected == null)
        {
            InfoPopUp.SetActive(false);
        }
        else
        {
            InfoPopUp.SetActive(true);
            InfoPopUp.GetComponentInChildren<Text>().text = m_selected.GetName();
            lifeCount.text = m_selected.healthAmount + " lifes";
        }
    }
}
