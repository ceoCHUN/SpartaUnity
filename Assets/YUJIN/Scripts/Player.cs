using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Job
{
    None,
    Knight,
    Magician,
    Archer
}
public class Player : MonoBehaviour
{
    // ĳ���� ����
    public int id;
    public Job job;
    public string name;
    public int lv;
    public int exp;
    public string desc;

    public int atk;
    public int def;
    public int hp;
    public int ctk;

    // ������(null�� ����)
    public Player()
    {
        id = 0;
        job = Job.None;
        name = string.Empty;
        lv = 0;
        exp = 0;
        desc = "";

        atk = 0;
        def = 0;
        hp = 0;
        ctk = 0;
    }
}
