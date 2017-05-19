using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetworkManagerCustom : NetworkManager
{
    
    public override void ServerChangeScene(string newSceneName)
    {
        //base.ServerChangeScene(newSceneName);
        print("ServerChangeScene " + newSceneName);
    }

    public override void OnServerSceneChanged(string sceneName)
    {
        print("OnServerSceneChanged");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            base.ServerChangeScene("Main");
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            networkAddress = "10.0.1.8";
            StartClient();
        }
    }

    public override void OnServerConnect(NetworkConnection conn)
    {
        base.OnServerConnect(conn);
        print("OnServerConnect ");
    }
}
