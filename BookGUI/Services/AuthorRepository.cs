using BookApiProject.Dtos;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace BookGUI.Services
{
    public class AuthorRepository : IAuthorRepositoryGUI
    {
        BaseAddress baseAddress=new BaseAddress ();
        public AuthorDto GetAuthorById(int authorId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<AuthorDto> GetAuthors()
        {
            var baseUrl = baseAddress.baseUrl;
            IEnumerable<AuthorDto> authors = new List<AuthorDto>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);

                var reponse = client.GetAsync("authors");
                reponse.Wait();

                var result = reponse.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<AuthorDto>>();
                    readTask.Wait();

                    authors = readTask.Result;
                }

            }

            return authors;
        }

        public IEnumerable<AuthorDto> GetAuthorsOfABook(int bookId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<BookDto> GetBooksByAuthor(int authorId)
        {
            throw new System.NotImplementedException();
        }
    }
}
