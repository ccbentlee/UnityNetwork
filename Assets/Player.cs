using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class Player : NetworkBehaviour
{
    public int num = 10;

    void Start()
    {
        num = 10;
    }

    void Update()
    {
        GetComponent<TextMesh>().text = num.ToString();
        if (!isLocalPlayer)
        {
            return;
        }

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 5f;
        transform.Translate(x, 0, 0);

        if (Input.GetKeyDown(KeyCode.R))
        {
            CmdnormalPlus();
        }
    }

    [CommandAttribute]
    void CmdnormalPlus()
    {
        num++;
        RpcnormalPlus();
    }

    [ClientRpcAttribute]
    void RpcnormalPlus()
    {
        num++;
    }
}
