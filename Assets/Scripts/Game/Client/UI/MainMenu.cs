using System.Collections;
using System.Collections.Generic;
using Game.Client;
using Game.Model;
using GameServices;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private UIManager _uiManager;
    
    async void Start()
    {
        if (PlayerPrefs.HasKey("Gamertag"))
        {
            string Gamertag = PlayerPrefs.GetString("Gamertag");
            Player player = await PlayerService.GetPlayer("steam_id", Gamertag);
            Debug.Log($"Player retrieved: {player.Gamertag}");
        }
        else
        {
            _uiManager.ShowCreatePlayerScreen();
            UIManager.OnCreatePlayer += CreateUser;
        }   
    }

    private async void CreateUser(string gamertag)
    {
        //Call playerservice to create the player
        Debug.Log($"Creating player: {gamertag}");
        Player player = await PlayerService.CreatePlayer(gamertag);
        Debug.Log($"Player created: {player.Gamertag}");
        PlayerPrefs.SetString("Gamertag", player.Gamertag);
    }
}
