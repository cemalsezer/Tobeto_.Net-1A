using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IInstructorService
    {
        Task<Paginate<GetListInstructorResponse>> GetListAsync();
        Task<CreatedInstructorResponse> Add(CreateInstructorRequest createInstructorRequest);
        Task<GetInstructorResponse> GetAsync(Expression<Func<Instructor, bool>> filter);
        Task<UpdatedInsturctorResponse> Update(UpdateInsturctorRequest updateInstructorRequest);
        Task<DeletedInsturctorResponse> Delete(DeleteInstructorRequest deleteInstructorRequest);
    }
}
