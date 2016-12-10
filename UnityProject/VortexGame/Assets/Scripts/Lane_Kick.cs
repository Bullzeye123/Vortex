using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lane_Kick : MonoBehaviour {

    private Animator anim;

	// Use this for initialization
	void Start () {
		anim = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        

        
	}

    private void switchGadgetPosition()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetBool("Kick", true);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetBool("Kick", false);
        }
    }

    private void performAction()
    {
        if (Animator.StringToHash("wait") == anim.GetCurrentAnimatorStateInfo(0).tagHash && Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("Kick", true);
        }
        if (Animator.StringToHash("kick") == anim.GetCurrentAnimatorStateInfo(0).tagHash)
        {
            anim.SetBool("Kick", false);
        }
    }
}
