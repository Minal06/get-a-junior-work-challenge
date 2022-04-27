using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundries : MonoBehaviour
{
    private float m_boundry = 5.0f;

    private void Update()
    {
        LineMax();
    }

    void LineMax()
    {
        if (transform.position.x < -m_boundry)
        {
            transform.position = new Vector3(-m_boundry, transform.position.y, transform.position.z);
        }
        if (transform.position.x > m_boundry)
        {
            transform.position = new Vector3(m_boundry, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -m_boundry)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -m_boundry);
        }
        if (transform.position.z > m_boundry)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, m_boundry);
        }
    }


}
