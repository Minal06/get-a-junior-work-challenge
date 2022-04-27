using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentScript : MonoBehaviour
{    
    [SerializeField] int healthAmount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {   
        if (col.gameObject.tag == "Agent")
        {
            Debug.Log(this.gameObject.name + "Lost 1 health");            
        }
    }
    
}
