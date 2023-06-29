using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnChess : MonoBehaviour
{
    // White Pieces
    public GameObject pawn1White;
    public GameObject pawn2White;
    public GameObject pawn3White;
    public GameObject pawn4White;
    public GameObject pawn5White;
    public GameObject pawn6White;
    public GameObject pawn7White;
    public GameObject pawn8White;
    public GameObject rook1White;
    public GameObject rook2White;
    public GameObject knight1White;
    public GameObject knight2White;
    public GameObject bishop1White;
    public GameObject bishop2White;
    public GameObject kingWhite;
    public GameObject queenWhite;

    // Black Pieces
    public GameObject pawn1Black;
    public GameObject pawn2Black;
    public GameObject pawn3Black;
    public GameObject pawn4Black;
    public GameObject pawn5Black;
    public GameObject pawn6Black;
    public GameObject pawn7Black;
    public GameObject pawn8Black;
    public GameObject rook1Black;
    public GameObject rook2Black;
    public GameObject knight1Black;
    public GameObject knight2Black;
    public GameObject bishop1Black;
    public GameObject bishop2Black;
    public GameObject kingBlack;
    public GameObject queenBlack;


    private void Start()
    {   
        // White Pieces Spawn
        Vector3 pawn1PositionW = new Vector3(-1046.487f, 68.724f, -1364.09f);
        PhotonNetwork.Instantiate(pawn1White.name, pawn1PositionW, Quaternion.identity);
        Vector3 pawn2PositionW = new Vector3(-1045.487f, 68.724f, -1364.09f);
        PhotonNetwork.Instantiate(pawn2White.name, pawn2PositionW, Quaternion.identity);
        Vector3 pawn3PositionW = new Vector3(-1044.487f, 68.724f, -1364.09f);
        PhotonNetwork.Instantiate(pawn3White.name, pawn3PositionW, Quaternion.identity);
        Vector3 pawn4PositionW = new Vector3(-1043.487f, 68.724f, -1364.09f);
        PhotonNetwork.Instantiate(pawn4White.name, pawn4PositionW, Quaternion.identity);
        Vector3 pawn5PositionW = new Vector3(-1042.487f, 68.724f, -1364.09f);
        PhotonNetwork.Instantiate(pawn5White.name, pawn5PositionW, Quaternion.identity);
        Vector3 pawn6PositionW = new Vector3(-1041.487f, 68.724f, -1364.09f);
        PhotonNetwork.Instantiate(pawn6White.name, pawn6PositionW, Quaternion.identity);
        Vector3 pawn7PositionW = new Vector3(-1040.487f, 68.724f, -1364.09f);
        PhotonNetwork.Instantiate(pawn7White.name, pawn7PositionW, Quaternion.identity);
        Vector3 pawn8PositionW = new Vector3(-1039.487f, 68.724f, -1364.09f);
        PhotonNetwork.Instantiate(pawn8White.name, pawn8PositionW, Quaternion.identity);
        Vector3 rook1PositionW = new Vector3(-1046.487f, 68.724f, -1365.133f); 
        PhotonNetwork.Instantiate(rook1White.name, rook1PositionW, Quaternion.identity);
        Vector3 rook2PositionW = new Vector3(-1039.487f, 68.724f, -1365.133f); 
        PhotonNetwork.Instantiate(rook2White.name, rook2PositionW, Quaternion.identity);
        Vector3 knight1PositionW = new Vector3(-1045.487f, 68.724f, -1365.133f); 
        PhotonNetwork.Instantiate(knight1White.name, knight1PositionW, Quaternion.identity);
        Vector3 knight2PositionW = new Vector3(-1040.487f, 68.724f, -1365.133f); 
        PhotonNetwork.Instantiate(knight2White.name, knight2PositionW, Quaternion.identity);
        Vector3 bishop1PositionW = new Vector3(-1044.487f, 68.724f, -1365.133f); 
        PhotonNetwork.Instantiate(bishop1White.name, bishop1PositionW, Quaternion.identity);
        Vector3 bishop2PositionW = new Vector3(-1041.487f, 68.724f, -1365.133f); 
        PhotonNetwork.Instantiate(bishop2White.name, bishop2PositionW, Quaternion.identity);
        Vector3 queenPositionW = new Vector3(-1043.487f, 68.724f, -1365.133f); 
        PhotonNetwork.Instantiate(queenWhite.name, queenPositionW, Quaternion.identity);
        Vector3 kingPositionW = new Vector3(-1042.487f, 68.724f, -1365.133f); 
        PhotonNetwork.Instantiate(kingWhite.name, kingPositionW, Quaternion.identity);

        // Black Pieces Spawn
        Vector3 pawn1PositionB = new Vector3(-1046.487f, 68.724f, -1359.05f);
        PhotonNetwork.Instantiate(pawn1Black.name, pawn1PositionB, Quaternion.identity);
        Vector3 pawn2PositionB = new Vector3(-1045.487f, 68.724f, -1359.05f);
        PhotonNetwork.Instantiate(pawn2Black.name, pawn2PositionB, Quaternion.identity);
        Vector3 pawn3PositionB = new Vector3(-1044.487f, 68.724f, -1359.05f);
        PhotonNetwork.Instantiate(pawn3Black.name, pawn3PositionB, Quaternion.identity);
        Vector3 pawn4PositionB = new Vector3(-1043.487f, 68.724f, -1359.05f);
        PhotonNetwork.Instantiate(pawn4Black.name, pawn4PositionB, Quaternion.identity);
        Vector3 pawn5PositionB = new Vector3(-1042.487f, 68.724f, -1359.05f);
        PhotonNetwork.Instantiate(pawn5Black.name, pawn5PositionB, Quaternion.identity);
        Vector3 pawn6PositionB = new Vector3(-1041.487f, 68.724f, -1359.05f);
        PhotonNetwork.Instantiate(pawn6Black.name, pawn6PositionB, Quaternion.identity);
        Vector3 pawn7PositionB = new Vector3(-1040.487f, 68.724f, -1359.05f);
        PhotonNetwork.Instantiate(pawn7Black.name, pawn7PositionB, Quaternion.identity);
        Vector3 pawn8PositionB = new Vector3(-1039.487f, 68.724f, -1359.05f);
        PhotonNetwork.Instantiate(pawn8Black.name, pawn8PositionB, Quaternion.identity);
        Vector3 rook1PositionB = new Vector3(-1046.487f, 68.724f, -1358.05f); 
        PhotonNetwork.Instantiate(rook1Black.name, rook1PositionB, Quaternion.identity);
        Vector3 rook2PositionB = new Vector3(-1039.487f, 68.724f, -1358.05f); 
        PhotonNetwork.Instantiate(rook2Black.name, rook2PositionB, Quaternion.identity);
        Vector3 knight1PositionB = new Vector3(-1045.487f, 68.724f, -1358.05f); 
        PhotonNetwork.Instantiate(knight1Black.name, knight1PositionB, Quaternion.identity);
        Vector3 knight2PositionB = new Vector3(-1040.487f, 68.724f, -1358.05f); 
        PhotonNetwork.Instantiate(knight2Black.name, knight2PositionB, Quaternion.identity);
        Vector3 bishop1PositionB = new Vector3(-1044.487f, 68.724f, -1358.05f); 
        PhotonNetwork.Instantiate(bishop1Black.name, bishop1PositionB, Quaternion.identity);
        Vector3 bishop2PositionB = new Vector3(-1041.487f, 68.724f, -1358.05f); 
        PhotonNetwork.Instantiate(bishop2Black.name, bishop2PositionB, Quaternion.identity);
        Vector3 queenPositionB = new Vector3(-1042.487f, 68.724f, -1358.05f); 
        PhotonNetwork.Instantiate(queenBlack.name, queenPositionB, Quaternion.identity);
        Vector3 kingPositionB = new Vector3(-1043.487f, 68.724f, -1358.05f); 
        PhotonNetwork.Instantiate(kingBlack.name, kingPositionB, Quaternion.identity);

    }



}
