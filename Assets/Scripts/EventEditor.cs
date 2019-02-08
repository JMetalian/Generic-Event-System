using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(IntEvent))]
    public class EventEditor : Editor
    {
        
        public override void OnInspectorGUI()
        {
            
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            GameEvent Raise_button = target as GameEvent;// button press is created as a Game event
            if (GUILayout.Button("Raise")){// creates the raise button
                Raise_button.Raise();// raises the event
            }
            GameEvent Listeners_button = target as GameEvent;//same as line 17
            if (GUILayout.Button("Display Listeners")){// creates the Display Listeners button
                Listeners_button.DisplayListeners();// calls the Display Listeners function
                
            }
            GUILayout.TextArea("");
                
            
        }
    }
