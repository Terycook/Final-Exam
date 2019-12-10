using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//THIS SCRIPT IS ATTACHED TO THE DATA MANAGER OBJECT PRESENT IN All THE SCENES

public class KeepData : MonoBehaviour
{
    // STATIC so they are preserved between classes
    //public static string PlayerName;
    //public static int PlayerRounds;
    public static float PlayingSize;
    public static int PlayingSpeed;
   

    //public InputField PlayerNameInput;
    public Slider SizeSlider;
    public Dropdown SpeedDropDown;
    //lives are hard coded

    //public Text showPlayerName; // don't forget to drop the hierarchy objects in the script slots in the inspector
    //public Text showPlayerRounds;
    //public Text playingSizeText;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject); // don't destroy this game object when a new scene is loaded.
    }

    /*private void Update() //I left my timestamp on so you see that it updates in real time
    {
        Debug.Log(PlayerName + " has " + PlayerRounds + " lives and " + PlayingSpeed + " speed.");
    }
    public void UpdateName() //executed in each letter change
    {
        PlayerName = PlayerNameInput.text; // assign new input text to string
        Debug.Log(PlayerName); //prints updated name to log on each letter change
        showPlayerName.text = PlayerName; // show string in the textbox just to see that it works in the Intro scene. 
    }
    public void ShowName() //method for the show name button on intro
    {
        showPlayerName.text = PlayerName;
        Debug.Log(PlayerName);
    }
    */
    public void SetSpeed() //method for clicking on "give 10 lives" button on intro
    {
        PlayingSpeed = SpeedDropDown.value;
    }
    public void ShowSpeed() //method for show lives button on game screen
    {
        SpeedDropDown.value = PlayingSpeed;
    }

    public void SetSize() //method for the slider on intro screen
    {
        PlayingSize = SizeSlider.value;
        //playingSizeText.text = PlayingSize.ToString();
    }
    public void ShowSize() // method for clicking on playing speed button on game screen 
    {
        //playingSizeText.text = PlayingSize.ToString();
        SizeSlider.value = PlayingSize; // you use the speed value here

    }
    public void ChangeSize() //method for slider on game screen, so you see that you can still change the value after transfer between screens
    {
        PlayingSize = SizeSlider.value; // change to the new value from game screen slider
        //playingSizeText.text = SizeSlider.value.ToString(); //show updated value
    }
    /*public void DieOnce() // click event for Die Once button
    {
        PlayerRounds -= 1; //one less life to live
        showPlayerRounds.text = PlayerRounds.ToString() + " lives";
        Debug.Log("lives: " + PlayerRounds);
    }*/
    /*
     * change background - inspector for camera, from skybox to solid color
     * for transfer data: attach a script (like "KeepData") to an empty game object (like "DataManager")
     * public static (data type) (variable name);
     * if you get the value from a control, make the control public: public (UI element) (UI name)  AND LOAD THE OBJECT TO THE BOX IN THE INSPECTOR
     * create the DataManager with the KeepData script in all scenes including introduction and exit screens
     * 
     */

}