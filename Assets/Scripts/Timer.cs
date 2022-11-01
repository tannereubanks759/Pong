using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float cooldown = 6f;
    private GameObject player;
    public BoxCollider2D collider1;
    public GameObject body;
    public PhysicsMaterial2D mat1;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player 1");
        mat1 = GameObject.Find("noBounceObject").GetComponent<BoxCollider2D>().sharedMaterial;
        collider1 = GameObject.Find("collider2").GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (cooldown > 0)
        {
            cooldown -= Time.deltaTime;
            
        }
        else
        {
            
            player.GetComponent<SpriteRenderer>().color = Color.white;
            collider1.sharedMaterial = mat1;
        }
    }
}
