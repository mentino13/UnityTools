using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Player : MonoBehaviour
{
    // Base Stats:
    public string playerName;
    public int playerLevel;
    public int initialHitpoints;
    public int initialMana;


    // Current Stats:
    public int currentExperience;
    public int currentHitpoints;
    public int currentMana;


    // Spell List:
    public List<Item> playerItems;


    // Equipment:
    public Gear[] playerGear;


    private void Awake() {
        // this.spellList = new List<Spell>();
        this.playerItems = APIHelper.GetItems(this);
        this.initialHitpoints = 100;
        this.initialMana = 100;

        this.currentHitpoints = initialHitpoints;
        this.currentMana = initialMana;



        foreach(Item item in this.playerItems){
            Debug.Log("PlayerItems: " + playerItems.Count);
            item.printItem();
            
        }
    }

    

}