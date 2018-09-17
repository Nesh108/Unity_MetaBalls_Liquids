using UnityEngine;

public class OnLiquidGrounded : MonoBehaviour
{

    [SerializeField] private Animator FluidAnimator;


    void Start()
    {
        if (FluidAnimator == null)
        {
            FluidAnimator = GetComponent<Animator>();
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            FluidAnimator.SetBool("IsGrounded", true);
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            FluidAnimator.SetBool("IsGrounded", false);
        }
    }
}
