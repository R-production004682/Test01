using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private Animator animator;

    void Start() => animator = GetComponent<Animator>();

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator?.SetTrigger("IsAttack");
        }
    }

}
