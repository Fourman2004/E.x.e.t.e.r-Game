using System.Collections;
using System.Collections.Generic;
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
        addtoScore = FindObjectOfType<ReadScore>();
    }

    // Update is called once per frame
    void OnCollisionEnter()
    {
        if (gameObject.tag != "Up" || gameObject.tag != "Down" || gameObject.tag != "Left" || gameObject.tag != "Right")
        {
            Destroy(Note);
            addtoScore.UpdateScore();
        }
        else if (gameObject.tag != "Deadzone")
        {
            Destroy(Note);
            Debug.Log("You Missed");
                      
        }
    }
}
