using Spine.Unity;
using UnityEngine;

public class Move : MonoBehaviour
{
    private bool facingRight = true;
    public SkeletonAnimation skAnimation;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            PlayerMove(Vector2.right);
            if (!facingRight)
            {
                Flip();
            }
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            PlayerMove(Vector2.left);
            if (facingRight)
            {
                Flip();
            }
        }
        else
        {
            DoIdleAnimation();
        }
    }

    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    private void PlayerMove(Vector2 direct)
    {
        transform.Translate(direct * Time.deltaTime); 
        DoWalkAnimation();
    }
    void DoWalkAnimation()
    {
        skAnimation.AnimationName = "walk";
    }
    void DoIdleAnimation()
    {
        skAnimation.AnimationName = "idle";
    }
}
