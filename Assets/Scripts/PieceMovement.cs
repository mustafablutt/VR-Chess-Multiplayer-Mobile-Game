using UnityEngine;
using System.Collections;

public abstract class PieceMovement : MonoBehaviour
{

    // Use this for initialization
    // this is the piece that is selected
    public GameObject selectedGo;
    public GameObject colObject;
    public int timeToMove = 2;
    public SelectPiece sp;

    //these variables are used to un-do the movement in case of a collision between pieces
    public bool thereIsCollision = false;
    public Collision col;
    public Vector3 lastPosition;

    protected virtual void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void movePiece(GameObject groundPoint)
    {
        Debug.Log("move piece");
        StartCoroutine(moveToObjective(groundPoint.transform.position));

    }

    IEnumerator moveToObjective(Vector3 position)
    {
        float elapsed = 0;
        position += new Vector3(0, 0, 0);

        // linear movement
        while (elapsed <= timeToMove && thereIsCollision == false)
        {
            selectedGo.transform.position = (position - selectedGo.transform.position) * elapsed / timeToMove + selectedGo.transform.position;
            elapsed += Time.fixedDeltaTime;

            yield return new WaitForFixedUpdate();
        }
        Debug.Log("fsdfsd" + colObject.transform.GetComponent<ChessPiece>().team + selectedGo.transform.GetComponent<ChessPiece>().team);

        if (thereIsCollision == true && colObject.transform.GetComponent<ChessPiece>().team == selectedGo.transform.GetComponent<ChessPiece>().team)
        {

            Debug.Log("Debug1");
            elapsed = 0;
            while (elapsed <= timeToMove)
            {
                selectedGo.transform.position = (lastPosition - selectedGo.transform.position) * elapsed / timeToMove + selectedGo.transform.position;
                elapsed += Time.fixedDeltaTime;
                Debug.Log("3");
                yield return new WaitForFixedUpdate();

            }
            // deactivate the piece
            Debug.Log("2qweqweq");
            selectedGo.transform.GetChild(0).GetComponent<Renderer>().enabled = false;
            selectedGo.transform.position = lastPosition;
            selectedGo = null;
            colObject = null;
            thereIsCollision = false;

            Debug.Log("2");



        }
        else if (thereIsCollision == true && colObject.transform.GetComponent<ChessPiece>().team != selectedGo.transform.GetComponent<ChessPiece>().team)
        {
            Debug.Log("Debug1123123");
            elapsed = 0;
            while (elapsed <= timeToMove)
            {
                //selectedGo.transform.position = (lastPosition - selectedGo.transform.position) * elapsed / timeToMove + selectedGo.transform.position;
                elapsed += Time.fixedDeltaTime;
                Debug.Log("123123123");
                yield return new WaitForFixedUpdate();

            }
            Debug.Log("44234324234232");
            // deactivate the piece
            selectedGo.transform.GetChild(0).GetComponent<Renderer>().enabled = false;
            selectedGo.transform.position = position;
            selectedGo = null;
            colObject = null;
            thereIsCollision = false;
            Debug.Log("51231212313123123");
        }
        else
        {

            Debug.Log("4");
            // deactivate the piece
            selectedGo.transform.GetChild(0).GetComponent<Renderer>().enabled = false;
            selectedGo.transform.position = position;
            selectedGo = null;
            Debug.Log("5");
        }






    }

    public abstract void SelectedPieceMoved(GameObject groundPoint);


}
