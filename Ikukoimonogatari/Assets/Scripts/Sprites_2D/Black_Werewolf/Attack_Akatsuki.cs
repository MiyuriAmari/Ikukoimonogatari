using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_Akatsuki : MonoBehaviour
{
    //種類
    public enum Kind
    {
        Akatsuki,//暁
        Enemy,//敵
    };

    //攻撃対象
    public Kind AttackObject;

    BattleManager manager;


    // Use this for initialization
    void Start()
    {
        manager = FindObjectOfType<BattleManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// 自身の敵を攻撃
    /// </summary>
    public void AttackMyEnemy()
    {
        switch (AttackObject)
        {
            case Kind.Akatsuki:
                AttackAkatsuki();
                break;

            case Kind.Enemy:
                AttackEnemey();
                break;
        }
    }

    /// <summary>
    /// 暁に攻撃
    /// </summary>
    void AttackAkatsuki()
    {
        manager.DamageAkatsuki(50);
    }

    /// <summary>
    /// 敵に攻撃
    /// </summary>
    void AttackEnemey()
    {
        manager.DamageEnemy(50);
    }
}
