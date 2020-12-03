using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Application.Controllers
{
    public class BoardController : Controller
    {
        // GET: Board
        public ActionResult List()
        {
            //Model에 선언한 DocumentActs 비즈니스 로직 클래스 객체 선언
            DocumentActs documents = new DocumentActs();
            var document = documents.GetDocuments();

            //Model에 선언한 MemberActs 비즈니스 로직 클래스 객체 선언
            MemberActs members = new MemberActs();
            var member = members.GetMembers(2);

            //ViewBag에 Member 모델 추가
            //ViewBag.Member = member;

            //ViewData에 Member 모델 추가
            ViewData["Member"] = member;

            //데이터 객체를 View 에 전달
            return View(document);
        }
    }
}