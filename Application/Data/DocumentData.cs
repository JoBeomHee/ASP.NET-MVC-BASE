using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.Data
{
    public class DocumentData
    {
        public List<Document> Documents
        {
            get
            {
                return new List<Document>
                {
                    new Document{MyDocument_Number=1, Title="범범조조", Writer="범범조조" },
                    new Document{MyDocument_Number=2, Title="아이유", Writer="범범조조" },
                    new Document{MyDocument_Number=3, Title="정형돈", Writer="범범조조" },
                    new Document{MyDocument_Number=4, Title="박명수", Writer="범범조조" },
                    new Document{MyDocument_Number=5, Title="유재석", Writer="범범조조" }
                };
            }
        }
    }
}