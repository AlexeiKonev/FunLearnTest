using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyClick : MonoBehaviour
{
    private void OnMouseDown()
    {
        Main.Instance.shoot.ShootToEnemy();
        Debug.Log("clicked");
    }
}
