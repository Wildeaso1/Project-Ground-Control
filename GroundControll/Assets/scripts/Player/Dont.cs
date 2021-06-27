using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dont : MonoBehaviour
{

	void Awake()
	{
		DontDestroyOnLoad(this.gameObject);
	}
}
