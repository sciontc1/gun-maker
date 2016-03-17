using UnityEngine;
using System.Collections;

public class Accessories : MonoBehaviour 
{
    public string[] items;
    public Rect Box;
    public string slectedItem = "None";

    private bool editing = false;
	
	public bool acogcreated = false;
	public bool suppresorcreated = false;
	public bool peq2created = false;

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
		
		if(slectedItem == "ACOG")
		{
			print ("Acog created");
			if(acogcreated == false)
			{
				GameObject acog = Instantiate(Resources.Load("acogprefab")) as GameObject;
				acogcreated = true;
			}
		}
		if(slectedItem == "Suppresor")
		{
			print ("suppresor created");
			if(suppresorcreated == false)
			{
				GameObject suppresor = Instantiate(Resources.Load("silencerprefab")) as GameObject;
				suppresorcreated = true;
			}

		}
		
		if(slectedItem == "PEQ 2")
		{
			print ("PEQ 2 created");
			if(peq2created == false)
			{
				GameObject peq2 = Instantiate(Resources.Load("peq2prefab")) as GameObject;
				peq2created = true;
			}

		}

    }
}