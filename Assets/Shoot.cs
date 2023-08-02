using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private ParticleSystem particleMuzzle;
    public GameObject bullet;
    [SerializeField] private Transform gunPosition;
    public void ShootToEnemy()
    {
        Instantiate(bullet, gunPosition.position, gunPosition.rotation);
        particleMuzzle.Play();
    }
}
