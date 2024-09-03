using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestNormal
{
    public int testNum;
    public bool testBool;
    public int a;
    public int b;
    public void Test1()
    {
        a = -10;
        b = 0;
        Debug.Log(222);
int c=a>b?1:-1;
Debug.Log("C:"+c);
    }
    
    //构造方法

    public TestNormal()
    {
        testNum = 1;
        testBool = true;
    }
}
