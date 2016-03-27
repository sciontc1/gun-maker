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

    }
}