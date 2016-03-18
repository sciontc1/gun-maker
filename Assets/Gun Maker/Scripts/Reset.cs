using UnityEngine;
using System.Collections;



public class Reset : MonoBehaviour 
{
	public string[] items;
	public Rect Box;
	public string slectedItem = "Reset";
	//int scwidth = Screen.width;
	//int scheight = Screen.height;
//	int btnwidth = scwidth/5;
	
	
	private bool editing = false;



	
	private void OnGUI()
	{	


		// device get width
		// device width / 5
		// set padding
		//set positons
		//screen.height
		//screen.width
		// 1440x2560 2K

		if (GUI.Button(Box, slectedItem))
		{
			Application.LoadLevel("Workshop");
		}
			


	}
}