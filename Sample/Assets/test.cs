using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int age;
        float height1 = 160.5f;
        float height2;
        string name;
        int answer = 1 + 2;
        string str1 = "happy";
        string str2 = "birthay";
        string mesage;
        int herbNum = 1;
        int hp = 150;

        age = 19;
        height2 = height1;
        name = "kitamura";
        mesage = str1 + str2;

        if(herbNum == 1)
        {
            Debug.Log("HPが50回復");
        }

        if (hp <= 50)
        {
            Debug.Log("逃走！");
        }else if(hp >= 200)
        {
            Debug.Log("攻撃！");
        }
        else
        {
            Debug.Log("防御!");
        }

        for(int i = 0;i < 5; i++)
        {
            Debug.Log(i);
        }
        for(int i = 0; i < 10;i+= 2)
        {
            Debug.Log(i);
        }
        for(int i = 3;i <= 5; i++) {
            Debug.Log(i);
        }
        for(int i = 3;i >= 0; i--)
        {
            Debug.Log(i);
        }
        int sum = 0;
        for(int i = 1;i <= 10; i++)
        {
            sum += i;
        }

        Debug.Log("Hello,World");
        Debug.Log(age);
        Debug.Log(height2);
        Debug.Log(name);
        Debug.Log(answer);
        Debug.Log(mesage);
        Debug.Log(sum);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
