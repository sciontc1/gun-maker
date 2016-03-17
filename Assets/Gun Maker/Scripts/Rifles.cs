using UnityEngine;
using System.Collections;



public class Rifles : MonoBehaviour 
{
    public string[] items;
    public Rect Box;
    public string slectedItem = "None";
	public bool p90created = false;
	public bool m4created = false;
	public bool m14created = false;


    private bool editing = false;

    private void OnGUI()
    {
        if (GUI.Button(Box, slectedItem))
        {
            editing = true;
        }

        if (editing)
        {
            for (int x = 0; x < items.Length; x++)
            {
                if (GUI.Button(new Rect(Box.x, (Box.height * x) + Box.y + Box.height, Box.width, Box.height), items[x]))
                {
                    slectedItem = items[x];
                    editing = false;

                }
            }
        }
		
		if(slectedItem == "P90")
		{
			print ("p90 created");
			if(p90created == false)
			{
				GameObject p90 = Instantiate(Resources.Load("P90prefab")) as GameObject;
				p90created = true;
			}
		}
		if(slectedItem == "M4A1")
		{
			print ("M4A1 created");
			if(m4created == false)
			{
				GameObject m4 = Instantiate(Resources.Load("M4A1prefab")) as GameObject;
				m4created = true;
			}

		}
		
		if(slectedItem == "M14 EBR")
		{
			print ("M14 created");
			if(m14created == false)
			{
				GameObject m14 = Instantiate(Resources.Load("M14prefab")) as GameObject;
				m14created = true;
			}

		}

    }
}