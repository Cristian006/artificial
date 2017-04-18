using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Artificial.StorySystem
{
    public class Response
    {
        private int _nextID;
        private string _response;

        public int nextID
        {
            get
            {
                return _nextID;
            }
            set
            {
                _nextID = value;
            }
        }

        public string response
        {
            get
            {
                return _response;
            }
            set
            {
                _response = value;
            }
        }

        public Response()
        {
            //Empty Constructor
            response = string.Empty;
            nextID = -1;
        }

        public Response(Response res)
        {
            nextID = res.nextID;
            response = res.response;
        }

        public static Response Create(string jsonString)
        {
            return null;
        }
    }
}
