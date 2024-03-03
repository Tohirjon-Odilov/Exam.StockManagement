using Exam.StockManagement.Domain.Entities.DTOs;
using Exam.StockManagement.Domain.Entities.Models;
using Exam.StockManagement.Domain.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Exam.StockManagement.Application.Abstractions.IServices
{
    public interface IProductService
    {
        public Task<Product> Create(ProductDTO userDTO);
        public Task<Product> GetByName(string name);
        public Task<Product> GetById(int Id);
        public Task<Product> GetByEmail(string email);
        public Task<Product> GetByLogin(string email);
        public Task<IEnumerable<ProductViewModel>> GetAll();
        public Task<bool> Delete(Expression<Func<Product, bool>> expression);
        public Task<Product> Update(int Id, ProductDTO userDTO);
    }
}
