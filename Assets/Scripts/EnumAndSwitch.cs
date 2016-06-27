using UnityEngine;
using System.Collections;

public class EnumAndSwitch : MonoBehaviour
{
    public enum Types
    {
        type1,
        type2,
        type3,
    };

    public Types _types;

    void Update()
    {
        switch(_types)
        {
            case Types.type1:
                print(1);
                break;

            case Types.type2:
                print(2);
                break;

            case Types.type3:
                print(3);
                break;
        }
    }
}