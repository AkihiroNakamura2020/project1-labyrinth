﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crone26 : MonoBehaviour
{
	private int count = 0;
	public GameObject originObject; //オリジナルのオブジェクト



	void Update()
	{
		if (Input.anyKeyDown)
		{
			count++;


			if (count == 12)
			{
				Quaternion q = Quaternion.Euler(0f, 180.0f, 0.0f);

				Instantiate(originObject, new Vector3(7.0f, -0.5f, 5.0f), q);
			}

			if (count == 13)
			{
				Quaternion q = Quaternion.Euler(0f, 180.0f, 0.0f);

				Instantiate(originObject, new Vector3(6.0f, -0.5f, 6.0f), q);
			}
			if (count == 14)
			{
				Quaternion q = Quaternion.Euler(0f, 180.0f, 0.0f);

				Instantiate(originObject, new Vector3(9.0f, -0.5f, 6.0f), q);
			}





		}
	}
}

