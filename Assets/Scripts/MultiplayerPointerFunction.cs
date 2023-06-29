using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System;

[RequireComponent(typeof(PhotonView))]
public class MultiplayerPointerFunction : PointerFunctions
{
    private PhotonView photonView;

    public override void MultiplayerOnGazeExit()
    {
        photonView.RPC(nameof(RPC_onGazeExit), RpcTarget.AllBuffered, null);
    }
    [PunRPC]
    public void RPC_onGazeExit()
    {
        onGazeExit();
    }

    [PunRPC]
    public void RPC_onGazeOVer()
    {
        onGazeOver();
    }

    public override void MultiplayerOnGazeOver()
    {
        photonView.RPC(nameof(RPC_onGazeOVer), RpcTarget.AllBuffered, null);
    }

    protected override void Start()
    {
        base.Start();
        photonView = GetComponent<PhotonView>();
    }
}
