﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class Player : NetworkBehaviour
{
    [SyncVar]
    public int number;
}
