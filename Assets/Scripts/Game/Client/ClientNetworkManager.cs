using Unity.Netcode;
using Unity.Netcode.Transports.UTP;
using UnityEngine;

public class ClientNetworkManager : NetworkManager
{

    void Start()
    {
        UnityTransport transport = gameObject.AddComponent<UnityTransport>();
        NetworkConfig.NetworkTransport = transport;
        StartClient();
        Debug.Log("Client Ready");
    }
}
