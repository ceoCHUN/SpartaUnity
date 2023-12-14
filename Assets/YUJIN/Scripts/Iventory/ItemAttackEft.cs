using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ItemEft/Consumable/Attack")]
public class ItemAttackEft : ItemEffect
{
    public int attackPoint = 0;
    public override bool ExecuteRole()
    {
        Knight.Instance.AttackUp(attackPoint);
        Debug.Log("PlayerAttack Add :" + attackPoint);
        return true;
    }
}
