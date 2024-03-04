namespace Exam.StockManagement.Domain.Entities.Enums
{
    public enum Permissions
    {
        CreateProduct = 100,
        GetAllUser,
        UpdateProduct,
        DeleteProduct,
        CreateCategory,
        UpdateCategory,
        DeleteCategory,

        GetAllCategory = 200,
        GetSum,
        GetQuantity,
        GetByCategorySum,
        GetByCategoryProduct,
        GetByCategoryQuantity,
        GetAllProduct,
    }
}
