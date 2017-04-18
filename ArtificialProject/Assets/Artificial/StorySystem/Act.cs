using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Artificial.StorySystem
{
    public class Act
    {
        private int _id;
        private List<Dialogue> _dialougues;

        public int id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public List<Dialogue> dialougues
        {
            get
            {
                return _dialougues;
            }

            set
            {
                _dialougues = value;
            }
        }

        public void Begin()
        {
            Debug.Log(dialougues[0].name + dialougues[0].responses.ToString());
        }
    }
}
