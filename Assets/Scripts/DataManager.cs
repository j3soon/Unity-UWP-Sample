using System;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using File = UnityEngine.Windows.File;

public class DataManager : MonoBehaviour
{
    private int num = 0;
	void Start () {
        string filePath = Application.persistentDataPath + "/data";
        if (File.Exists(filePath))
	    {
	        string text = Encoding.ASCII.GetString(File.ReadAllBytes(filePath));
	        num = Int32.Parse(text);
	    }
	    num++;
        File.WriteAllBytes(filePath, Encoding.ASCII.GetBytes(num.ToString()));
	    Text uiText = gameObject.GetComponent<Text>();
	    uiText.text = "You have launched this app " + num + " times.";
	}
}
