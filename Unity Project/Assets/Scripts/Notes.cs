using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.VFX;

public class Notes : MonoBehaviour
{
    public Collision noteCollider;
    public GameObject Note;
    public ReadScore addtoScore;

    // Start is called before the first frame update
    void Start()
    {
        addtoScore = FindObjectOfType<ReadScore>(); //finds the Scoreboard Prefab
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {
        //if it gets the Input gameobjects, add to score and destroy this object. Logs it.
        if (other.gameObject.tag == "playerIntercepter") 
        {
            Destroy(Note);
            addtoScore.UpdateScore();
            Debug.Log("Player Hit");
        }
        
            
        
    }
}