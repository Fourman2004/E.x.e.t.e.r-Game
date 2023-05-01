using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Notes : MonoBehaviour
{
    public Collision noteCollider;
    public GameObject Note, deathZone;
    public ReadScore addtoScore;

    // Start is called before the first frame update
    void Start()
    {
        addtoScore = FindObjectOfType<ReadScore>();
        deathZone = GameObject.FindGameObjectWithTag("Deadzone");
    }

    // Update is called once per frame
    void OnCollisionEnter()
    {
        if (!deathZone)
        {
            Destroy(Note);
            addtoScore.UpdateScore();
            Debug.Log("Player Hit");
        }
        else
        {
            Destroy(Note);
            addtoScore.UpdateMisses();
            Debug.Log("Player Miss");
        }
    }
}
