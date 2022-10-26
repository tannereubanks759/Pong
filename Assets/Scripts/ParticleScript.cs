using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    public ParticleSystem ps;
    // Start is called before the first frame update
    void Start()
    {
        ps.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        ps.Play();
        Debug.Log("hit");
    }
}
