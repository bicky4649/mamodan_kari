using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStop : MonoBehaviour
{
    private bool isGameStarted = false; // ゲームが開始されたかどうかを制御するフラグ
    void Update()
    {
        if (isGameStarted)
        {
            Time.timeScale = 1f; // 通常速度に戻す
            Debug.Log("Game Started!");
        }
        else
        {
            Time.timeScale = 0f;
            Debug.Log("Game Stop");
        }
    }
    public void StartGame()
    {
        isGameStarted = true; // フラグを切り替える
    }

    public void PoseGame()
    {
        isGameStarted = false; // フラグを切り替える
    }
}
