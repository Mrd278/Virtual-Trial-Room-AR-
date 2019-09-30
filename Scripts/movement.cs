using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Joystick joystick;
    public float speed = .0005f;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(joystick.Horizontal >= 0.01 || joystick.Vertical >= 0.01)
        {
            float horizontal = joystick.Horizontal * speed;
            float vertical = joystick.Vertical * speed;

            this.transform.position += new Vector3(horizontal, vertical, 0f);
            anim.SetBool("idle", false);
            anim.SetBool("run", true);
        }
        else
        {
            anim.SetBool("run", false);
            anim.SetBool("idle", true);
        }
        
    }
}
