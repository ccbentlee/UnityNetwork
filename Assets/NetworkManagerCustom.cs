using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetworkManagerCustom : NetworkManager
{
    public override void OnStartHost()
    {
        base.OnStartHost();
        print("OnStartHost");
    }

    public override void OnStartServer()
    {
        base.OnStartServer();
        print("OnStartServer");
    }

    public override void OnServerConnect(NetworkConnection conn)
    {
        base.OnServerConnect(conn);
        print("OnServerConnect");
    }

    public override void OnStartClient(NetworkClient client)
    {
        base.OnStartClient(client);
        print("OnStartClient");
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        base.OnClientConnect(conn);
        print("OnClientConnect");
    }

    public override void OnServerSceneChanged(string sceneName)
    {
        base.OnServerSceneChanged(sceneName);
        print("OnServerSceneChanged");
    }

    public override void OnServerReady(NetworkConnection conn)
    {
        base.OnServerReady(conn);
        print("OnServerReady");
    }

    public override void OnClientSceneChanged(NetworkConnection conn)
    {
        base.OnClientSceneChanged(conn);
        print("OnClientSceneChanged");
    }
}
