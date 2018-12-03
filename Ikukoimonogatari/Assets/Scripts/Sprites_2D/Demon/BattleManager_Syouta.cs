using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// バトルマネージャ
/// </summary>
public class BattleManager_Syouta : MonoBehaviour
{

    /// <summary>
    /// The hp max.
    /// </summary>
    public int HP_MAX = 100;

    [Header("ショウタのHP")]
    public int SYOUTA_HP = 100;
    [Header("敵のHP")]
    public int ENEMY_HP = 100;

    public Slider SyoutaHP_Slider;
    public Slider EnemyHP_Slider;


    // Use this for initialization
    void Start()
    {
        SyoutaHP_Slider.maxValue = HP_MAX;
        EnemyHP_Slider.maxValue = HP_MAX;

        SYOUTA_HP = Mathf.Clamp(SYOUTA_HP, 0, HP_MAX);
        ENEMY_HP = Mathf.Clamp(ENEMY_HP, 0, HP_MAX);
    }

    // Update is called once per frame
    void Update()
    {
#if true
        SyoutaHP_Slider.value = SYOUTA_HP;
        EnemyHP_Slider.value = ENEMY_HP;
#else
        SyoutaHP_Slider.value = (SyoutaHP_Slider.value + SYOUTA_HP) * 0.5f;
        EnemyHP_Slider.value = (EnemyHP_Slider.value + ENEMY_HP) * 0.5f;
#endif
    }

    /// <summary>
    /// ショウタにダメージを与える
    /// </summary>
    /// <param name="damage">Damage.</param>
    public void DamageSyouta(int damage)
    {
        SYOUTA_HP -= damage;
        SYOUTA_HP = Mathf.Clamp(SYOUTA_HP, 0, HP_MAX);
    }

    /// <summary>
    /// 敵にダメージを与える
    /// </summary>
    /// <param name="damage">Damage.</param>
    public void DamageEnemy(int damage)
    {
        ENEMY_HP -= damage;
        ENEMY_HP = Mathf.Clamp(ENEMY_HP, 0, HP_MAX);
    }
}
