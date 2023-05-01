using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using UnityEditor;
using System.Drawing.Text;
using UnityEditor.Experimental.GraphView;
using System;

public class Controller : MonoBehaviour
{
    public SerialCommunicationManager serialCommunicationManager;
    public GameObject upInput, downInput, leftInput, rightInput;
    string[] serialData;
    int pin;
    // Start is called before the first frame update
    void Start()
    {
        upInput.SetActive(false);
        downInput.SetActive(false);
        leftInput.SetActive(false);
        rightInput.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
     serialData = serialCommunicationManager.ReadPinData(' ');

        if (serialData != null)
        {
           Int32.TryParse(serialData[0], out pin);
           Debug.Log(pin);
         if (pin == 3)
            {
                upInput.SetActive(true);
            }
         else if (pin == 5)
            {
                leftInput.SetActive(true);
            }
         else if (pin == 6)
            {
                rightInput.SetActive(true);
            }
         else if (pin == 9)
            {
              downInput.SetActive(true);
            }
         else
            {
                upInput.SetActive(false);
                downInput.SetActive(false);
                leftInput.SetActive(false);
                rightInput.SetActive(false);
            }
        }

    }
}