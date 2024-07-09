using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawnScript : MonoBehaviour
{

    public GameObject note;
    public float spawnRate = 1;
    private float timer = 0;
    private float offset = 15;
    // Start is called before the first frame update
    void Start()
    {
        spawnNote();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) 
        {
            timer += Time.deltaTime;
        }
        else 
        {
            spawnNote();
            timer = 0;
        }


        
    }

    void spawnNote()
    {
        float lowPoint = transform.position.y - offset;
        float highPoint = transform.position.y + offset;
        Instantiate(note, new Vector3(transform.position.x, Random.Range(lowPoint, highPoint), 0), transform.rotation);
    }
}
