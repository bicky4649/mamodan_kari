using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack_gauge : MonoBehaviour
{
    public float limit = 5f;  // 制限時間
    float now = 0f; // 経過時間
    public Slider timerGauge;   //残り時間ゲージ
    public bool attack = false;

    public float damage = 1f;

    void Start()
    {
        timerGauge.value = 0f;  //制限時間ゲージ
    }

    void Update()
    {
        now += Time.deltaTime; // タイマー
        float t = now / limit; // スライダーの値ー正規化
        timerGauge.value = Mathf.Lerp(0f, 1f, t); //開始（0）,終わり（1）,0~1
        if (now > limit)
        {
            attack = true;
            now = 0f;
        }
    }
}
