using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private void Start() 
    {
        animator = GetComponent<Animator>();

        if(animator == null)
        {
            Debug.LogError("Animator no setting");
        }


        Debug.Log("‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚ ‚ ");

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator?.SetTrigger("IsAttack");
        }
    }
}
