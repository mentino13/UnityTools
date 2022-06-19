using UnityEngine;

[System.Serializable]
public class Spell
{
    public int itemId;
    public string itemName;
    public int itemLevel;
    public string itemDescription;
    public string itemLatitude;
    public string itemLongitude;

    public GameObject itemPrefab;

    public void printItem(){
        Debug.Log(
            string.Format(
            "Item Id: {0} \n" +
            "Item Level: {1} \n" +
            "Item Name: {2} \n" + 
            "Item Description: {3} \n" + 
            "Item Latitude: {4} \n" +
            "Item Longitude: {5} \n",
            this.spellId.ToString(), 
            this.spellLevel.ToString(), 
            this.spellName, 
            this.spellDescription, 
            this.spellLatitude,
            this.spellLongitude)
            );
    }
}