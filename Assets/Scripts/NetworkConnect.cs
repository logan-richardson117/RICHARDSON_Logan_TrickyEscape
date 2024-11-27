using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;

public class NetworkConnect : MonoBehaviour
{

public void CreateHost()
    {
        NetworkManager.Singleton.StartHost();
    }
    public void JoinClient()
    {
        NetworkManager.Singleton.StartClient();
    }
}

