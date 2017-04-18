using UnityEngine;
using System.IO;
using System;
namespace Artificial.StorySystem
{
    public class StoryManager : MonoBehaviour
    {
        public string storyFilePath = "Resources/story.json";
        public EventHandler OnStoryLoaded;

        private Story _story;
        private bool _initialized = false;

        public Story story
        {
            get
            {
                return _story;
            }
            protected set
            {
                _story = value;
                TriggerStoryLoaded();
            }
        }

        public bool initialized
        {
            get
            {
                return _initialized;
            }
            protected set
            {
                _initialized = value;
            }
        }
        
        public void Awake()
        {
            OnStoryLoaded += StoryLoaded;
            loadStory();            
        }

        public void loadStory()
        {
            string filePath = Path.Combine(Application.streamingAssetsPath, storyFilePath);

            if (File.Exists(filePath))
            {
                string dataAsJson = File.ReadAllText(filePath);
                Debug.Log(dataAsJson);
                story = new Story(Story.Create(filePath));
            }
            else
            {
                Debug.Log("Cannot load story data");
            }
        }

        private void StoryLoaded(object sender = null, EventArgs e = null)
        {
            initialized = true;
            story.Begin();
        }

        public void TriggerStoryLoaded()
        {
            if(OnStoryLoaded != null)
            {
                OnStoryLoaded(this, null);
            }
        }
    }
}
