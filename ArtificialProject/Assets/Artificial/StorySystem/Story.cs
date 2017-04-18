using System.Collections.Generic;
using UnityEngine;

namespace Artificial.StorySystem
{
    public class Story
    {
        private ActCollection _acts;
        public ActCollection acts
        {
            get
            {
                if (_acts == null)
                {
                    _acts = new ActCollection();
                }
                return _acts;
            }
            set
            {
                _acts = value;
            }
        }

        public Story()
        {
            acts = new ActCollection();
        }

        public Story(Story story)
        {
            acts = story.acts;
        }

        public static Story Create(string jsonData)
        {
            //return story from jsonData
            Story s = new Story();
            s.acts = JsonUtility.FromJson<ActCollection>(jsonData);
            return s;
        }

        public void Begin()
        {
            acts.Begin();
        }
    }
}
