using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mapmanager : MonoBehaviour {

	public Button openslider;

	public Button bar;
	public Button resturant;
	public Button coffee;
	public Button grocery;
	public Button clubs;
	public Button publicareas;


	//barobjects
	public GameObject barBack;
	public GameObject barHeat;

	//resturant
	public GameObject restBack;
	public GameObject restHeat;

	//barobjects
	public GameObject coffeeBack;
	public GameObject coffeeHeat;

	//resturant
	public GameObject groceryBack;
	public GameObject groceryHeat;

	//barobjects
	public GameObject clubBack;
	public GameObject clubHeat;

	//resturant
	public GameObject publicBack;
	public GameObject publicHeat;



	public void barAction()
	{
		if(!barBack.activeSelf)
		{
			barBack.SetActive(true);
		//	print("turn on");
		}
		else
		{

			barBack.SetActive(false);
		//	print("turn off");
		}

	}
	public void restAction()
	{
		if(!restBack.activeSelf)
		{
			restBack.SetActive(true);
			//	print("turn on");
		}
		else
		{

			restBack.SetActive(false);
			//	print("turn off");
		}

	}




}
