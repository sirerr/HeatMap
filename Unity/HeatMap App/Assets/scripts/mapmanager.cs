using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mapmanager : MonoBehaviour {

	//opening slider bar
	public Button openslider;
	public Animator sliderAnim;
	public bool slideopen = false;

	// toggle
	public Toggle transmitOn;
	public Animator outsidersAnim;

	//toggle heatOn
	public Toggle heatOn;
	public GameObject heatLayerObj;

	public void opensliderarea()
	{
		if(!slideopen)
		{
			sliderAnim.ResetTrigger("close");
			sliderAnim.SetTrigger("open");
			slideopen = true;
		}
		else
		{
			sliderAnim.ResetTrigger("open");
			sliderAnim.SetTrigger("close");
			slideopen = false;
		}

	}

	public void ToggleOn()
	{

		if(transmitOn.isOn)
		{
			outsidersAnim.enabled = true;
		}
		else
		{
			outsidersAnim.enabled = false;
		}
	}

	public void ControlHeat()
	{
		if(heatOn.isOn)
		{
			heatLayerObj.SetActive(true);
		}
		else
		{
			heatLayerObj.SetActive(false);
		}

	}

		
}
