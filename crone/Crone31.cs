﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crone31 : MonoBehaviour
{
	private int count = 0;
	public GameObject originObject; //オリジナルのオブジェクト



	void Update()
	{
		if (Input.anyKeyDown)
		{
			count++;


			if (count == 3)
			{
				Quaternion q = Quaternion.Euler(0f, 180.0f, 0.0f);

				Instantiate(originObject, new Vector3(5.0f, -0.5f, 2.0f), q);
			}

			if (count == 6)
			{
				Quaternion q = Quaternion.Euler(0f, 180.0f, 0.0f);

				Instantiate(originObject, new Vector3(6.0f, -0.5f, 2.0f), q);
			}
			if (count == 9)
			{
				Quaternion q = Quaternion.Euler(0f, 180.0f, 0.0f);

				Instantiate(originObject, new Vector3(7.0f, -0.5f, 2.0f), q);
			}
			if (count == 14)
			{
				Quaternion q = Quaternion.Euler(0f, 180.0f, 0.0f);

				Instantiate(originObject, new Vector3(8.0f, -0.5f, 6.0f), q);
			}
			if (count == 15)
			{
				Quaternion q = Quaternion.Euler(0f, 180.0f, 0.0f);

				Instantiate(originObject, new Vector3(8.0f, -0.5f, 7.0f), q);
			}
			if (count == 16)
			{
				Quaternion q = Quaternion.Euler(0f, 180.0f, 0.0f);

				Instantiate(originObject, new Vector3(8.0f, -0.5f, 8.0f), q);
			}





		}
	}
}

