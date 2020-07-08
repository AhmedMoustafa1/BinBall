using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


    [CustomEditor(typeof(GameEventListener))]
    [CanEditMultipleObjects]
    public class GameEventListenerEditor : Editor
    {
        GameEventListener listner;
        private void OnEnable()
        {
            listner = (GameEventListener)target;
        }
        public override void OnInspectorGUI()
        {
            EditorGUILayout.PropertyField(serializedObject.FindProperty("isMultiple"));
            if (listner.isMultiple)
            {
                EditorGUILayout.PropertyField(serializedObject.FindProperty("Events"));

            }
            else
            {
                EditorGUILayout.PropertyField(serializedObject.FindProperty("Event"));
            }
            EditorGUILayout.PropertyField(serializedObject.FindProperty("Response"));

            serializedObject.ApplyModifiedProperties();

            
        }
    }
