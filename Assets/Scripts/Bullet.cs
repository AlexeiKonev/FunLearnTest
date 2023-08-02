using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float moveSpeed = 22f;
    [SerializeField] private ParticleSystem particleExplosion;
    private void Explode()
    {
        if (particleExplosion != null)
        {
            particleExplosion.Play();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Explode();
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
    private void Update()
    {
        transform.Translate(Vector2.right*Time.deltaTime*moveSpeed);
    }
}