using System;

namespace Artificial.StorySystem
{
    public class ActCollection
    {
        private Act[] _acts;

        public Act[] acts
        {
            get
            {
                return _acts;
            }
            set
            {
                _acts = value;
            }
        }

        public void Begin()
        {
            acts[0].Begin();
        }
    }
}
