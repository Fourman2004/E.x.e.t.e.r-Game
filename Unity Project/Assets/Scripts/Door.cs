using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public Collider Doorcollider;
    public GameObject Dooraxis;
    public bool doopen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        if(!doopen && Doorcollider)
        {
            OpenDoor();
            doopen = false;
        }
        else
        {
            CloseDoor();
        }
    }



    public void OpenDoor()
    {
     Dooraxis.transform.Translate(new Vector3(10.0f, 0.0f, 0.0f));
    }

    public void CloseDoor()
    {
        Dooraxis.transform.Translate(new Vector3(-10.0f,0.0f,0.0f));
    }

}
       
