using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            anim.SetTrigger(PlayerAnimationParameters.jumpTrigger);
        }

        var x = (Input.GetAxis("Vertical"));
        anim.SetFloat(PlayerAnimationParameters.speedFloat, x);
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            print("Axis = " + x);
        }
    }
}

struct PlayerAnimationParameters
{
    public static string jumpTrigger = "jump";
    public static string walkingBool = "isWalking";
    public static string runningBool = "isRunning";
    public static string speedFloat = "speed";
}