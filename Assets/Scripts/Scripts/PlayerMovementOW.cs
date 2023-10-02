using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
float timer;
bool iframes;
int health;
int gold;

public class PlayerMovementOW : MonoBehaviour
{
    // Start is called before the first frame update

    private float walkingSpeed;
    private float xDirection;
    private float xVector;

    public TextMeshProUGUI goldText;
    public TextMeshProUGUI healthText;

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if()
    }
}
