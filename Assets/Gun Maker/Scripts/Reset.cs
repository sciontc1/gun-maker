using UnityEngine;
using System.Collections;



public class Reset : MonoBehaviour 
{
	public string[] items;
	public Rect Box;
	public string slectedItem = "None";

	
	
	private bool editing = false;
	
	private void OnGUI()
	{	


		// device get width
		// device width / 5
		// set padding
		//set positons

		if (GUI.Button(Box, slectedItem))
		{
			Application.LoadLevel("Workshop");
		}
			


	}
}