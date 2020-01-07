using System;
using Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DataAccess.Data.Repository.IRepo
{
    public interface ICategoryRepository: IRepo<Category>
    {
        IEnumerable<SelectListItem> GetCategoryListForDropDown();

        void Update(Category category);

    }
}
