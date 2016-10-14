//[User][6]
using DotNetNote.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DotNetNote.Controllers
{
    public class UserController : Controller
    {
        //[User][6][1]
        private IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }
        

        //[User][6][2]
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }


        //[User][6][3] : 회원 가입 폼
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        //[User][6][4] : 회원 가입 처리
        [HttpPost]
        public IActionResult Register(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_repository.GetUserByUserId(model.UserId).UserId != null)
                {
                    ModelState.AddModelError("", "이미 가입된 사용자입니다.");
                    return View(model);
                }
            }

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "잘못된 가입 시도!!!");
                return View(model);
            }
            else
            {
                _repository.AddUser(model.UserId, model.Password);
                return RedirectToAction("Index");
            }
        }


        //[User][6][5] : 로그인 폼
        [HttpGet]
        [AllowAnonymous] // 인증되지 않은 사용자도 접근 가능
        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        //[User][6][6] : 로그인 처리
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(
            UserViewModel model, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                if (_repository.IsCorrectUser(model.UserId, model.Password))
                {
                    //[!] 인증 부여
                    var claims = new List<Claim>()
                    {
                        // 로그인 아이디 지정
                        new Claim("UserId", model.UserId),

                        // 기본 역할 지정, "Role" 기능에 "Users" 값 부여
                        new Claim(ClaimTypes.Role, "Users") // 추가 정보 기록
                    };

                    var ci = new ClaimsIdentity(claims, model.Password);

                    await HttpContext.Authentication.SignInAsync(
                        "Cookies", new ClaimsPrincipal(ci));

                    return LocalRedirect("/User/Index");
                }
            }

            return View(model);
        }


        //[User][6][7] : 로그아웃 처리
        public async Task<IActionResult> Logout()
        {
            // Startup.cs의 미들웨어에서 지정한 "Cookies" 이름 사용
            await HttpContext.Authentication.SignOutAsync("Cookies");

            return Redirect("/User/Index");
        }


        //[User][6][8] : 회원 정보 보기 및 수정
        [Authorize]
        public IActionResult UserInfor()
        {
            return View();
        }

        //[User][6][9] : 인사말 페이지
        public IActionResult Greetings()
        {
            //[Authorize] 특성의 또 다른 표현 방법
            // 인증되지 않은 사용자는
            if (User.Identity.IsAuthenticated == false)
            {
                // 로그인 페이지로 리디렉션
                return new ChallengeResult();
            }

            return View();
        }

        //[User][6][10] : 접근 거부 페이지
        public IActionResult Forbidden()
        {
            return View();
        }
    }
}
