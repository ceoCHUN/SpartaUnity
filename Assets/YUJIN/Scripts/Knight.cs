using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Knight : Player
{
    public static Knight Instance;
    private void Awake()
    {
        Instance = this;
    }
    public  Knight() 
    {
        id = 0;
        job = Job.Knight;
        name = "Brave Kirby";
        lv = 1;
        exp = 30;
        desc = "Kirby, a pink hero, absorbs enemies' powers for adventures in Dream Land,showcasing his unique transformative abilities";

        atk = 90;
        def = 70;
        hp = 100;
        ctk = 20;
    }

    public void HpUp(int _healingPoint)
    {
        hp += _healingPoint;
        Debug.Log("이거 되고있는거 맞니?"+ hp);
    }

    public void AttackUp(int _atkPoint)
    {
        atk += _atkPoint;
        Debug.Log("이거 되고있는거 맞니????"+atk);
    }
}
