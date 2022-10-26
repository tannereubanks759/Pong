using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //reference to the character controller that handles the collisions and movement.
    public CharacterController controller;
    //speed of the player
    public float speed = 1f;

    public bool cooldownDone = false;
    public float cooldown = 5f;
    public float abilityCount = 0f;
    private void Start()
    {
        if(cooldown > 0)
        {
            cooldown -= Time.deltaTime;
        }
        else
        {
            cooldownDone = true;
        }
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

        if (Input.GetKeyDown(KeyCode.F) && cooldownDone == true){
            //
        }
    }
}
