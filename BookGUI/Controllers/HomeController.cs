using BookApiProject.Models;
using BookGUI.Components;
using BookGUI.Services;
using BookGUI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace BookGUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryRepositoryGUI categoryRepositoryGUI;
        private readonly IAuthorRepositoryGUI authorRepositoryGUI;
        public HomeController(ICategoryRepositoryGUI _categoryRepositoryGUI, IAuthorRepositoryGUI _authorRepositoryGUI)
        {
            categoryRepositoryGUI = _categoryRepositoryGUI;
            authorRepositoryGUI = _authorRepositoryGUI;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateBook()
        {
            //var categories = categoryRepositoryGUI.GetCategoryDtos();
            //var authors = authorRepositoryGUI.GetAuthors();

            //if (authors.Count() <= 0 || categories.Count() <= 0)
            //{
            //    ModelState.AddModelError("", "There are problem Authors and Category");
            //}

            //var authorsList = new AuthorsList(authors.ToList());
            //var categoriesList = new CategoriesList(categories.ToList());

            //var CreateBook = new CreateUpdateBookViewModel
            //{
            //    AuthorsSelectListItems = authorsList.GetAuthorsList(),
            //    CategoriesSelectListItems = categoriesList.GetCategoriesList(),
            //};

           // CreateUpdateBookViewModel createbook =new CreateUpdateBookViewModel ();
            //Receiver createbook =new Receiver();
            //createbook.Categories=categories.ToList();
            //createbook.Authors=authors.ToList();

            return View();
        }


        [HttpPost]
        public IActionResult CreateBook(Receiver rcv)
        {
            
            return View();
        }

        //[HttpPost]
        //public IActionResult CreateBook(CreateUpdateBookViewModel model)
        //{
        //    //using (var client = new HttpClient())
        //    //{
        //    //    var book = new Book()
        //    //    {
        //    //        Id = model.Book.Id,
        //    //        Isbn = model.Book.Isbn,
        //    //        Title = model.Book.Title,
        //    //        DatePublished = model.Book.DatePublished,

        //    //    };
        //    //    //var uriParameters = GetAuthorCategoriesUri(AuthorIds.ToList(), CategoriesIds.ToList());
        //    //    //client.BaseAddress = new Uri("http://localhost:60039/api/");
        //    //    //var responseTask = client.PostAsJsonAsync($"book?{uriParameters}",book);
        //    //    responseTask.Wait();
        //    //    var result=responseTask.Result;
        //    //    if (result.IsSuccessStatusCode)
        //    //    {
        //    //        var readTaskNewBook = result.Content.ReadAsAsync<Book>();
        //    //        readTaskNewBook.Wait();

        //    //        var newBook = readTaskNewBook.Result;
        //    //        TempData["SuccessMessage"] = $"Book {book.Title} was successfully created";
        //    //        return RedirectToAction("GetBookById",new { bookId=newBook.Id});
        //    //    }
        //    //}
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult CreateBook(//IEnumerable<int> AuthorIds, IEnumerable<int> CategoriesIds,
        //    CreateUpdateBookViewModel model)
        //{
        //    //using (var client = new HttpClient())
        //    //{
        //    //    var book = new Book()
        //    //    {
        //    //        Id = model.Book.Id,
        //    //        Isbn = model.Book.Isbn,
        //    //        Title = model.Book.Title,
        //    //        DatePublished = model.Book.DatePublished,

        //    //    };
        //    //    //var uriParameters = GetAuthorCategoriesUri(AuthorIds.ToList(), CategoriesIds.ToList());
        //    //    //client.BaseAddress = new Uri("http://localhost:60039/api/");
        //    //    //var responseTask = client.PostAsJsonAsync($"book?{uriParameters}",book);
        //    //    responseTask.Wait();
        //    //    var result=responseTask.Result;
        //    //    if (result.IsSuccessStatusCode)
        //    //    {
        //    //        var readTaskNewBook = result.Content.ReadAsAsync<Book>();
        //    //        readTaskNewBook.Wait();

        //    //        var newBook = readTaskNewBook.Result;
        //    //        TempData["SuccessMessage"] = $"Book {book.Title} was successfully created";
        //    //        return RedirectToAction("GetBookById",new { bookId=newBook.Id});
        //    //    }
        //    //}
        //    return View();
        //}
        private string GetAuthorCategoriesUri(List<int> AuthorIds, List<int> CategoriesIds)
        {
            var Uri = "";
            foreach (var authorId in AuthorIds)
            {
                Uri += $"authId={authorId}&";
            }
            foreach (var categoryId in CategoriesIds)
            {
                Uri += $"authId={categoryId}&";
            }
            return Uri;
        }
    }
}
