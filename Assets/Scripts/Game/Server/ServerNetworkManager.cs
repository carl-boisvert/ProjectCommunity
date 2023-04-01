using System;
using Unity.Netcode;
using Unity.Netcode.Transports.UTP;


public class ServerNetworkManager : NetworkManager
{
    private void OnEnable()
    {
        UnityTransport transport = gameObject.AddComponent<UnityTransport>();
        NetworkConfig.NetworkTransport = transport;
        
        OnServerStarted += OnServerStartedCallback;
        OnClientConnectedCallback += OnClientConnected;
        OnClientDisconnectCallback += OnClientDisconnect;

        StartServer();
    }

    private void OnClientDisconnect(ulong obj)
    {
        Console.WriteLine("Client disconnected");
    }

    private void OnClientConnected(ulong obj)
    {
        Console.WriteLine("New client connected");
    }

    private void OnServerStartedCallback()
    {
        Console.WriteLine("Server listening for connection...");
    }
}
