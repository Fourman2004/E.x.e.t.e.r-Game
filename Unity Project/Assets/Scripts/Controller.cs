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
    public string[] pins;
    // Start is called before the first frame update
    void Start()
    {
     pins = serialCommunicationManager.ReadPinData(' ');
     upInput.SetActive(false);
     downInput.SetActive(false);
     leftInput.SetActive(false);
     rightInput.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        int rightvalue = int.Parse(pins[1]);
        serialCommunicationManager.SerialWriteLine(rightvalue.ToString());
        Debug.Log(rightvalue.ToString());
    
        /**{
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
