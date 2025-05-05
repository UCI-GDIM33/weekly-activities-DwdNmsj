using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float speed = 3f;
    public Animator animator;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(h, 0, v);

        if (move.magnitude > 0.1f)
        {
            transform.Translate(move * speed * Time.deltaTime, Space.World);
            transform.forward = move;
            animator.SetBool("isWalking", true); // 直接设参数
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }
}
