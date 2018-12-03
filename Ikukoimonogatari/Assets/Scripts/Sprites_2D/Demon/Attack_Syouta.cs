using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_Syouta : MonoBehaviour
{
    //種類
    public enum Kind
    {
        Syouta,//ショウタ
        Enemy,//敵
    };

    //攻撃対象
    public Kind AttackObject;

    BattleManager_Syouta manager;

    // Use this for initialization
    void Start()
    {
        manager = FindObjectOfType<BattleManager_Syouta>();
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
            case Kind.Syouta:
                AttackSyouta();
                break;

            case Kind.Enemy:
                AttackEnemey();
                break;
        }
    }

    /// <summary>
    /// ショウタに攻撃
    /// </summary>
    void AttackSyouta()
    {
        manager.DamageSyouta(50);
    }

    /// <summary>
    /// 敵に攻撃
    /// </summary>
    void AttackEnemey()
    {
        manager.DamageEnemy(50);
    }
}
