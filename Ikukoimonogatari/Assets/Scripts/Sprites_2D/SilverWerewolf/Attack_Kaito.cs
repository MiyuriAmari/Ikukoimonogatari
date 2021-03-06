﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_Kaito : MonoBehaviour
{
    //種類
    public enum Kind
    {
        Kaito,//海斗
        Enemy,//敵
    };

    //攻撃対象
    public Kind AttackObject;

    BattleManager_Kaito manager;


    // Use this for initialization
    void Start()
    {
        manager = FindObjectOfType<BattleManager_Kaito>();
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
            case Kind.Kaito:
                AttackKaito();
                break;

            case Kind.Enemy:
                AttackEnemey();
                break;
        }
    }

    /// <summary>
    /// 海斗に攻撃
    /// </summary>
    void AttackKaito()
    {
        manager.DamageKaito(50);
    }

    /// <summary>
    /// 敵に攻撃
    /// </summary>
    void AttackEnemey()
    {
        manager.DamageEnemy(50);
    }
}
