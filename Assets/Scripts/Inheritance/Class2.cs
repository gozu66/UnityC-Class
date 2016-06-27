using UnityEngine;
using System.Collections;

public class Class2 : Class1
{
    void Start()
    {
        print(Class1Name);
    }

	void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            MyMethod();
        }

        if (Input.GetMouseButtonDown(2))
        {
            StaticClass.DisplayName("gameobject");
        }
        }
}
