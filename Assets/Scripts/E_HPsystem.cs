using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class E_HPsystem : MonoBehaviour
{
    public float HPlimit = 5f;  //
    private float now_HP; 
    public Attack_gauge attack_gauge;
    public Slider HPGauge;   //

    void Start()
    {
        now_HP = HPlimit;
        HPGauge.value = 1f;  //
    }

    void Update()
    {
        now_HP = Damage_chance(now_HP); //now_HPを更新
        float h = now_HP/HPlimit;
        HPGauge.value = Mathf.Lerp(0f, 1f, h); //開始（1）,終わり（0）,0~1
    }

    float Damage_chance(float now_HP)
    {
        if (attack_gauge.attack == true)
        {
            float new_HP = now_HP - attack_gauge.damage;//HP更新
            return new_HP;
        }
        return now_HP;
    }
}
