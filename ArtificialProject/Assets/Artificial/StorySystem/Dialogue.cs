using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Artificial.StorySystem
{
    public class Dialogue
    {
        private int _id;
        private string _name;
        private string _dialogue;
        private List<Response> _responses;

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

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string dialogue
        {
            get
            {
                return _dialogue;
            }

            set
            {
                _dialogue = value;
            }
        }

        public List<Response> responses
        {
            get
            {
                return _responses;
            }

            set
            {
                _responses = value;
            }
        }

        public Dialogue()
        {
            //Empty Constructor
            id = -1;
            name = string.Empty;
            dialogue = string.Empty;
            responses = new List<Response>();
        }

        public Dialogue(Dialogue dia)
        {
            id = dia.id;
            name = string.Empty;
            dialogue = dia.dialogue;
            responses = dia.responses;
        }

        public static Dialogue Create(string jsonString)
        {
            return null;
        }
    }
}
