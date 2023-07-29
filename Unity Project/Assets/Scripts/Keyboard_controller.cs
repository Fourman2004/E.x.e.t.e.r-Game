using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using UnityEditor;
using System.Drawing.Text;
using UnityEditor.Experimental.GraphView;
using System;

public class Keyboard_controller : MonoBehaviour
{
    
    public GameObject upInput, downInput, leftInput, rightInput;

    //Arduino Communication
    public Controller controller;

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
        if (!controller.Aurdon)
        {
            if (Input.GetButton()
            {
                upInput.SetActive(true);
            }
            else if ()
            {
                leftInput.SetActive(true);
            }
            else if ()
            {
                rightInput.SetActive(true);
            }
            else if ()
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