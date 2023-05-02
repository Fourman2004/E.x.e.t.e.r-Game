using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    public float noteSpeed, waitTime;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Moves the Note forward, then invokes a method in float seconds
        transform.position += (Vector3.forward * noteSpeed) * Time.deltaTime;
        Invoke("SpeedUp", waitTime);
    }

    void SpeedUp()
    {
        //Gets 1 - 100, and if it's 100, it speeds it up
        int speedUpChance = Random.Range(1, 101);
        if (speedUpChance == 100)
        {
            noteSpeed++;
        }
    }

}
