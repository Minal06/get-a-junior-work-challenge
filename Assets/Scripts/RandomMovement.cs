using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    [SerializeField] float latestDirectionChangeTime;
    [SerializeField] float directionChangeTime;
    [SerializeField] float characterVelocity;
    [SerializeField] float valueY;
    private Vector3 movementDirection;
    private Vector3 movementPerSecond;


    void Start()
    {
        latestDirectionChangeTime = 0f;
        CalcuateNewMovementVector();
    }

    public void CalcuateNewMovementVector()
    {        
        movementDirection = new Vector3(Random.Range(-1.0f, 1.0f),valueY, Random.Range(-1.0f, 1.0f)).normalized;
        movementPerSecond = movementDirection * characterVelocity;
    }

    void Update()
    {
        //if the changeTime was reached, calculate a new movement vector
        if (Time.time - latestDirectionChangeTime > directionChangeTime)
        {
            latestDirectionChangeTime = Time.time;
            CalcuateNewMovementVector();
        }

        //move enemy: 
        transform.position = new Vector3(transform.position.x + (movementPerSecond.x * Time.deltaTime),valueY,transform.position.z + (movementPerSecond.z * Time.deltaTime));

    }
}
