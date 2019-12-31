using System;
using UnityEngine;
// THIS SHOULD BE ENOUGH INCLUDES FOR OUR MENU GUI

/* Basic Instructions:
        Find an OnGUI() method that is being called regularly in game (Things like DrawCursor, DrawHealthBar, etc.)
        Add "using ModMenuSpace" to the method includes
        Add ModMenu.DrawMenu() to the OnGUI() Method line 1

        I also usually delete this from my game-specific copy of the script because it just looks dumb :D
*/

// I keep a note here with the Method used for the OnGUI call that I hook to call DrawMenu()
// ModMenuSpace.ModMenu.DrawMenu() is called in method: << INSERT CLASS AND ONGUI METHOD HERE USED FOR HOOK>>

// CHEAT 1 = Put Cheat 1 description and modified class and method text here
// CHEAT 2 = Put Cheat 2 description and modified class and method text here
// CHEAT 3 = Put Cheat 3 description and modified class and method text here
// CHEAT 4 = Put Cheat 4 description and modified class and method text here

namespace ModMenuSpace
{
	    //Our namespace to keep menu organized and seperate from the game code
	public class ModMenu : MonoBehaviour
	{
			// Variables needed for menu
		public static string MenuLabel = "MOD MENU TITLE";
		public static bool MenuVisible = false;
		public static bool Cheat1Active = false;
		public static string Cheat1Label = "Cheat 1 OFF";
		public static bool Cheat2Active = false;
		public static string Cheat2Label = "Cheat 2 OFF";
		public static bool Cheat3Active = false;
		public static string Cheat3Label = "Cheat 3 OFF";
		public static bool Cheat4Active = false;
		public static string Cheat4Label = "Cheat 4 OFF";

		public static void DrawMenu()
		{
			// DRAW THE MENU HERE

			    // Toggle Menu button (always visible)
			if (GUI.Button(new Rect(0f,0f,100f,30f),"Toggle Menu"))
			{
				MenuVisible = !MenuVisible;
			}


			    // This will only be drawn when menu is toggled on
			if (MenuVisible)
			{
    			    // Cheat Header and Canvas
				GUI.Box(new Rect(100f,0f,500f,400f),MenuLabel);

                    // Cheat 1 Button
                if (GUI.Button(new Rect(100f,30f,180f,30f),Cheat1Label))
			    {
				    Cheat1Active = !Cheat1Active;

                    if (Cheat1Active) 
                    { 
                        Cheat1Label = "Cheat 1 ON"; 
                    } else { 
                        Cheat1Label = "Cheat 1 OFF"; 
                    }
			    }

				    // Cheat 2 Button
                if (GUI.Button(new Rect(100f,60f,180f,30f),Cheat2Label))
			    {
				    Cheat2Active = !Cheat2Active;

                    if (Cheat2Active) 
                    { 
                        Cheat2Label = "Cheat 2 ON"; 
                    } else { 
                        Cheat2Label = "Cheat 2 OFF"; 
                    }
			    }

				    // Cheat 3 Button
                if (GUI.Button(new Rect(100f,90f,180f,30f),Cheat3Label))
			    {
				    Cheat3Active = !Cheat3Active;

                    if (Cheat3Active) 
                    { 
                        Cheat3Label = "Cheat 3 ON"; 
                    } else { 
                        Cheat3Label = "Cheat 3 OFF"; 
                    }
			    }

				    // Cheat 4 Button
                if (GUI.Button(new Rect(100f,120f,180f,30f),Cheat4Label))
			    {
				    Cheat4Active = !Cheat4Active;

                    if (Cheat4Active) 
                    { 
                        Cheat4Label = "Cheat 4 ON"; 
                    } else { 
                        Cheat4Label = "Cheat 4 OFF"; 
                    }
			    }
			}
		}
	}
}
