using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour

{
    public float velocidad;
    float initialYValue;
    // Update is called once per frame

    void Start()
    {
        initialYValue = transform.position.y;
    }
    void Update()
    {
        transform.Translate(0,-velocidad * Time.deltaTime, 0);
        
    }

    public void MoveBoxToRandomPosition()
    {
        Vector3 newPosition = transform.position;
        int randomX = 0;
        randomX = Random.Range(0,3);
        if(randomX == 0)
        {
            newPosition.x = -2;
        }else if(randomX == 1)
        {
            newPosition.x = 0;
        }else
        {
            newPosition.x = 2;
        }
        
        newPosition.y = initialYValue;
        transform.position = newPosition;
    }
}
