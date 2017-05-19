using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetworkManagerCustom : NetworkManager
{

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(2f);
        StartServer();
    }

    public override void OnStartServer()
    {
        print("onstartserver");
    }

    public override void ServerChangeScene(string newSceneName)
    {
        base.ServerChangeScene(newSceneName);
        print("ServerChangeScene " + newSceneName);
    }

    public override void OnServerSceneChanged(string sceneName)
    {
        print("OnServerSceneChanged");

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            ServerChangeScene("offline");
        }
    }

}
