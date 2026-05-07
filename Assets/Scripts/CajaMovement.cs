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
        //Para probar, solamente hacemos que suba
        Vector3 newPosition = transform.position;
        newPosition.y = initialYValue;
        transform.position = newPosition;
    }
}
