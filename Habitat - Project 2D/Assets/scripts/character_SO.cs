using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Basic Values")]
public class character_SO : ScriptableObject
{
    public int damage, HP,  chaseDistance ;
    public float moveSpeed, hitDistance,pushbackForce;
}
