using Photon.Pun;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PhotonView))]

public class MultiplayerChessSquare : ChessSquare
{
    private PhotonView photonView;

    
    public override void onMultiplayerClickSquare()
    {
        photonView.RPC(nameof(RPC_onClickSquare), RpcTarget.AllBuffered, null);
    }

    [PunRPC]
    public void RPC_onClickSquare()
    {
        onClickSquare();
    }

    
    public override void onMultiplayerExitSquare()
    {
        photonView.RPC(nameof(RPC_onExitSquare), RpcTarget.AllBuffered, null);
    }
    [PunRPC]
    public void RPC_onExitSquare()
    {
        onExitSquare();
    }

    [PunRPC]
    public override void onMultiplayerOverSquare()
    {
        photonView.RPC(nameof(RPC_onOverSquare), RpcTarget.AllBuffered, null);
    }
    [PunRPC]
    public void RPC_onOverSquare()
    {
        onOverSquare();
    }
    
    protected override void Start()
    {
        base.Start();
        photonView = GetComponent<PhotonView>();

    }
}

