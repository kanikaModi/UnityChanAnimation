using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim_controller : MonoBehaviour {

    private Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}   
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.Play("WAIT_01", -1, 0f);
        }
	}
}
