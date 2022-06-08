using BookApiProject.Dtos;
using System.Collections.Generic;

namespace BookGUI.ViewModels
{
    public class Receiver
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public int AuthorsId { get; set; }
        public int CategoriesId { get; set; }

        //public List<CategoryDto> Categories { get; set; }
        //public List<AuthorDto> Authors { get; set; }

    }
}
