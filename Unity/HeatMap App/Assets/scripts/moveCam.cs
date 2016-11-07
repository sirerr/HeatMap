using UnityEngine;
using System.Collections;

public class moveCam : MonoBehaviour {

	public Rigidbody movecam;

	public float pushfloat =5;

	public Transform centerpoint;
	public Camera topcam;

	public Vector3 dir;
	public appman appmanref;

	void Start()
	{
		topcam = GetComponent<Camera>();

	}

	public void Update()
	{
		bool mouseclick = Input.GetMouseButtonDown(0);
		Vector3 mousepos = topcam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,topcam.nearClipPlane));
		print(mousepos);

		if(mouseclick && appmanref.MapObj.activeSelf)
		{
			dir = mousepos - centerpoint.position;
			movecam.AddForce(dir *pushfloat *Time.deltaTime);
		}

	


	}

}
