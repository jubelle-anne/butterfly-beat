using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterflyScript : MonoBehaviour
{
    public Rigidbody2D myBody;
    public float flyStrength = 6;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKey(KeyCode.F)) 
        {
            myBody.velocity = Vector2.up * flyStrength;
        };
    }
}
