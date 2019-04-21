using UnityEngine;
using System.Collections;

public class menuStart : MonoBehaviour {


	// Use this for initialization
	public void changeScene(string scenename)
    {
        Application.LoadLevel(1); 
    }

    // Use this for initialization
    public void changeScene2(string scenename)
    {
        Application.LoadLevel(scenename);
    }
}
