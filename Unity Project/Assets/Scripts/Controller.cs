using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using UnityEditor;
using System.Drawing.Text;
using UnityEditor.Experimental.GraphView;

public class Controller : MonoBehaviour
{
    public SerialCommunicationManager serialCommunicationManager;
    public GameObject upInput, downInput, leftInput, rightInput;
    float pinUp, pinDown, pinLeft, pinRight;
    public int upPin, downPin, leftPin, rightPin;
    string[] serialData;

    // Start is called before the first frame update
    void Start()
    {
        serialData = serialCommunicationManager.ReadPinData(' ');
        pinUp = float.Parse(serialCommunicationManager.SerialReadLine());
        pinDown = float.Parse(serialCommunicationManager.SerialReadLine());
        pinLeft = float.Parse(serialCommunicationManager.SerialReadLine());
        pinRight = float.Parse(serialCommunicationManager.SerialReadLine());
        upInput.SetActive(false);
        downInput.SetActive(false);
        leftInput.SetActive(false);
        rightInput.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (serialData != null)
        { 
            Debug.Log("Up pin:" + pinUp);
            Debug.Log("Down pin:" + pinDown);
            Debug.Log("Left pin:" + pinLeft);
            Debug.Log("Right pin:" + pinRight);
        }
        else
        {
            Debug.Log("Error");
        }

    }
}