using UnityEngine;
using System.Collections.Generic;


public class AnimationInteractscript : MonoBehaviour
{
    private bool insideTrigger;

    public Animator myAnimator;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) //WHEN INTERACTED WITH THE ANIMAATION PARAMETER TRIGGER IS TURNED ON 
        {
           myAnimator.SetTrigger("interaction");
        }
    }
}
