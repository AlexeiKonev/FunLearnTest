using Spine.Unity;
using UnityEngine;

public class PlayerAutoMove : MonoBehaviour
{
    private bool underAttack = false;
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private SkeletonAnimation skeletonAnimation;



    // Update is called once per frame
    private void Update()
    {
        if (!underAttack)
        {
            AutoMove();
            skeletonAnimation.AnimationName = "walk";
        }
        else
        {
            skeletonAnimation.AnimationName = "idle";
        }
    }
    private void AutoMove()
    {
        transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("enemy!");
            underAttack = true;
        }
    }


}
