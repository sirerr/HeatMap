using UnityEngine;
using System.Collections;

public class moveCam : MonoBehaviour {

	public Rigidbody movingcam;

	public float pushfloat =5;

	public Transform centerpoint;
	public Camera topcam;

	public Vector3 dir;
	public appman appmanref;
	public mapmanager mapmanref;

	void Start()
	{
		topcam = GetComponent<Camera>();

	}

	public void Update()
	{
		bool mouseclick = Input.GetMouseButtonDown(0);
		Vector3 mousepos = topcam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,topcam.nearClipPlane));
	//	print(mousepos);

		if(mouseclick && appmanref.MapObj.activeSelf && !mapmanref.slideopen)
		{
			dir = mousepos - centerpoint.position;
			movingcam.AddForce(dir *pushfloat *Time.deltaTime);
			StartCoroutine(stopmoving());
		}

	}

	IEnumerator stopmoving()
	{
		yield return new WaitForSeconds(5f);
		movingcam.velocity = Vector3.zero;
	}

}
