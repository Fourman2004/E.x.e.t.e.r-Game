using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notespawner : MonoBehaviour
{
    public GameObject Up, Down, Left, Right;
    public Notes upNote, downNote, leftNote, rightNote;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Up = GameObject.Find("Up");
        if (Up.CompareTag("Up"))
        {
            Instantiate(upNote);
        }
    }
}
