using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ENEMYDATA", menuName = "SO Enemy data")]
public class EnemyDataSO : ScriptableObject
{
    public bool defeated;
    public Transform tr;

    public void RotateMe()
    {
        tr.Rotate(0, 0, 45);
    }
}
