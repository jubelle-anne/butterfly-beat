using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float offScreen = -40;
    private bool canBePressed = false;
    public LogicScript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

        // move notes left
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < offScreen)
        {
            Destroy(gameObject);
            Debug.Log("Note deleted.");
        }

        // check if note was hit
        if (canBePressed && Input.GetKeyDown(KeyCode.K)) 
        {
            logic.addScore();
            canBePressed = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        canBePressed = true;
    }


    private void OnTriggerExit2D(Collider2D collision) 
    {
        canBePressed = false;
    }

}
