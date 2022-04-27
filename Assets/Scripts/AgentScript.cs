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
        CheckIsDead();
    }

    void OnCollisionEnter(Collision col)
    {   
        if (col.gameObject.tag == "Agent")
        {
            healthAmount -= 1;

            Debug.Log(this.gameObject.name + "Lost 1 health. Healt left = " + healthAmount) ;
            
        }
    }
    
    void CheckIsDead()
    {
        if (healthAmount < 1)
        {
            this.gameObject.SetActive(false);
        }
    }
}
