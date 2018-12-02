using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// バトルマネージャ
/// </summary>
public class BattleManager_Kaito : MonoBehaviour
{

    /// <summary>
    /// The hp max.
    /// </summary>
    public int HP_MAX = 100;

    [Header("海斗のHP")]
    public int KAITO_HP = 100;
    [Header("敵のHP")]
    public int ENEMY_HP = 100;

    public Slider KaitoHP_Slider;
    public Slider EnemyHP_Slider;


    // Use this for initialization
    void Start()
    {
        KaitoHP_Slider.maxValue = HP_MAX;
        EnemyHP_Slider.maxValue = HP_MAX;

        KAITO_HP = Mathf.Clamp(KAITO_HP, 0, HP_MAX);
        ENEMY_HP = Mathf.Clamp(ENEMY_HP, 0, HP_MAX);
    }

    // Update is called once per frame
    void Update()
    {
#if true
        KaitoHP_Slider.value = KAITO_HP;
        EnemyHP_Slider.value = ENEMY_HP;
#else
        KaitoHP_Slider.value = (KaitoHP_Slider.value + KAITO_HP) * 0.5f;
        EnemyHP_Slider.value = (EnemyHP_Slider.value + ENEMY_HP) * 0.5f;
#endif
    }

    /// <summary>
    /// 海斗にダメージを与える
    /// </summary>
    /// <param name="damage">Damage.</param>
    public void DamageKaito(int damage)
    {
        KAITO_HP -= damage;
        KAITO_HP = Mathf.Clamp(KAITO_HP, 0, HP_MAX);
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
