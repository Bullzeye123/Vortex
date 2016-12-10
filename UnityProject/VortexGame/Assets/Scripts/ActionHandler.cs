using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionHandler : MonoBehaviour {

    private Animator anim;

    // Use this for initialization
    void Start () {
        anim = this.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        if (anim.GetCurrentAnimatorStateInfo(0).tagHash == Animator.StringToHash("wait") && 
            Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.LeftControl))
        {
            anim.SetBool("action", true);
        }
        else if (anim.GetCurrentAnimatorStateInfo(0).tagHash != Animator.StringToHash("wait"))
        {
            anim.SetBool("action", false);
        }
    }
}
