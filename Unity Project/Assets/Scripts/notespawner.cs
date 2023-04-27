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
        Delay = new WaitForSeconds(spawnCooldown);
        InvokeRepeating("spawnnote", 0, spawnCooldown);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnnote()
    {
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


    void Upnotespawn()
    {
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
