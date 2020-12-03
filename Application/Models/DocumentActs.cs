using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Application.Data;

namespace Application.Models
{
    public class DocumentActs
    {
        public List<Document> GetDocuments()
        {
            DocumentData documents = new DocumentData();

            return documents.Documents; 
        }
    }
}