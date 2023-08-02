using Spine.Unity;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField] private enum Direction { LeftDirection, RigthDirection };
    [SerializeField] private SkeletonAnimation skeletonAnimation;
    [SerializeField] private bool targetInBattleArea;
    [SerializeField] private Direction dir = Direction.LeftDirection;
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
    private void AutoMove(Vector2 direction)
    {
        if (!targetInBattleArea)
        {
            transform.Translate(direction * Time.deltaTime);
        }

    }
    private void AttackAnimation()
    {
        skeletonAnimation.AnimationName = "angry";
    }
    private void DoIdleAnimation()
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
