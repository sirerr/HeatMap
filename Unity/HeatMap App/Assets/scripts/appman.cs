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

	public GameObject slidearea;
	public GameObject locationOn;
	public GameObject MapObj;

	public bool appstarted = false;

	public mapmanager mapmanref;

	public void Awake()
	{
		mapmanref = GetComponent<mapmanager>();
	}

	public void unlockphone()
	{
		lockscreen.SetActive(false);
	//	print("unlockedphone");
		unlockbutton.SetActive(false);
	}

	public void startApp()
	{
		if(!appstarted)
		{
			appbutton.SetActive(false);
			homescreen.SetActive(false);
			mainbackground.SetActive(true);
			firstscreenObj.SetActive(true);
			appstarted = true;
		}
		else
		{
			appbutton.SetActive(false);
			homescreen.SetActive(false);

			mainbackground.SetActive(true);
			MapObj.SetActive(true);
			slidearea.SetActive(true);
		}


	}

	public void backtohome()
	{
		slidearea.SetActive(false);
		MapObj.SetActive(false);
		mainbackground.SetActive(false);
		appbutton.SetActive(true);
		homescreen.SetActive(true);
		mapmanref.slideopen = false;
	}

	public void  logintoApp()
	{
		print("loggin into the app");
		firstscreenObj.SetActive(false);
		MapObj.SetActive(true);
		slidearea.SetActive(true);
	}


}
