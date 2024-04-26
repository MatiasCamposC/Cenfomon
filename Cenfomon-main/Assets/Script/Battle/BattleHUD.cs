using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BattleHud : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI nameText;
    [SerializeField] TextMeshProUGUI levelText;
    [SerializeField] HPBar hpBar;

    Cenfomon _cenfomon;

    public void SetData(Cenfomon cenfomon)
    {
        _cenfomon = cenfomon;

        nameText.text = cenfomon.Base.Name;
        levelText.text = "Lvl " + cenfomon.Level;
        hpBar.SetHP((float)cenfomon.HP / cenfomon.MaxHp);
    }

    public IEnumerator UpdateHP()
    {
        yield return hpBar.SetHPSmooth((float)_cenfomon.HP / _cenfomon.MaxHp);
    }
}

