using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Miss : MonoBehaviour
{
    public Collision noteCollider;
    public GameObject Note, deathZone;
    public ReadScore addtoScore1;

    // Start is called before the first frame update
    void Start()
    {
        addtoScore1 = FindObjectOfType<ReadScore>();
        deathZone = GameObject.Find("Deadzone");
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {
        if (deathZone == other.gameObject)
        {
            Destroy(Note);
            addtoScore1.UpdateMisses();
            Debug.Log("Player Miss");
        }
    }
}
