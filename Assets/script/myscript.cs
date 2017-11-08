using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myscript : MonoBehaviour {

    public Animator anim;
    public Rigidbody rgbd;
    private float moveHor;
    private float moveVer;
    private bool bool_jump;
    private bool bool_run;
    void Start()
    {
        anim = GetComponent<Animator>();
       rgbd = GetComponent<Rigidbody>();
    }
    void Update()
    {

        moveHor = Input.GetAxis("Horizontal");
        moveVer = Input.GetAxis("Vertical");
        anim.SetFloat("moveX", moveHor);
        anim.SetFloat("moveY", moveVer);


        bool_jump = Input.GetKey(KeyCode.Space);
        anim.SetBool("bool_j", bool_jump);

        bool_run = Input.GetKey(KeyCode.LeftShift);
        anim.SetBool("bool_run", bool_run);

        if (Input.GetKeyDown("1"))
        {
           //3rd parameters means from what position need to start the animation. 
            //if 1 means at the end, 0.5 from the middle
            //2nd parameters means which layer "base layer" correspond to the base layer
            anim.Play("WAIT01", -1, 0f);
        }

        if (Input.GetKeyDown("2"))
        {
            anim.Play("WAIT02", -1, 0f);
        }

        float moveposX = moveHor * Time.deltaTime * 15.0f;
        float moveposZ = moveVer * Time.deltaTime * 30.0f * -1.0f;
        if(bool_run)
        {
            moveposX = moveposX * 2.0f;
            moveposZ = moveposZ * 2.0f;
        }
        //Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        if (moveposZ == 0f)
            moveposX = 0f;
       
        rgbd.velocity = new Vector3(moveposX, 0f, moveposZ);
        //print("Kanika " + rgbd.velocity.x + " " + rgbd.velocity.z);
    }
}
