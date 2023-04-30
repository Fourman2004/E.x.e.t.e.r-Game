using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Notes : MonoBehaviour
{
    public Collider collider;
    public GameObject Note;
    public int Points;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter()
    {
        GameObject.Destroy(this);
        Debug.Log("hit note");
    }
}
