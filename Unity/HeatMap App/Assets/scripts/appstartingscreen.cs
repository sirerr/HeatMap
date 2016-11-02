using UnityEngine;
using System.Collections;

public class appstartingscreen : MonoBehaviour {

	//logo
	public GameObject logoObj;

	public GameObject otherobj0;
	public GameObject otherobj1;
	public GameObject otherobj2;
	public GameObject otherobj3;
	public GameObject otherobj4;

	public void OnEnable()
	{
		logoObj.SetActive(true);

		StartCoroutine(doMore());
	}

	IEnumerator doMore()
	{
		yield return new WaitForSeconds(2f);
		otherobj0.SetActive(true);
		otherobj1.SetActive(true);
		otherobj2.SetActive(true);
		otherobj3.SetActive(true);
		otherobj4.SetActive(true);

	}
}
