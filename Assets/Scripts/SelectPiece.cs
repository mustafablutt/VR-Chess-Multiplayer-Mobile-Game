using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using Photon.Pun;

public abstract class SelectPiece : MonoBehaviour
{

    // Use this for initialization
    // the renderer is changed to give the selection sensation
    public Renderer groundRend;
    // this it the scrpt that manages the piece movement
    PieceMovement piecemovScript;
    public GameObject selectGo;

    public List<GameObject> myArr = new List<GameObject>();
    public bool whiteblack;
    protected virtual void Start()
    {
        piecemovScript = GameObject.FindGameObjectWithTag("pieceMovement").GetComponent<PieceMovement>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // these are the actions performed by trigge calls that simulate the over effect for selection
    public void onPieceOver()
    {
        //Debug.Log("over	");	
        groundRend.transform.rotation = Quaternion.Euler(90, 0, 0);
        groundRend.enabled = true;
    }
    public void onPieceExit()
    {
        if (piecemovScript.selectedGo != gameObject)
        {
            groundRend.enabled = false;
        }


    }

    //this is the function that allows piece selection
    public void onPieceClick()
    {
        // set lastest piece render to false (unselect) only of there is one selected and is not the same as clicked
        if (piecemovScript.selectedGo != null && piecemovScript.selectedGo != gameObject)
        {
            piecemovScript.selectedGo.transform.GetChild(0).GetComponent<Renderer>().enabled = false;
        }
        piecemovScript.selectedGo = transform.gameObject;
        // set position as this one:
        piecemovScript.lastPosition = transform.position;
    }


    // this part of the code detects collision betweem pieces
    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag != "Untagged")
        {
          
                Debug.Log("Collision Has occur");
                piecemovScript.thereIsCollision = true;
                myArr.Add(col.gameObject);
                if (col.gameObject.transform.GetComponent<ChessPiece>().team != piecemovScript.selectedGo.transform.GetComponent<ChessPiece>().team)
                {
                    Debug.Log(col.gameObject.tag);
                    if (col.gameObject.tag == "king" || col.gameObject.tag == "blackking")
                    {
                        Debug.Log("GameOver");
                        SceneManager.LoadScene("GameOver");

                    }
                    else
                    {
                        selectGo = piecemovScript.selectedGo;
                        piecemovScript.colObject = col.gameObject;
                        Destroy(col.gameObject);
                    }




                }
                else if (col.gameObject.transform.GetComponent<ChessPiece>().team == piecemovScript.selectedGo.transform.GetComponent<ChessPiece>().team) ;
                {
                    selectGo = piecemovScript.selectedGo;
                    piecemovScript.colObject = col.gameObject;

                }


            }


        }
    

    public abstract void onMultiplayerPieceOver();
    public abstract void onMultiplayerPieceExit();
    public abstract void onMultiplayerPieceClick();
    public abstract void onTriggerEnter(Collider col);




}
