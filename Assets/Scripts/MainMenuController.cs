using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

    Animator anim;

    public string newGameSceneName;
    public int quickSaveSlotID;

    [Header("Options Panel")]
    public GameObject MainOptionsPanel;
    public GameObject StartGameOptionsPanel;
    public GameObject GamePanel;
    public GameObject ControlsPanel;
    public GameObject GfxPanel;
    public GameObject LoadGamePanel;

    
    void Start() {
      //  anim = GetComponent<Animator>();


        //PlayerPrefs.SetInt("quickSaveSlot", quickSaveSlotID);

        Cursor.visible = true;
    }





    public void openStartGameOptions()
    {

        SceneManager.LoadScene("LOADING");

    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }


}
