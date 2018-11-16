using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// バトルマネージャ
/// </summary>
public class BattleManager : MonoBehaviour
{

    /// <summary>
    /// The hp max.
    /// </summary>
    public int HP_MAX = 100;

    [Header("アキラのHP")]
    public int AKIRA_HP = 100;
    [Header("敵のHP")]
    public int ENEMY_HP = 100;

    public Slider AkiraHP_Slider;
    public Slider EnemyHP_Slider;


    // Use this for initialization
    void Start()
    {
        AkiraHP_Slider.maxValue = HP_MAX;
        EnemyHP_Slider.maxValue = HP_MAX;

        AKIRA_HP = Mathf.Clamp(AKIRA_HP, 0, HP_MAX);
        ENEMY_HP = Mathf.Clamp(ENEMY_HP, 0, HP_MAX);
    }

    // Update is called once per frame
    void Update()
    {
#if true
        AkiraHP_Slider.value = AKIRA_HP;
        EnemyHP_Slider.value = ENEMY_HP;
#else
        AkiraHP_Slider.value = (AkiraHP_Slider.value + AKIRA_HP) * 0.5f;
        EnemyHP_Slider.value = (EnemyHP_Slider.value + ENEMY_HP) * 0.5f;
#endif
    }

    /// <summary>
    /// アキラにダメージを与える
    /// </summary>
    /// <param name="damage">Damage.</param>
    public void DamageAkira( int damage )
    {
        AKIRA_HP -= damage;
        AKIRA_HP = Mathf.Clamp(AKIRA_HP, 0, HP_MAX);
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
