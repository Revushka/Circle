using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public int money;
    public int earnedMoney;
    public Text moneyText;
    void Start()
    {
        money = PlayerPrefs.GetInt("Money");
        earnedMoney = PlayerPrefs.GetInt("Your score:");
        money += earnedMoney;
        PlayerPrefs.SetInt("Money", money);
        moneyText.text = money.ToString();
        earnedMoney = 0;
        PlayerPrefs.SetInt("Your score:", earnedMoney);
    }
}
