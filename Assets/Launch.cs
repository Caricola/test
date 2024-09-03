using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //静态方法调用:类名.方法名()
        TestStatic.Test1();
        //普通类方法调用:1.先创建实例
        TestNormal instance = new TestNormal();
        instance.Test1();
        Debug.Log(instance.testNum+"|"+instance.testBool);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
