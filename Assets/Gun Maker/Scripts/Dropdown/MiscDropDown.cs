using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class MiscDropDown : MonoBehaviour, IPointerClickHandler{

	public RectTransform container;
	public static bool isOpen;
	public bool selected;
	public string childcontainer;
	public bool RIFisOpen;
	public bool SMGisOpen;
	public bool DMRisOpen;
	public bool MiscisOpen;
	public bool AccisOpen;

	public int toggle = 1;
	// Use this for initialization
	void Start () 
	{
		container = transform.FindChild(childcontainer).GetComponent<RectTransform>();
		isOpen = false;
		selected = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (isOpen) 
		{
			Vector3 scale = container.localScale;
			scale.y = Mathf.Lerp(scale.y, 1, Time.deltaTime *12);
			container.localScale = scale;
		}
		else
		{
			Vector3 scale = container.localScale;
			scale.y = Mathf.Lerp(scale.y, 0, Time.deltaTime *12);
			container.localScale = scale;
		}

	
	}

	

	public void OnPointerClick(PointerEventData eventData)
	{	
		
		switch (toggle)
		{
			
			
		case 2:
			isOpen = false;
			toggle--;
			break;
			
			
		case 1:
			isOpen = true;
			toggle++;
			break;
			
		default:
			isOpen = true;
			toggle = 1;
			break;
		}
		
	}

}
