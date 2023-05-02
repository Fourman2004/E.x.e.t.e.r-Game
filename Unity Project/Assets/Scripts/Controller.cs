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
    
    public GameObject upInput, downInput, leftInput, rightInput;

    //Arduino Communication
    public SerialCommunicationManager serialCommunicationManager;
    string[] serialData;
    int pin;

    // Start is called before the first frame update
    void Start()
    {
        //Sets the Player's Gameobjects to inactive
        upInput.SetActive(false);
        downInput.SetActive(false);
        leftInput.SetActive(false);
        rightInput.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       //Reads Pin Data
     serialData = serialCommunicationManager.ReadPinData(' ');

        //if statement checks if the String array isn't Empty
        if (serialData != null)
        {
           //Gets the String Array and attempts to make it the pin integer, logs it to debug
           Int32.TryParse(serialData[0], out pin);
           Debug.Log(pin);
            //it the pin value equals any one of these, Sets the Game Object to true (and makes it active), else it disables the game objects 
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