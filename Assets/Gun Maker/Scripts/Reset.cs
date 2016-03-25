using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;



public class Reset : MonoBehaviour, IPointerClickHandler
{
	public string[] items;
	public Rect Box;
	public string slectedItem = "Reset";

	public void OnPointerClick(PointerEventData eventData)
	{	
		
		Application.LoadLevel("Workshop");
		
	}

}