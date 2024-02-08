using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONReader : MonoBehaviour
{
public TextAsset textJSON;

[System.Serializable]
public class Player{
    public string name;
    public int health;
    public int mana;
}

[System.Serializable]

public class PlayerList 
{
    public Player []player;
}

public PlayerList myplayerlist = new PlayerList();


    // Start is called before the first frame update
    void Start()
    {
        myplayerlist = JsonUtility.FromJson<PlayerList>(textJSON.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
