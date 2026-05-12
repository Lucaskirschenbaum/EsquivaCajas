using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaCollisionDetection : MonoBehaviour
{
    public CajaMovement cajaMovementScript;
   
    void Start()
    {
        cajaMovementScript = GetComponent<CajaMovement>();
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Piso"))
        {
            if(cajaMovementScript.activa)
                cajaMovementScript.MoveBoxToRandomPosition();
            else
                Time.timeScale = 0f;
        }
    }
}