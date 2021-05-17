using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; //魔力

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    public void Magic()
    {
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは " + mp + "。");

        }else if (mp < 5)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
        else { }
    }

}
public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //課題１

        //make Array
        int[] testArray = new int[5];

        //set Array
        for (int i=0; i < testArray.Length;i++)
        {
            testArray[i] = i + 5;

        }

        //値を順番に表示

        for (int j= 0; j < testArray.Length; j++)
        {

            Debug.Log(testArray[j]);

        }
          //値を逆順に表示

        for(int g=testArray.Length-1; g >=0; g--)
        {
            Debug.Log(testArray[g]);

        }


        //追加課題

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        for(int h=0; h <=10; h++)
        {
            lastboss.Magic();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
