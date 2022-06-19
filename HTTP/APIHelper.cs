using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//To deal with HTTP net responses:
using System.Net;

// To instantiate streamreader to read http responses:
using System.IO;

public static class APIHelper
{
    // This method will return a Item:
    public static Item GetItem(int itemId){
        // We create the request:
        string url = "";
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url+spellId.ToString());

        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        StreamReader reader = new StreamReader(response.GetResponseStream());

        string json = reader.ReadToEnd();
        Debug.Log(json);
        
        return JsonUtility.FromJson<Item>(json);


    }

    // Get the list of all items and returns it:
    public static List<Item> GetItems(Player player){
        string url = "";
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        StreamReader reader = new StreamReader(response.GetResponseStream());

        string json = reader.ReadToEnd();

         json = "{\"Items\":"+ json + "}";

        Item [] itemList = JsonHelper.FromJson<Item>(json);

        List<Item> itemsList = new List<Item>();

        foreach(Item item in itemsList){
            item.printItem();
            itemsList.Add(item);
        }

        return itemsList;
    }



}
    
