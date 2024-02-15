using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class JSON : MonoBehaviour 
{
    public InputField playerInputField;
    public InputField healthInputField;
    public InputField manaInputField;

    public void Save()
    {
        PlayerData data = new PlayerData();
        data.Player = playerInputField.text;
        data.Health = int.Parse(healthInputField.text);
        data.Mana = int.Parse(manaInputField.text);

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(Application.dataPath + "/PlayerDataFile.json", json);
    }

    
    public void Load()
    {
        string json = File.ReadAllText(Application.dataPath + "/PlayerDataFile.json");
        PlayerData data = JsonUtility.FromJson<PlayerData>(json);

        playerInputField.text = data.Player;
        healthInputField.text = data.Health.ToString();
        manaInputField.text = data.Mana.ToString();
    }
    
}
