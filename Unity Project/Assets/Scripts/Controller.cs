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
    float pinUp; //, pinDown, pinLeft, pinRight;

    // Start is called before the first frame update
    void Start()
    {
        pinUp = float.Parse(serialCommunicationManager.SerialReadLine());
        upInput.SetActive(false);
     downInput.SetActive(false);
     leftInput.SetActive(false);
     rightInput.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(pinUp);

        /** pinDown = float.Parse(serialData[1]);
         pinLeft = float.Parse(serialData[2]);
         pinRight = float.Parse(serialData[3]);
         
         Debug.Log(pinDown);
         Debug.Log(pinLeft);
         Debug.Log(pinRight);
         {
             rightInput.SetActive(true);
             }
         }
         else if ()
         {

         }
         else if ()
         {

         }
         else if ()
         {

         }
         else
         {
             upInput.SetActive(false);
             downInput.SetActive(false);
             leftInput.SetActive(false);
             rightInput.SetActive(false); 
         } **/

    }
}
