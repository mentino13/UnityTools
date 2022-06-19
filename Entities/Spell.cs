using UnityEngine;

[System.Serializable]
public class Spell
{
    public int spellId;
    public string spellImage;
    public string spellName;
    public string spellElement;
    public string spellLevel;
    public int spellDamage;
    public int spellManaConsumption;
    public string spellDescription;
    public string spellLatitude;
    public string spellLongitude;

    public GameObject spellPrefab;

    public void printSpell(){
        Debug.Log(
            string.Format(
            "Spell Id: {0} \n" +
            "Spell Level: {1} \n" +
            "Spell Name: {2} \n" + 
            "Spell Description: {3} \n" + 
            "Spell Element: {4} \n" + 
            "Spell Damage: {5} \n" + 
            "Spell Mana Consumption: {6} \n" + 
            "Spell Image: {7} \n" +
            "Spell Latitude: {8} \n" +
            "Spell Longitude: {9} \n",
            this.spellId.ToString(), 
            this.spellLevel.ToString(), 
            this.spellName, 
            this.spellDescription, 
            this.spellElement, 
            this.spellDamage.ToString(),
            this.spellManaConsumption.ToString(),
            this.spellImage,
            this.spellLatitude,
            this.spellLongitude)
            );
    }
}