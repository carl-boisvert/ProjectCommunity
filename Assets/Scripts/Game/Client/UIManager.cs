using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Client
{
    public class UIManager : MonoBehaviour
    {
        #region Delegates

        public delegate void CreatePlayer(string gamertag);
        public static event CreatePlayer OnCreatePlayer;
        

        #endregion
        
        #region MainMenu
        [Header("MainMenu")]
        [SerializeField] private GameObject _createPlayerScreen;
        [SerializeField] private TextMeshProUGUI _gamertagText;
        [SerializeField] private Button _submitGamertagButton;
        #endregion

        public void ShowCreatePlayerScreen()
        {
            _createPlayerScreen.SetActive(true);
            _submitGamertagButton.onClick.AddListener(OnGamertagSubmit);
        }

        private void OnGamertagSubmit()
        {
            string gamertag = _gamertagText.text;
            OnCreatePlayer?.Invoke(gamertag);
        }
    }
}