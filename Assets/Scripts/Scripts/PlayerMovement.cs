using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    private float walkingSpeed;
    private float xDirection;
    private float xVector;
    
    
    void Start()
    {
        walkingSpeed = 5f;
    }


    void Update()
    {
        xDirection = Input.GetAxis("Horizontal");
        xVector = xDirection * walkingSpeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(xVector, 0, 0);
    }
}
