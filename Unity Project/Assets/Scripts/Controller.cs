using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;


public class Controller : MonoBehaviour
{
    public SerialCommunicationManager manager;
    public GameObject upInput, downInput, leftInput, rightInput;
    public Collider upColl, leftColl, rightColl, downColl;
    // Start is called before the first frame update
    void Start()
    {
     manager = GetComponent<SerialCommunicationManager>();
     upColl = GetComponent<Collider>();
     leftColl = GetComponent<Collider>();
     rightColl = GetComponent<Collider>();
     downColl = GetComponent<Collider>();
     upInput.SetActive(false);
     downInput.SetActive(false);
     leftInput.SetActive(false);
     rightInput.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
