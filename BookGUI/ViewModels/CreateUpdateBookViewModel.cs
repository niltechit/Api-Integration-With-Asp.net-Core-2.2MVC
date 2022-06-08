using BookApiProject.Dtos;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace BookGUI.ViewModels
{
    public class CreateUpdateBookViewModel
    {
        public BookDto Book { get; set; }
        public List<CategoryDto> Categories { get; set; }
        public List<AuthorDto> Authors { get; set; }
        public List<int> AuthorsIds { get; set; }
        public List<SelectListItem> AuthorsSelectListItems { get; set; }
        public List<int> CategoriesIds { get; set; }
        public List<SelectListItem> CategoriesSelectListItems { get; set; }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public DateTime? DatePublished { get; set; }

        public int AuthorsId { get; set; }
        public int CategoriesId { get; set; }
    }
}
