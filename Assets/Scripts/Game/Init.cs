using Steamworks;
using TMPro;
using UnityEngine;

public class Init : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _gamertag;
    void Start() 
    {
        if (SteamManager.Initialized)
        {
            string gamertag = SteamFriends.GetPersonaName();
            _gamertag.text = gamertag;
        }
    }
}
