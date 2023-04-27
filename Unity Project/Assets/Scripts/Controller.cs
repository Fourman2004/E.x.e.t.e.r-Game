using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using UnityEditor;

public class Controller : MonoBehaviour
{
    public SerialCommunicationManager mySupManager;
    public GameObject upInput, downInput, leftInput, rightInput;
    public Collider upColl, leftColl, rightColl, downColl;
    public int upPin, downPin, leftPin, rightPin;
    // Start is called before the first frame update
    void Start()
    {
     
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
        string[] data = mySupManager.ReadPinData(' ');
        Debug.Log(data[0]);
      /**  if ()
        {
            rightInput.SetActive(true);
        }**/

    }
}
