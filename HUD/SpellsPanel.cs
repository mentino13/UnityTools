using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellsPanel : MonoBehaviour
{
    public GameObject buttonPrefab;
    public GameObject buttonsParent;
    public Player player;
    private Spell spell;
    public GameObject spellSpawner;
    // public GameObject spellSpawner = GameObject.Find("SpellSpawner");
    

    // Substituir por OnEnable()?
    private void Start()
    {
        foreach(Spell spell in player.spellList){
            GameObject newButton = Instantiate(buttonPrefab, buttonsParent.transform);
            newButton.GetComponent<SpellButton>().spellButtonName.text = spell.spellName;
            newButton.GetComponent<SpellButton>().spell = spell;
            newButton.GetComponent<SpellButton>().spell.spellPrefab = assignPrefab(spell);
            newButton.GetComponent<SpellButton>().spawner = GameObject.Find("SpellSpawner");
            newButton.GetComponent<Button>().onClick.AddListener(() => newButton.GetComponent<SpellButton>().shoot());
        }
    }

    private GameObject assignPrefab(Spell spell){
        if (spell.spellName == "Fireball"){
            return Resources.Load("Prefabs/SpellPrefabs/Fireball") as GameObject;
        }
        if (spell.spellName == "Water Splash"){
            return Resources.Load("Prefabs/SpellPrefabs/Water_splash") as GameObject;
        }
        if (spell.spellName == "Wind Blow"){
            return Resources.Load("Prefabs/SpellPrefabs/Wind_blow") as GameObject;
        }
        if (spell.spellName == "Healing Orb"){
            return Resources.Load("Prefabs/SpellPrefabs/Healing_orb") as GameObject;
        }
        if (spell.spellName == "Healing mist"){
            return Resources.Load("Prefabs/SpellPrefabs/Healing_mist") as GameObject;
        }
        if (spell.spellName == "Burn the spirit"){
            return Resources.Load("Prefabs/SpellPrefabs/Burn_the_spirit") as GameObject;
        }
        if (spell.spellName == "Anchor"){
            return Resources.Load("Prefabs/SpellPrefabs/Anchor") as GameObject;
        }
        if (spell.spellName == "Barbwire"){
            return Resources.Load("Prefabs/SpellPrefabs/Barbwire") as GameObject;
        }
        if (spell.spellName == "Handcuffs"){
            return Resources.Load("Prefabs/SpellPrefabs/Handcuffs") as GameObject;
        }
        if (spell.spellName == "Earth break"){
            return Resources.Load("Prefabs/SpellPrefabs/Earth_break") as GameObject;
        }
        if (spell.spellName == "Hurricane"){
            return Resources.Load("Prefabs/SpellPrefabs/Hurricane") as GameObject;
        }
        
        else
        {
            return Resources.Load("Prefabs/SpellPrefabs/SpellExample") as GameObject;
        }

    }


}
