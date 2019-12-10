using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.UI;

public class FileScores : MonoBehaviour
{
    public Text fileContents;

    public void ReadString() //NEED TO MAKE THIS PUBLIC SO WE CAN CONNECT TO BUTTON
    {
        string path = "/Users/terycook/Documents/Documents/game_programming/final/FinalExam2019Fall-master/Assets/Scripts/scores.txt";

        // In case we want to use appending of text.
        //string appendText = "This is extra text" + "\n";
        //File.AppendAllText(path, appendText);

        fileContents.text = ""; // clear the text on screen

        // Open the file to read from.
        string[] readText = File.ReadAllLines(path);
        foreach (string s in readText)
        {
            Debug.Log(s);
            fileContents.text += s + "\n"; // append and go to new line
        }

      
    }

    private void Awake()
    {
        ReadString();
    }
}
