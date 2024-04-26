using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Cenfomon", menuName = "Cenfomon/Create new cenfomon")]
public class CenfomonBase : ScriptableObject
{
    [SerializeField] string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite frontSprite;
    [SerializeField] Sprite backSprite;

    [SerializeField] CenfomonType type1;
    [SerializeField] CenfomonType type2;

    // Base Stats
    [SerializeField] int maxHp;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int spAttack;
    [SerializeField] int spDefense;
    [SerializeField] int speed;

    [SerializeField] List<LearnableMove> learnableMoves;

    public string Name
    {
        get { return name; }
    }


    public Sprite FrontSprite
    {
        get { return frontSprite; }
    }

    public Sprite BackSprite
    {
        get { return backSprite; }
    }

    public CenfomonType Type1
    {
        get { return type1; }
    }

    public CenfomonType Type2
    {
        get { return type2; }
    }

    public int MaxHp
    {
        get { return maxHp; }
    }

    public int Attack
    {
        get { return attack; }
    }

    public int SpAttack
    {
        get { return spAttack; }
    }

    public int Defense
    {
        get { return defense; }
    }

    public int SpDefense
    {
        get { return spDefense; }
    }

    public int Speed
    {
        get { return speed; }
    }

    public List<LearnableMove> LearnableMoves
    {
        get { return learnableMoves; }
    }
}

[System.Serializable]
public class LearnableMove
{
    [SerializeField] MoveBase moveBase;
    [SerializeField] int level;

    public MoveBase Base
    {
        get { return moveBase; }
    }

    public int Level
    {
        get { return level; }
    }
}

public enum CenfomonType
{
    Ninguno,
    Agua,
    Fuego,
    Planta,
    Normal,
    Electrico,
    Fantasma,
    Volador,
    Bicho
}

public class TypeChart
{
    static float[][] chart =
    {
        //                  NOR   FIR   WAT   ELE  GRA  ICE  FIG  POI               
        /*NOR*/ new float[] { 1f,  1f,   1f,  1f,  1f,  1f,  1f,  1f },
        /*FUE*/ new float[] { 1f, 0.5f, 0.5f, 1f,  2f,  2f,  1f,  1f },
        /*AGU*/ new float[] { 1f,  2f,  0.5f, 2f, 0.5f, 1f,  1f,  1f },
        /*ELE*/ new float[] { 1f,  1f,  2f,  0.5f,0.5f, 2f,  1f,  1f },
        /*NOR*/ new float[] { 1f, 0.5f, 2f,   2f, 0.5f, 1f,  1f, 0.5f },
        /*FAN*/ new float[] { 1f,  1f,   1f,  1f,  2f,  1f,  1f,  1f }
    };

    public static float GetEffectiveness(CenfomonType attackType, CenfomonType defenseType)
    {
        if (attackType == CenfomonType.Ninguno || defenseType == CenfomonType.Ninguno)
            return 1;

        int row = (int)attackType - 1;
        int col = (int)defenseType - 1;

        return chart[row][col];
    }
}
