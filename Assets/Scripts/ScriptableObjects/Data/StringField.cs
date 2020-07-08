using System;

using UnityEngine;



    [CreateAssetMenu]

    public class StringField : ScriptableObject
    {
  
        [SerializeField]
        private String value;
        public String Value
        {
            get
            {

                return value;
            }

            set
            {

                this.value = value;
            
            }
        }
    }

