using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notespawner : MonoBehaviour
{
    public float spawnCooldown;
    public GameObject Up, Down, Left, Right;
    public Notes upNote, downNote, leftNote, rightNote;
    WaitForSeconds Delay;
    // Start is called before the first frame update
    void Start()
    {
        //Makes new WaitForSeconds (Goes Unused) and invokes method constantly on a float 
        Delay = new WaitForSeconds(spawnCooldown);
        InvokeRepeating("spawnnote", 0, spawnCooldown);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnnote()
    {
        //Gets number between 1 - 4, And calls a method to spawn a note
        float spawnchance = Random.Range(1, 5);
        Debug.Log(spawnchance);
        if (spawnchance == 1)
        {
            Upnotespawn();
        }
        else if (spawnchance == 2)
        {
            Leftnotespawn();
        }
        else if (spawnchance == 3)
        {
            Rightnotespawn();
        }
        else
        {
            Downnotespawn();
        }
    }

    //All Spawn methods are the same, will go over one
    void Upnotespawn()
    {
        //finds Object in Scene and Compares Tags, if they're the same, spawns the note
        Up = GameObject.Find("Up");
        if (Up.CompareTag("Up"))
        {
            Instantiate(upNote, Up.transform);
        }
    }

    void Downnotespawn()
    {
        Down = GameObject.Find("Down");
        if (Down.CompareTag("Down"))
        {
            Instantiate(downNote, Down.transform);
        }
    }

    void Leftnotespawn()
    {
        Left = GameObject.Find("Left");
        if (Left.CompareTag("Left"))
        {
            Instantiate(leftNote, Left.transform);
        }
    }

    void Rightnotespawn()
    {
        Up = GameObject.Find("Right");
        if (Right.CompareTag("Right"))
        {
            Instantiate(rightNote, Right.transform);
        }
    }
}
