using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserControl : MonoBehaviour
{
    public Camera gameCamera;
    public GameObject Marker;

    private AgentScript m_selected = null;

    private void Start()
    {
        Marker.SetActive(false);
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


            /*
            //the collider could be children of the unit, so we make sure to check in the parent
            var agentScript = hit.collider.GetComponentInParent<AgentScript>();
            m_selected = agentScript;


            //check if the hit object have a IUIInfoContent to display in the UI
            //if there is none, this will be null, so this will hid the panel if it was displayed
            var uiInfo = hit.collider.GetComponentInParent<UIMainScene.IUIInfoContent>();
            UIMainScene.Instance.SetNewInfoContent(uiInfo);
*/
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
        }
        if(gameObject.tag == "Agent")
        {
            MarkerHandling();
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
}
