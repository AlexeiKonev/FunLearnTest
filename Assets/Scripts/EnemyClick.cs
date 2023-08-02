using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyClick : MonoBehaviour
{
    private void OnMouseDown()
    {
        Main.Instance.Shoot.ShootToEnemy();
        Debug.Log("clicked");
    }
}
