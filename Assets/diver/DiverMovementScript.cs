using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiverMovementScript : MonoBehaviour
{
    public float diverSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().velocity += new Vector2(0, diverSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody2D>().velocity += new Vector2(0, -diverSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity += new Vector2(diverSpeed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity += new Vector2(-diverSpeed, 0);
        }
        
    }
}
