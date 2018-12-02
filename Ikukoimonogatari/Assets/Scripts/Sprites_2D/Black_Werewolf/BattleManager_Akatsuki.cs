using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// バトルマネージャ
/// </summary>
public class BattleManager_Akatsuki : MonoBehaviour
{

    /// <summary>
    /// The hp max.
    /// </summary>
    public int HP_MAX = 100;

    [Header("暁のHP")]
    public int AKATSUKI_HP = 100;
    [Header("敵のHP")]
    public int ENEMY_HP = 100;

    public Slider AkatsukiHP_Slider;
    public Slider EnemyHP_Slider;


    // Use this for initialization
    void Start()
    {
        AkatsukiHP_Slider.maxValue = HP_MAX;
        EnemyHP_Slider.maxValue = HP_MAX;

        AKATSUKI_HP = Mathf.Clamp(AKATSUKI_HP, 0, HP_MAX);
        ENEMY_HP = Mathf.Clamp(ENEMY_HP, 0, HP_MAX);
    }

    // Update is called once per frame
    void Update()
    {
#if true
        AkatsukiHP_Slider.value = AKATSUKI_HP;
        EnemyHP_Slider.value = ENEMY_HP;
#else
        AkatsukiHP_Slider.value = (AkatsukiHP_Slider.value + AKATSUKI_HP) * 0.5f;
        EnemyHP_Slider.value = (EnemyHP_Slider.value + ENEMY_HP) * 0.5f;
#endif
    }

    /// <summary>
    /// 暁にダメージを与える
    /// </summary>
    /// <param name="damage">Damage.</param>
    public void DamageAkatsuki(int damage)
    {
        AKATSUKI_HP -= damage;
        AKATSUKI_HP = Mathf.Clamp(AKATSUKI_HP, 0, HP_MAX);
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
