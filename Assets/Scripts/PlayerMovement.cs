using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //reference to the character controller that handles the collisions and movement.
    public CharacterController controller;
    //speed of the player
    public float speed = 1f;
    public float abilityCount = 0f;
    public BoxCollider2D collider1;
    public GameObject body;
    public PhysicsMaterial2D mat;
    public GameObject player;
    private void Start()
    {
        collider1 = body.GetComponent<BoxCollider2D>();
        
    }
    // Update is called once per frame
    void Update()
    {
        //step 1 get current position
        Vector3 currentPos = transform.position;
        Vector3 motion = Vector3.zero;

        //step 2 get player input
        
        float inputY = Input.GetAxis("Vertical");

        //step 3 set the new position based on input and speed
        //the new value of currentPos in x will be its current value, plus the speed
        //multiplied by the input (-1 or 1) and time.deltatime
        
        currentPos.y = currentPos.y + speed * inputY * Time.deltaTime;


        //this will get us vector of our movement, instead of the new position.
        //motion.x = transform.forward.normalized.x * speed * inputX * Time.deltaTime;
        //motion.z = transform.forward.normalized.z * speed * inputY * Time.deltaTime;

        motion = transform.up.normalized * speed * inputY * Time.deltaTime;

        //step 5 assign new position
        //transform.position = currentPos;

        //instead of moving normally, we can use the character controller
        controller.Move(motion);

        if (Input.GetKeyDown(KeyCode.F))
        {
            collider1.sharedMaterial = mat;
            Debug.Log("f key pressed");
            player.GetComponent<SpriteRenderer>().color = Color.red;
            player.AddComponent<Timer>();
            //UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(player, "Assets/Scripts/PlayerMovement.cs (59,13)", "Timer");
        }
    }
    
}
