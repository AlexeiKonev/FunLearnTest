using Spine.Unity;
using UnityEngine;

public class PlayerAutoMove : MonoBehaviour, IDamageble
{
    private bool underAttack = false;
    public SkeletonAnimation skeletonAnimation;
    public float currentHealth = 0;
    private float maxHealth = 20f;

    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
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
    void AutoMove()
    {
        transform.Translate(Vector2.right * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("enemy!");
            underAttack = true;
        }
    }

    public void Damage(float damage)
    {
        currentHealth -= damage;
        Debug.Log($"{currentHealth}");
    }
}
