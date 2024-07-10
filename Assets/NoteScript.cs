using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float offScreen = -40;
    // Start is called before the first frame update
    private bool hasPressed = false;
    public LogicScript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < offScreen)
        {
            Destroy(gameObject);
            Debug.Log("Note deleted.");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        checkHitNote();
    }
    private void OnTriggerStay2D(Collider2D collision) 
    {
        checkHitNote();
    }

    private void OnTriggerExit2D(Collider2D collision) 
    {
        hasPressed = false;
    }

    private void checkHitNote()
    {
        if (Input.GetKeyDown(KeyCode.K) && !hasPressed)
        {
            logic.addScore();
            hasPressed = true;
        }
        // note: later set haspressed to true if its been hit
    }
}
