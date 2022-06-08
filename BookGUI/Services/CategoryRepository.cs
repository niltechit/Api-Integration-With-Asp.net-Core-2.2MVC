using BookApiProject.Dtos;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace BookGUI.Services
{
    public class CategoryRepository : ICategoryRepositoryGUI
    {
        BaseAddress baseAddress=new BaseAddress();
        public IEnumerable<BookDto> GetAllBooksForCategory(int CategoryId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<CategoryDto> GetAllCategoryOfABook(int bookId)
        {
            throw new System.NotImplementedException();
        }

        public CategoryDto GetCategoryById(int categoryId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<CategoryDto> GetCategoryDtos()
        {
            var baseUrl = baseAddress.baseUrl;
            IEnumerable<CategoryDto> categories = new List<CategoryDto>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);

                var reponse = client.GetAsync("categories");
                reponse.Wait();

                var result = reponse.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<CategoryDto>>();
                    readTask.Wait();

                    categories = readTask.Result;
                }

            }

            return categories;
        }
    }
}
