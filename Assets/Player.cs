using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class Player : NetworkBehaviour
{
    public int num = 10;

    void Start()
    {
        num = Random.Range(1, 100);
        GetComponent<TextMesh>().text = num.ToString();
    }

    void Update()
    {
        // GetComponent<TextMesh>().text = num.ToString();
        if (!isLocalPlayer)
        {
            return;
        }

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 5f;
        transform.Translate(x, 0, 0);

        if (Input.GetKeyDown(KeyCode.R))
        {
            CmdnormalPlus(num);
        }
    }

    [CommandAttribute]
    void CmdnormalPlus(int n)
    {
        RpcnormalPlus(n);
    }

    [ClientRpcAttribute]
    void RpcnormalPlus(int n)
    {
        n++;
        GetComponent<TextMesh>().text = n.ToString();
    }
}
