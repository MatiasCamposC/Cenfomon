using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "Pokemon/Create new move")]
public class MoveBase : ScriptableObject
{
    [SerializeField] string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] CenfomonType type;
    [SerializeField] int power;
    [SerializeField] int accuracy;
    [SerializeField] int pp;

    public string Name {
        get { return name; }
    }

    public string Description {
        get { return description; }
    }

    public CenfomonType Type {
        get { return type; }
    }

    public int Power {
        get { return power; }
    }

    public int Accuracy {
        get { return accuracy; }
    }

    public int PP {
        get { return pp; }
    }

    public bool IsSpecial {
        get {
            if (type == CenfomonType.Fuego || type == CenfomonType.Agua || type == CenfomonType.Planta
                || type == CenfomonType.Normal || type == CenfomonType.Electrico || type == CenfomonType.Fantasma || type == CenfomonType.Volador || type == CenfomonType.Bicho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
