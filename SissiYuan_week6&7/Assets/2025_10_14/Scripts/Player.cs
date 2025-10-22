using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2025_10_14 : MonoBehaviour
{
    public int bulletCount = 10;
    public float health = 50.50f;
    public double money = 100.5;
    public string playerName = "Xiao Ming";
    public bool canShoot = false;
    public Transform tf;

    private void Start()
    {
        
    }

    private void Update()
    {
        money = AddMoney(money, 5);
        tf.position = AddPosition(tf.position, new Vector3(0.01f, 0, 0));
    }
    double AddMoney(double currentMoney, double addAmount)
    {
        return currentMoney + addAmount;
    }
    Vector3 AddPosition(Vector3 currentPosition, Vector3 addPosition)
    {
        return currentPosition + addPosition;
    }
}

//类

//变量
//基本类型
//数字 int float double
//文本 char string
//布尔 bool
//非基本类型

//函数
//返回值类型 函数名 参数列表 函数体
