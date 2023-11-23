using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        public IDataResult<List<Category>> GetAll();
        public IDataResult<List<Category>> GetByCategoryId(int id);
        public IResult Add(Category category);
        public IResult Update(Category category);
        public IResult Delete(Category category);
    }
}
