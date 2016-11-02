using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class appman : MonoBehaviour {


	//gameobjects in lockscreen
	public GameObject lockscreen;
	public GameObject unlockbutton;

	//appbutton
	public GameObject appbutton;
	public GameObject homescreen;

	//background of app
	public GameObject mainbackground;
	//firstscreen
	public GameObject firstscreenObj;


	public void unlockphone()
	{
		lockscreen.SetActive(false);
	//	print("unlockedphone");
		unlockbutton.SetActive(false);
	}

	public void startApp()
	{
		appbutton.SetActive(false);
		homescreen.SetActive(false);
		mainbackground.SetActive(true);
		firstscreenObj.SetActive(true);
	}

	public void backtohome()
	{
		appbutton.SetActive(true);
		homescreen.SetActive(true);

	}

	public void  logintoApp()
	{
		print("loggin into the app");

	}


}
