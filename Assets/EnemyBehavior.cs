using Spine.Unity;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public enum Direction { LeftDirection, RigthDirection };
    public SkeletonAnimation skeletonAnimation;
    public bool targetInBattleArea;
    public Direction dir = Direction.LeftDirection;
    private void Start()
    {
        skeletonAnimation.AnimationName = "run";
    }
    private void Update()
    {

        if (dir == Direction.RigthDirection)
        {
            AutoMove(Vector2.right);

        }
        if (dir == Direction.LeftDirection)
        {
            AutoMove(Vector2.left);

        }


    }
    void AutoMove(Vector2 direction)
    {
        if (!targetInBattleArea)
        {
            transform.Translate(direction * Time.deltaTime);
        }

    }
    void AttackAnimation()
    {
        skeletonAnimation.AnimationName = "angry";
    }
    void DoIdleAnimation()
    {
        skeletonAnimation.AnimationName = "idle";
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            targetInBattleArea = true;
            AttackAnimation();
            Main.Instance.GameOver();
            Debug.Log("player in area");
        }
    }

}
