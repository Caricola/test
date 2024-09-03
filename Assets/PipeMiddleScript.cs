using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();//GameObject.FindGameObjectsWithTag("Logic"),返回的是一个数组,就相当于你用GameObject[].GetComponent(),这样不对的.GetComponent是GameObject类的一个静态方法.
       
        /*
        GameObject[] all = GameObject.FindGameObjectsWithTag("Logic");
        
        for (int i = 0; i < all.Length; i++)
        {
            logic = all[i].GetComponent<LogicScript>();
        }
        logic = GameObject.FindWithTag("").GetComponent<LogicScript>();//返回值类型不同  GameObject.FindWithTag("Tagname"):查找Tag为Tagname的游戏物体,返回的是 GameObject
        GameObject[] test = GameObject.FindGameObjectsWithTag("");//GameObject.FindGameObjectsWithTag("Tagname"):查找Tag为TagName的所有的游戏物体,返回的是一个数组GameObject[]
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //碰撞刚开始接触
    private void OnTriggerEnter2D(Collider2D Col)
    {
        Collision instance = new Collision();
        if (instance.gameObject.layer == 3)
        {
            logic.addScore();
        }
    }

    //碰撞一直在进行
    private void OnTriggerStay(Collider other)
    {
        
    }

    //碰撞的两个物体离开
    private void OnTriggerExit(Collider other)
    {
        
    }
}
