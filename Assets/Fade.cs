using UnityEngine;
using System.Collections;

public class Fade : MonoBehaviour
{

    Animator animator;

    void Start()
    {

        //assign a reference to the Animator component of the same game object
        animator = GetComponent<Animator>();

    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //set the "Fade" trigger on the animator every time, player presses Space
            animator.SetTrigger("Fade");
        }

    }
}
