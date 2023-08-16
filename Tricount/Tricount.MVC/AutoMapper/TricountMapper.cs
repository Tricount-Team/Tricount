using AutoMapper;
using Tricount.Entities.Concrete;
using Tricount.MVC.Models.DTO_s.Expense;
using Tricount.MVC.Models.DTO_s.Group;
using Tricount.MVC.Models.DTO_s.Payment;

namespace Tricount.MVC.AutoMapper
{
    public class TricountMapper : Profile
    {
        public TricountMapper()
        {
            CreateMap<ExpenseCreateDTO, Expense>();
            CreateMap<GroupCreateDTO, Group>();
            CreateMap<PaymentCreateDTO, Payment>();
        }
    }
}
