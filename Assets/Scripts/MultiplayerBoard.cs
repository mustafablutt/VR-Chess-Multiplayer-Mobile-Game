using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System;

[RequireComponent(typeof(PhotonView))]
public class MultiplayerBoard : SelectPiece
{
    protected override void Start()
    {
        base.Start();   
        photonView = GetComponent<PhotonView>();
    }

    private PhotonView photonView;
    [PunRPC]
    public void RPC_onPieceExit (){ 
    onPieceExit ();
    }

    [PunRPC]
    public void RPC_onPieceOVer () { 
        onPieceOver();
    
    }

    public override void onMultiplayerPieceOver()
    {
        photonView.RPC(nameof(RPC_onPieceOVer), RpcTarget.AllBuffered, null);
    }
    public override void onMultiplayerPieceExit()
    {
        photonView.RPC(nameof(RPC_onPieceExit), RpcTarget.AllBuffered, null);
    }
    public override void onMultiplayerPieceClick()
    {
        photonView.RPC(nameof(RPC_onPieceClick), RpcTarget.AllBuffered, null);
    }
    [PunRPC]
    public void RPC_onPieceClick()
    {
        onPieceClick();
    } 

    
    public override void onTriggerEnter(Collider col)
    {
        photonView.RPC(nameof(RPC_onTriggerEnter), RpcTarget.AllBuffered, null);
    }

    [PunRPC]
    public void RPC_onTriggerEnter(Collider col)
    {
        onTriggerEnter(col);
    }
}
