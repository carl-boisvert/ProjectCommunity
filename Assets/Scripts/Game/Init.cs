using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class Init : MonoBehaviour
{
    
    [SerializeField] private GameObject _serverGo;
    [SerializeField] private GameObject _clientGo;
    
    void Start() 
    {
        if (SystemInfo.graphicsDeviceType == GraphicsDeviceType.Null)
        {
            Console.WriteLine("Server Build");
            Instantiate(_serverGo);
        }
        else
        {
            Debug.Log("Client Build");
            Instantiate(_clientGo);
        }
        
        Destroy(gameObject);
    }
}
