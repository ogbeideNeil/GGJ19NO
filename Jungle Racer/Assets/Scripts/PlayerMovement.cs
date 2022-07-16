using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController2D controller2D;

    public float speed = 40f;

    float horizointalMove = 0f;
    bool jump = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        horizointalMove = Input.GetAxisRaw("Horizontal") * speed;
    }

    void FixedUpdate()
    {
        controller2D.Move(horizointalMove * Time.fixedDeltaTime, jump);
        jump = false;
    }

}
