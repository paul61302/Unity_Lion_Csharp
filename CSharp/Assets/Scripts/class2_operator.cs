﻿
using UnityEngine;

public class class2_operator : MonoBehaviour
{
    public float a = 10;
    public float b = 3;

    public string c = "7";
    public int d = 3;

    public int e = 99;
    public int f = 9;

    public bool g = true;
    public bool h = false;

    public int key;
    public int result;

    public int hp = 100;

    //事件：開始事件 - 撥放遊戲時執行一次
    private void Start()
    {
        #region 數學運算子
        // 數學運算子：加減乘除餘 + - * / %
        print(a + b);       // 13
        print(a - b);       // 7
        print(a * b);       // 30
        print(a / b);       // 3.33333
        print(a % b);       // 1

        // 加法：串接字串與其他資料，其結果為字串
        print("分數" + 99.9f);
        // 將字串與數值類型串接在一起不會運算，其結果為字串
        print(c + d);       //結果為73
        #endregion

        #region 比較運算子
        // 比較運算子：結果為布林值，成立時true，不成立時false
        // 大於、小於、大於等於、小於等於、等於、不等於
        // >、<、>=、<=、==、!=
        print(e > f);       //t
        print(e < f);       //f
        print(e >= f);      //t
        print(e <= f);      //f
        print(e == f);      //f
        print(e != f);      //t
        #endregion

        #region 邏輯運算子
        // 邏輯運算子：結果為布林值，比較兩個布林值
        // 並且 && 只要有一個 false 結果為 false
        print("並且：" + (g && h));
        // 或者 || 只要有一個 true 結果為 true
        print("或者：" + (g || h));

        print(true && true);        //t
        print(true && false);       //f
        print(false && true);       //f
        print(false && false);      //f
        
        print(true || true);        //t
        print(true || false);       //t
        print(false || true);       //t
        print(false || false);      //f

        //顛倒運算子：加在布林值前，將布林值改為顛倒的結果
        print(!true);
        print(!false);
        #endregion

        #region 指定運算子
        // 指定運算子 = 右邊先運算再指定給左邊
        result = 2 + 3;
        print(result);

        key = key + 1;
        print("鑰匙：" + key);

        // 後置遞增 ++ ：先輸出再遞增
        print("遞增數量：" + key++);
        // 前置遞增 ++ ：先遞增再出書
        print("遞增數量：" + ++key);

        // 指派運算子：+=、-=、*=、/=、%=
        //hp = hp + 20;
        hp += 20;
        print("血量：" + hp);  // 120
        // hp = hp - 50;
        hp -= 50;
        print("血量" + hp);   // 70

        #endregion
    }
}
