using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}

    public void OnPlayClick()
    {
        SceneManager.LoadScene("MiniGame");
    }
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
