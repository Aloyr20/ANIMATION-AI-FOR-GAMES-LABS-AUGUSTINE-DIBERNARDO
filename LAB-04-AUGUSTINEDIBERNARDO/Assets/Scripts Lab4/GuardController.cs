using UnityEngine;

public class GuardController : MonoBehaviour
{
   Animator animator;
   public bool mirrored = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            mirrored = animator.GetBool("mirrored");
            animator.SetBool("mirrored", !mirrored);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            animator.SetTrigger("Axe");
            animator.SetLayerWeight(1, 0.85f);
            animator.SetLayerWeight(3, 0F);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            animator.SetTrigger("Sword");
            animator.SetLayerWeight(1, 0.85f);
            animator.SetLayerWeight(3, 0F);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            animator.SetTrigger("Bow");
            animator.SetLayerWeight(1, 0.85f);
            animator.SetLayerWeight(3, 0F);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            animator.SetLayerWeight(2, 1f);
            animator.SetLayerWeight(3, 0F);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            animator.SetLayerWeight(3, 1f);
            animator.SetLayerWeight(1, 0f);
            animator.SetLayerWeight(2, 0f);
            animator.SetLayerWeight(4, 0f);

        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            animator.SetLayerWeight(4, 0.55f);
            animator.SetLayerWeight(3, 0f);
        }
    }

}
