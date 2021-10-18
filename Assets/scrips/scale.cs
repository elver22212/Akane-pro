using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scale : MonoBehaviour
{
	// Use this for initialization
	void Start()
	{
		float height = Camera.main.orthographicSize * 2f;
		float width = height * Screen.width / Screen.height;

		if (gameObject.name == "fondo")
		{
			transform.localScale = new Vector3(width, height, 0);
		}
		else
		{
			transform.localScale = new Vector3(width + 3f, 2, 0);
		}
	}

	// Update is called once per frame
	void Update()
	{

	}
}