using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellButton : MonoBehaviour
{

    public Spell spell;
    public Text spellButtonName;
    public GameObject spawner;

    public void InstantiateSpell(){
        GameObject go = (GameObject)Instantiate(spell.spellPrefab, spawner.transform.position, spawner.transform.rotation);

        
       

    }

    public void shoot(){
        InstantiateSpell();

    }

}
    