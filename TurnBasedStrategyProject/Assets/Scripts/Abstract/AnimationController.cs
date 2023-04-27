using UnityEngine;

public abstract class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator animator;
     
    const string IDLE = "Idle"; 

    [SerializeField] private string currentState; 

    public void ChangeAnimationState(string newState)
    {
        //if (currentState == newState)
        //    return;

        if (animator == null) return;
        animator.Play(newState);

        currentState = newState;
    }

    public Animator GetAnimator()
    {
        return animator;
    }

}
