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

//��

//����
//��������
//���� int float double
//�ı� char string
//���� bool
//�ǻ�������

//����
//����ֵ���� ������ �����б� ������
